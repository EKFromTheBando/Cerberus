using DevExpress.XtraEditors;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Management;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerberus.Cerberus
{
    public partial class UserRegstrationForm : XtraForm
    {
        private readonly string connectionString;

        public UserRegstrationForm()
        {
            InitializeComponent();

            var connectionStringSettings = ConfigurationManager.ConnectionStrings["UserInfoDb"];
            if (connectionStringSettings == null)
            {
                XtraMessageBox.Show("Connection string 'UserInfoDb' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Handle the error or exit
                return;
            }

            connectionString = connectionStringSettings.ConnectionString;
        }

        private void UserRegstrationForm_Load(object sender, EventArgs e)
        {
        }

        private void ButtonRegisterUser_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                return Convert.ToBase64String(hashBytes);
            }
        }



        private string GetMachineHWID()
        {
            string hwid = string.Empty;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                foreach (ManagementObject disk in searcher.Get())
                {
                    // Get the Hardware ID of the first disk drive found
                    hwid = disk["PNPDeviceID"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving HWID: " + ex.Message);
            }

            return hwid;
        }

        private async Task<string> GetPublicIPAddressAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync("https://api.ipify.org?format=text");
                    return response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving IP address:" + ex.Message);
                    return null;
                }
            }
        }

        private async void RegisterUser()
        {
            string username = TextEditUsername.Text;
            string password = TextEditPassword.Text;
            string confirmPassword = TextEditConfirmPassword.Text;
            string hwid = GetMachineHWID();
            string ip = await GetPublicIPAddressAsync();

            if (password != confirmPassword)
            {
                XtraMessageBox.Show("Passwords do not match", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ip == null)
            {
                XtraMessageBox.Show("Failed to retrieve IP address. Registration cannot proceed.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string passwordHash = HashPassword(password); // Pass salt here

            // Truncate HWID to fit column size if necessary
            string truncatedHwid = TruncateString(hwid, 255); // Assuming HWID column is NVARCHAR(255)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if HWID already exists
                string hwidQuery = "SELECT COUNT(*) FROM UserInfo WHERE HWID = @HWID";
                using (SqlCommand hwidCommand = new SqlCommand(hwidQuery, connection))
                {
                    hwidCommand.Parameters.AddWithValue("@HWID", truncatedHwid);
                    int hwidCount = (int)hwidCommand.ExecuteScalar();

                    if (hwidCount > 0)
                    {
                        XtraMessageBox.Show("An account is already registered on this machine.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Register the new user and insert HWID
                string userQuery = "INSERT INTO UserInfo (Username, PasswordHash, IP, HWID, IsUserBanned) VALUES (@Username, @PasswordHash, @IP, @HWID, @IsUserBanned)";

                using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                {
                    userCommand.Parameters.AddWithValue("@Username", username);
                    userCommand.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    userCommand.Parameters.AddWithValue("@IP", ip);
                    userCommand.Parameters.AddWithValue("@HWID", truncatedHwid);
                    userCommand.Parameters.AddWithValue("@IsUserBanned", 0); // Set default value to false

                    try
                    {
                        userCommand.ExecuteNonQuery();
                        XtraMessageBox.Show("User registration successful, you can now return to the login page.", "Cerberus AIO");
                    }
                    catch (SqlException ex)
                    {
                        XtraMessageBox.Show($"An error occurred: {ex.Message}", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Method to truncate strings if they exceed a maximum length
        private string TruncateString(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }
            return value;
        }


    }
}
