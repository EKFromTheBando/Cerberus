using Microsoft.Test.Xbox.XDRPC;
using System;
using System.Runtime.InteropServices;
using XDevkit;

namespace Cerberus.Cerberus.Helpers
{
    internal static class XboxHelpers
    {

        public static void HalSendSMCMessage(XboxConsole Console, byte[] Request, ref byte[] Response)
        {
            if (Request.Length != 16) throw new Exception("XDKUtils.HalSendSMCMessage: Invalid request specified. It must be 16 bytes in length.");
            if (!Enum.IsDefined(typeof(SMCCommands), Request[0])) throw new Exception("XDKUtils.HalSendSMCMessage: Invalid request specified. The first byte needs to be a valid request value.");
            var request = new XDRPCArrayArgumentInfo<byte[]>(Request);
            var response = Response == null ? (XDRPCArgumentInfo)new XDRPCNullArgumentInfo() : new XDRPCArrayArgumentInfo<byte[]>(Response, ArgumentType.ByRef);
            Console.ExecuteRPC<uint>(XDRPCMode.Title, "xboxkrnl.exe", 41, request, response);
            if (!(response is XDRPCNullArgumentInfo)) Response = ((XDRPCArrayArgumentInfo<byte[]>)response).Value;
        }

        public enum SMCCommands : byte
        {
            SMC_POWERON_TYPE = 0x1,
            SMC_QUERY_RTC = 0x4,
            SMC_QUERY_SENSOR = 0x7,
            SMC_QUERY_TRAY = 0xA,
            SMC_QUERY_AVPACK = 0xF,
            SMC_I2C_READ_WRITE = 0x11,
            SMC_QUERY_VERSION = 0x12,
            SMC_FIFO_TEST = 0x13,
            SMC_QUERY_IR_ADDRESS = 0x16,
            SMC_QUERY_TILT_SENSOR = 0x17,
            SMC_READ_82_INTERRUPTS = 0x1E,
            SMC_READ_8E_INTERRUPTS = 0x20,
            SMC_SET_STANDBY = 0x82,
            SMC_SET_TIME = 0x85,
            SMC_SET_FAN_ALGORITHM = 0x88,
            SMC_SET_FAN_SPEED_CPU = 0x89,
            SMC_SET_DVD_TRAY = 0x8B,
            SMC_SET_POWER_LED = 0x8C,
            SMC_SET_AUDIO_MUTE = 0x8D,
            SMC_ARGON_RELATED = 0x90,
            SMC_SET_FAN_SPEED_GPU = 0x94, //Not present on slim, not used/respected on newer phat.
            SMC_SET_IR_ADDRESS = 0x95,
            SMC_SET_DVD_TRAY_SECURE = 0x98,
            SMC_SET_LEDS = 0x99,
            SMC_SET_RTC_WAKE = 0x9A,
            SMC_ANA_RELATED = 0x9B,
            SMC_SET_ASYNC_OPERATION = 0x9C,
            SMC_SET_82_INTERRUPTS = 0x9D,
            SMC_SET_9F_INTERRUPTS = 0x9F
        }

        public static string CreateExceptionMessage(Exception EX, XboxManager Manager)
        {
            if (EX == null || Manager == null) return "(Error in XDKUtils.CreateExceptionMessage)";
            if (!(EX is COMException)) return EX.Message;
            try { return Manager.TranslateError(((COMException)EX).ErrorCode); }
            catch (Exception) { return EX.Message; }
        }

        public enum SMCTemperatureIndices : byte
        {
            CPU = 0,
            GPU = 1,
            RAM = 2,
            BOARD = 3
        }
    }
}
