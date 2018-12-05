using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordHashing
{
    public partial class PasswordHashingForm : Form
    {
        public PasswordHashingForm()
        {
            InitializeComponent();
        }

        private void PasswordHashingForm_Load(object sender, EventArgs e)
        {
            // Simulate login button click for Enter key
            AcceptButton = buttonLogin;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password entered by the user
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Call the ValidatePassword function to check user supplied credentials
            bool validUser = ValidateCredentials(username, password);

            if (validUser)
            {
                // If username/password correct, display dialog box
                string message = "Access Granted!";
                string title = "SUCCESS";
                MessageBox.Show(message, title);
            }
            else
            {
                // If username/password incorrect, display dialog box
                string message = "Access Denied!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }

        bool ValidateCredentials(string username, string password)
        {
            // Debugging help: Print the supplied credentials to the output pane.
            Debug.WriteLine(">>>>>> Supplied credentials: {0}, {1}", username, password);

            // Specify the text password file (must be in same dir as exe)
            string credentialsFile = @"credentials.txt";

            if (File.Exists(credentialsFile))
            {
                // Read in each line of the credentials.txt file
                foreach (string line in File.ReadAllLines(credentialsFile))
                {
                    // Split each line on the semicolon (':') character 
                    var credentials = line.Split(':');
                    string existingUsername = credentials[0];
                    string existingSalt = credentials[1];
                    string existingHashedPassword = credentials[2];

                    // Debugging help: Print each of the existing credentials to the output pane.
                    Debug.WriteLine(">>> Checking existing user: " + existingUsername);
                    Debug.WriteLine("  > Existing hash value:  " + existingHashedPassword);
                    Debug.WriteLine("  > Existing salt value:  " + existingSalt);

                    // Up to here, the password (supplied by the user) is still in plaintext! We need to:
                    // 1. Concatenate the password + salt
                    // 2. Call the hashing function with the concatenated string
                    string saltedPassword = CalculateMD5Hash(password + existingSalt);
                    Debug.WriteLine("  > Provided salted hash: " + saltedPassword);

                    // TASK:
                    // Change the default hashing algorithm to SHA-512
                    // Use the line above (line # 68) as an example... that line uses the MD5 algorithm
                    // There is already a function available called: CalculateSHA512Hash

                    // Simple string comparison for password check.
                    if (username == existingUsername  && saltedPassword.ToUpper() == existingHashedPassword.ToUpper())
                    {
                        // Debugging help: Print username/password match.
                        Debug.WriteLine("  > Success! Username/password credentials match!");
                        return true;
                    }
                    else
                    {
                        // Debugging help: Print username/password don't match.
                        Debug.WriteLine("  > Error! Username/password credentials DO NOT match!");
                    }
                }
            }
            else
            {
                // If no credentials file found, display dialog box
                string message = "Cannot find password file.";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }

            // Default is to return false if no username/password was validated
            return false;
        }

        string CalculateMD5Hash(string password)
        {
            // Initialize a new instance of SHA256 (hasher)
            MD5 hasher = MD5.Create();
            
            // Calculate the SHA256 hash value (using bytes object)
            byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(password));
            
            // Covert the bytes to a string
            string hashedPassword = BitConverter.ToString(bytes).Replace("-", "");
            
            // Finally, return the hashed password
            return hashedPassword;
        }

        string CalculateSHA512Hash(string password)
        {
            // Initialize a new instance of SHA256 (hasher)
            SHA512 hasher = SHA512.Create();

            // Calculate the SHA256 hash value (using bytes object)
            byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Covert the bytes to a string
            string hashedPassword = BitConverter.ToString(bytes).Replace("-", "");

            // Finally, return the hashed password
            return hashedPassword;
        }
    }
}
