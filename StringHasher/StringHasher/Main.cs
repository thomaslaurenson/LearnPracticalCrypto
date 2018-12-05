using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace StringHasher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // Bind combobox to dictionary
            Dictionary<int, string> hashAlgorithmChoices = new Dictionary<int, string>
            {
                { 1, "MD5" },
                { 2, "SHA-1" },
                { 3, "SHA-256" },
                { 4, "SHA-512" }
            };
            hashAlgorithmSelection.DataSource = new BindingSource(hashAlgorithmChoices, null);
            hashAlgorithmSelection.DisplayMember = "Value";
            hashAlgorithmSelection.ValueMember = "Key";
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return ConvertBytesToString(hashBytes);
            }
        }

        public static string CreateSHA1(string input)
        {
            // Use input string to calculate SHA1 hash
            using (System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return ConvertBytesToString(hashBytes);
            }
        }

        public static string CreateSHA256(string input)
        {
            // Use input string to calculate SHA256 hash
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return ConvertBytesToString(hashBytes);
            }
        }

        public static string CreateSHA512(string input)
        {
            // Use input string to calculate sha512 hash
            using (System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                return ConvertBytesToString(hashBytes);
            }
        }

        public static string ConvertBytesToString(byte[] hashBytes)
        {
            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void generateHashButton_Click(object sender, EventArgs e)
        {
            // First, try find hash algroithm value from combo box dictionary
            int selectedAlgorithmIndex = Convert.ToInt32(hashAlgorithmSelection.SelectedValue);
            if (selectedAlgorithmIndex >= 1 && selectedAlgorithmIndex <= 4)
            {
                // Check the user eneter something in the string/password box
                if (string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    // Show error dialog for empty string password box
                    string message = "Please enter a string/password...";
                    string title = "ERROR";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string hashValue = String.Empty;
                    string password = passwordBox.Text;
                    string hashAlgorithm = ((KeyValuePair<int, string>)hashAlgorithmSelection.SelectedItem).Value;
                    if (hashAlgorithm == "MD5")
                    {
                        hashValue = CreateMD5(password);
                    }
                    else if (hashAlgorithm == "SHA-1")
                    {
                        hashValue = CreateSHA1(password);
                    }
                    else if (hashAlgorithm == "SHA-256")
                    {
                        hashValue = CreateSHA256(password);
                    }
                    else if (hashAlgorithm == "SHA-512")
                    {
                        hashValue = CreateSHA512(password);
                    }
                    hashedPasswordBox.Text = hashValue;
                }
            }
            else
            {
                // Show error dialog for incorrent hashing algorithm selection
                string message = "Please select a valid hashing algoritm...";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }
    }
}
