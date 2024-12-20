﻿using Cerberus.Cerberus.Forms;
using Cerberus.Cerberus.Helpers;
using DevExpress.LookAndFeel;
using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Core;
using System.Text;

namespace Cerberus
{
    internal class Program
    {
        private static byte[] Reverse8(byte[] input)
        {
            byte[] array = new byte[input.Length];
            int num = input.Length - 8;
            int num2 = 0;
            for (int i = 0; i < input.Length / 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    array[num2 + j] = input[num + j];
                }
                num -= 8;
                num2 += 8;
            }
            return array;
        }

        private static RSACryptoServiceProvider LoadXmacsKey()
        {
            System.IO.EndianIO endianIO = new System.IO.EndianIO(RSAKeys.XMACS_RSA_PUB2048, EndianStyle.BigEndian);
            endianIO.Position = 4L;
            byte[] exponent = endianIO.Reader.ReadBytes(4);
            endianIO.Position = 16L;
            byte[] modulus = Program.Reverse8(endianIO.Reader.ReadBytes(256));
            RSAParameters parameters = default(RSAParameters);
            parameters.Exponent = exponent;
            parameters.Modulus = modulus;
            RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
            rsacryptoServiceProvider.ImportParameters(parameters);
            return rsacryptoServiceProvider;
        }

        private static RSACryptoServiceProvider LoadConsolePrivateKey(byte[] Exponent, byte[] KeyParams)
        {
            RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
            try
            {
                System.IO.EndianIO endianIO = new System.IO.EndianIO(KeyParams, EndianStyle.BigEndian);
                byte[] modulus = Program.Reverse8(endianIO.Reader.ReadBytes(128));
                byte[] p = Program.Reverse8(endianIO.Reader.ReadBytes(64));
                byte[] q = Program.Reverse8(endianIO.Reader.ReadBytes(64));
                byte[] dp = Program.Reverse8(endianIO.Reader.ReadBytes(64));
                byte[] dq = Program.Reverse8(endianIO.Reader.ReadBytes(64));
                byte[] inverseQ = Program.Reverse8(endianIO.Reader.ReadBytes(64));
                RSAParameters parameters = default(RSAParameters);
                parameters.Exponent = Exponent;
                parameters.Modulus = modulus;
                parameters.P = p;
                parameters.Q = q;
                parameters.DP = dp;
                parameters.DQ = dq;
                parameters.InverseQ = inverseQ;
                parameters.D = new byte[128];
                new Random(Environment.TickCount).NextBytes(parameters.D);
                rsacryptoServiceProvider.ImportParameters(parameters);
            }
            catch (Exception arg)
            {
                MessageBox.Show("Sorry, an invalid .bin file was found in the file list\nPlease remove the file and restart the application\n\n" + arg, "Invalid Keyvault File");
            }
            return rsacryptoServiceProvider;
        }

        private static byte[] GetXmacsLogonKey(string fileName)
        {
            string str = AppDomain.CurrentDomain.BaseDirectory + "\\files\\";
            RSACryptoServiceProvider rsacryptoServiceProvider = Program.LoadXmacsKey();
            byte[] array = new byte[16];
            new Random(Environment.TickCount).NextBytes(array);
            byte[] array2 = rsacryptoServiceProvider.Encrypt(array, true);
            Array.Reverse(array2);
            byte[] array3 = File.ReadAllBytes(str + "XMACSREQ.bin");
            Array.Copy(array2, 0, array3, 44, 256);
            System.IO.EndianIO endianIO = new System.IO.EndianIO(fileName, EndianStyle.BigEndian);
            endianIO.Position = 176L;
            byte[] array4 = endianIO.Reader.ReadBytes(12);
            endianIO.Position = 2504L;
            byte[] sourceArray = endianIO.Reader.ReadBytes(424);
            endianIO.Position = 668L;
            byte[] exponent = endianIO.Reader.ReadBytes(4);
            endianIO.Position = 680L;
            byte[] keyParams = endianIO.Reader.ReadBytes(448);
            endianIO.Position = 2506L;
            byte[] consoleId = endianIO.Reader.ReadBytes(5);
            endianIO.Close();
            byte[] sourceArray2 = Program.ComputeClientName(consoleId);
            RSACryptoServiceProvider key = Program.LoadConsolePrivateKey(exponent, keyParams);
            byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.ToFileTime());
            Array.Reverse(bytes);
            byte[] array5 = Program.GenerateTimeStamp();
            byte[] sourceArray3 = Program.RC4HMACEncrypt(array, 16, array5, array5.Length, 1);
            byte[] inputBuffer = SHA1.Create().ComputeHash(array);
            SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            sha1CryptoServiceProvider.TransformBlock(bytes, 0, 8, null, 0);
            byte[] array6 = new byte[16];
            try
            {
                sha1CryptoServiceProvider.TransformBlock(array4, 0, 12, null, 0);
                sha1CryptoServiceProvider.TransformFinalBlock(inputBuffer, 0, 20);
                byte[] hash = sha1CryptoServiceProvider.Hash;
                RSAPKCS1SignatureFormatter rsapkcs1SignatureFormatter = new RSAPKCS1SignatureFormatter(key);
                rsapkcs1SignatureFormatter.SetHashAlgorithm("SHA1");
                byte[] array7 = rsapkcs1SignatureFormatter.CreateSignature(hash);
                Array.Reverse(array7);
                Array.Copy(bytes, 0, array3, 300, 8);
                Array.Copy(array4, 0, array3, 308, 12);
                Array.Copy(array7, 0, array3, 320, 128);
                Array.Copy(sourceArray, 0, array3, 448, 424);
                Array.Copy(sourceArray3, 0, array3, 992, 52);
                Array.Copy(sourceArray2, 0, array3, 1072, 15);
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("XEAS.XBOXLIVE.COM", 88);
                udpClient.Send(array3, array3.Length);
                IPEndPoint ipendPoint = new IPEndPoint(0L, 0);
                int num = 0;
                for (; ; )
                {
                    Thread.Sleep(10);
                    if (udpClient.Available > 0)
                    {
                        break;
                    }
                    Thread.Sleep(500);
                    num++;
                    if (num == 10)
                    {
                        goto Block_4;
                    }
                }
                byte[] sourceArray4 = udpClient.Receive(ref ipendPoint);
                byte[] array8 = new byte[108];
                Array.Copy(sourceArray4, 53, array8, 0, 108);
                byte[] sourceArray5 = Program.RC4HMACDecrypt(Program.ComputeKdcNoonce(array, 16), 16, array8, 108, 1203);
                Array.Copy(sourceArray5, 76, array6, 0, 16);
                return array6;
            Block_4:
                return null;
            }
            catch
            {

            }
            return array6;
        }


        [STAThread]
        private static void Main()
        {
            // Set the style to use skin technology
            UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin;

            // Here we specify the skin to use by its name
            UserLookAndFeel.Default.SetSkinStyle("WXI Compact", "Darkness");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KeyvaultCheckerForm());
        }

        public void getStatus(string str2)
        {
            DateTime now = DateTime.Now;
            string str3 = AppDomain.CurrentDomain.BaseDirectory + "KVs\\";
            string str4 = AppDomain.CurrentDomain.BaseDirectory + "\\files\\";
            Directory.GetFiles(str3);
            Directory.GetDirectories(str3);
            if (!(str2 == str3 + "log.txt"))
            {
                byte[] xmacsLogonKey = Program.GetXmacsLogonKey(str2);
                if (xmacsLogonKey == null)
                {
                    this.textWriter.WriteLine("GetXmacsLogonKey timed out. Trying one more time...");
                    xmacsLogonKey = Program.GetXmacsLogonKey(str2);
                    if (xmacsLogonKey == null)
                    {
                        this.textWriter.WriteLine(str2 + ": skipped");
                        return;
                    }
                }
                System.IO.EndianIO endianIO = new System.IO.EndianIO(str2, EndianStyle.BigEndian);
                endianIO.Reader.BaseStream.Position = 2506L;
                byte[] consoleId = endianIO.Reader.ReadBytes(5);
                endianIO.Reader.BaseStream.Position = 2504L;
                byte[] sourceArray = SHA1.Create().ComputeHash(endianIO.Reader.ReadBytes(168));
                byte[] array = File.ReadAllBytes(str4 + "apreq1.bin");
                byte[] array2 = Program.ComputeClientName(consoleId);
                this.textWriter.WriteLine("Attempting logon for \"" + Encoding.ASCII.GetString(array2) + "\"...");
                this.textWriter.WriteLine("Creating Kerberos AS-REQ...");
                Array.Copy(array2, 0, array, 258, 24);
                Array.Copy(sourceArray, 0, array, 36, 20);
                byte[] array3 = Program.GenerateTimeStamp();
                Array.Copy(Program.RC4HMACEncrypt(xmacsLogonKey, 16, array3, array3.Length, 1), 0, array, 176, 52);
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("XEAS.XBOXLIVE.COM", 88);
                udpClient.Send(array, array.Length);
                this.textWriter.WriteLine("Sending Kerberos AS-REQ...");
                IPEndPoint ipendPoint = new IPEndPoint(0L, 0);
                byte[] array4;

                while (true)
                {
                    try
                    {
                        Thread.Sleep(10);
                        if (udpClient.Available > 0)
                        {
                            array4 = udpClient.Receive(ref ipendPoint);
                            break;
                        }
                        udpClient.Send(array, array.Length);
                    }
                    catch
                    {
                        continue;
                    }
                }

                udpClient.Close();
                this.textWriter.WriteLine("AS replied wanting pre-auth data...");
                this.textWriter.WriteLine("Creating new Kerberos AS-REQ...");
                byte[] array5 = new byte[16];
                Array.Copy(array4, array4.Length - 16, array5, 0, 16);
                byte[] array6 = File.ReadAllBytes(str4 + "apreq2.bin");
                Array.Copy(array2, 0, array6, 286, 24);
                Array.Copy(sourceArray, 0, array6, 36, 20);
                byte[] array7 = Program.GenerateTimeStamp();
                Array.Copy(Program.RC4HMACEncrypt(xmacsLogonKey, 16, array7, array7.Length, 1), 0, array6, 204, 52);
                Array.Copy(array5, 0, array6, 68, 16);
                UdpClient udpClient2 = new UdpClient();
                udpClient2.Connect("XEAS.XBOXLIVE.COM", 88);
                udpClient2.Send(array6, array6.Length);
                this.textWriter.WriteLine("Sending Kerberos AS-REQ...");
                byte[] array8;

                while (true)
                {
                    try
                    {
                        Thread.Sleep(10);
                        if (udpClient2.Available > 0)
                        {
                            array8 = udpClient2.Receive(ref ipendPoint);
                            break;
                        }
                        Thread.Sleep(50);
                        udpClient2.Send(array6, array6.Length);
                    }
                    catch
                    {
                        continue;
                    }
                }

                udpClient2.Close();
                File.WriteAllBytes(str4 + "APRESP.bin", array8);
                this.textWriter.WriteLine("Got AS-REP...");
                this.textWriter.WriteLine("Decrypting our session key...");
                this.textWriter.WriteLine("Creating Kerberos TGS-REQ...");
                byte[] array9 = new byte[210];
                Array.Copy(array8, array8.Length - 210, array9, 0, 210);
                byte[] array10 = Program.RC4HMACDecrypt(xmacsLogonKey, 16, array9, 210, 8);
                byte[] array11 = new byte[16];
                File.WriteAllBytes(str4 + "test.bin", array10);
                Array.Copy(array10, 27, array11, 0, 16);
                this.textWriter.WriteLine("Setting TGS ticket...");
                byte[] array12 = new byte[345];
                Array.Copy(array8, 168, array12, 0, 345);
                byte[] array13 = File.ReadAllBytes(str4 + "TGSREQ.bin");
                Array.Copy(array12, 0, array13, 437, 345);
                byte[] array14 = File.ReadAllBytes(str4 + "authenticator.bin");
                Array.Copy(array2, 0, array14, 40, 15);
                Encoding ascii = Encoding.ASCII;
                string s = DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmssZ");
                Array.Copy(ascii.GetBytes(s), 0, array14, 109, 15);
                Array.Copy(MD5.Create().ComputeHash(array13, 954, 75), 0, array14, 82, 16);
                Array.Copy(Program.RC4HMACEncrypt(array11, 16, array14, array14.Length, 7), 0, array13, 799, 153);
                byte[] key = Program.ComputeKdcNoonce(array11, 16);
                byte[] array15 = File.ReadAllBytes(str4 + "servicereq.bin");
                Array.Copy(Program.RC4HMACEncrypt(key, 16, array15, array15.Length, 1201), 0, array13, 55, 150);
                byte[] array16 = new byte[66];
                Array.Copy(array6, 116, array16, 0, 66);
                Array.Copy(Program.GetTitleAuthData(array11, 16, array16), 0, array13, 221, 82);
                this.textWriter.WriteLine("Sending our TGS-REQ...");
                UdpClient udpClient3 = new UdpClient();
                udpClient3.Connect("XETGS.XBOXLIVE.COM", 88);
                udpClient3.Send(array13, array13.Length);
                ipendPoint = new IPEndPoint(0L, 0);
                byte[] array17;

                while (true)
                {
                    try
                    {
                        Thread.Sleep(10);
                        if (udpClient3.Available > 0)
                        {
                            array17 = udpClient3.Receive(ref ipendPoint);
                            break;
                        }
                        Thread.Sleep(50);
                        this.textWriter.WriteLine("server timeout.. retrying...");
                        udpClient3.Send(array13, array13.Length);
                    }
                    catch
                    {
                        continue;
                    }
                }

                this.textWriter.WriteLine("Got TGS-REP...");
                File.WriteAllBytes(str4 + "tgsres.bin", array17);
                this.textWriter.WriteLine("Decrypting Logon status...");
                byte[] array18 = new byte[84];
                Array.Copy(array17, 50, array18, 0, 84);
                byte[] value = Program.RC4HMACDecrypt(key, 16, array18, 84, 1202);
                byte[] array19 = new byte[208];
                Array.Copy(array17, 58, array19, 0, 208);
                byte[] bytes = Program.RC4HMACDecrypt(key, 16, array19, 208, 1202);
                File.WriteAllBytes(str4 + "resp.bin", bytes);
                uint num = BitConverter.ToUInt32(value, 8);
                this.textWriter.WriteLine("Logon Status: " + num.ToString("X2"));
                if (num != 2148866317U)
                {
                    this.textWriter.WriteLine(str2 + " is Unbanned");
                    this.banned = false;
                    this.textWriter.Flush();
                    Thread.Sleep(500);
                }
                else
                {
                    this.textWriter.WriteLine(str2 + " is Banned");
                    this.banned = true;
                    this.textWriter.Flush();
                    Thread.Sleep(500);
                }
                this.textWriter.WriteLine("Took " + (DateTime.Now - now).Seconds + " second(s)");
            }
        }
        public bool returnStatus()
        {
            return this.banned;
        }
        private static byte[] ComputeClientName(byte[] ConsoleId)
        {
            byte[] result;
            try
            {
                long num = 0L;
                for (int i = 0; i < 5; i++)
                {
                    num = (num | (long)(ulong)ConsoleId[i]) << 8;
                }
                long num2 = num >> 8;
                int num3 = (int)num2 & 15;
                string text = string.Format("XE.{0}{1}@xbox.com", (num2 >> 4).ToString(), num3.ToString());
                if (text.Length != 24)
                {
                    int length = text.Length;
                    for (int j = 0; j < 24 - (text.Length - 1); j++)
                    {
                        text = text.Insert(3, "0");
                    }
                }
                result = Encoding.ASCII.GetBytes(text);
            }
            catch
            {
                result = ConsoleId;
            }
            return result;
        }

        private static byte[] GetTitleAuthData(byte[] Key, int keyLen, byte[] titleData)
        {
            byte[] sourceArray = new HMACSHA1(Program.ComputeKdcNoonce(Key, 16)).ComputeHash(titleData, 0, 66);
            byte[] array = new byte[82];
            Array.Copy(sourceArray, array, 16);
            Array.Copy(titleData, 0, array, 16, 66);
            return array;
        }

        private static byte[] ComputeKdcNoonce(byte[] Key, int keyLen)
        {
            byte[] buffer = new byte[]
            {
                115,
                105,
                103,
                110,
                97,
                116,
                117,
                114,
                101,
                107,
                101,
                121,
                0
            };
            byte[] key = new HMACMD5(Key).ComputeHash(buffer, 0, 13);
            byte[] inputBuffer = new byte[4];
            byte[] array = new byte[4];
            array[0] = 2;
            array[1] = 4;
            byte[] inputBuffer2 = array;
            MD5 md = new MD5CryptoServiceProvider();
            md.TransformBlock(inputBuffer2, 0, 4, null, 0);
            md.TransformFinalBlock(inputBuffer, 0, 4);
            byte[] hash = md.Hash;
            return new HMACMD5(key).ComputeHash(hash);
        }

        private static byte[] GenerateTimeStamp()
        {
            byte[] array = Misc.HexStringToBytes("301aa011180f32303132313231323139303533305aa10502030b3543");
            Encoding ascii = Encoding.ASCII;
            string s = DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmssZ");
            Array.Copy(ascii.GetBytes(s), 0, array, 6, 15);
            return array;
        }
        private static byte[] RC4HMACDecrypt(byte[] key, int keyLen, byte[] data, int dataLen, int Idk)
        {
            HMACMD5 hmacmd = new HMACMD5(key);
            byte[] bytes = BitConverter.GetBytes(Idk);
            byte[] key2 = hmacmd.ComputeHash(bytes, 0, 4);
            byte[] array = new byte[16];
            Array.Copy(data, array, 16);
            byte[] array2 = new byte[data.Length - 16];
            Array.Copy(data, 16, array2, 0, data.Length - 16);
            hmacmd.Key = key2;
            byte[] key3 = hmacmd.ComputeHash(array);
            Security.RC4(ref array2, key3);
            return array2;
        }
        private static byte[] RC4HMACEncrypt(byte[] key, int keyLen, byte[] data, int dataLen, int Idk)
        {
            HMACMD5 hmacmd = new HMACMD5(key);
            byte[] bytes = BitConverter.GetBytes(Idk);
            byte[] key2 = hmacmd.ComputeHash(bytes, 0, 4);
            byte[] sourceArray = Misc.HexStringToBytes("9b6bfacb5c488190");
            byte[] array = new byte[data.Length + 8];
            Array.Copy(sourceArray, array, 8);
            Array.Copy(data, 0, array, 8, data.Length);
            hmacmd.Key = key2;
            byte[] array2 = hmacmd.ComputeHash(array);
            byte[] key3 = hmacmd.ComputeHash(array2);
            Security.RC4(ref array, key3);
            byte[] array3 = new byte[dataLen + 24];
            Array.Copy(array2, 0, array3, 0, 16);
            Array.Copy(array, 0, array3, 16, array.Length);
            return array3;
        }

        private bool banned;

        private static string path = AppDomain.CurrentDomain.BaseDirectory + "KVs\\";

        public TextWriter textWriter = new StreamWriter(Program.path + "log.txt");


    }
}
