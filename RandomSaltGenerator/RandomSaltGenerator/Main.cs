using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace RandomSaltGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // Bind combobox to dictionary
            Dictionary<int, int> saltLengthChoices = new Dictionary<int, int>
            {
                { 1, 32 },
                { 2, 64 },
                { 3, 128 },
                { 4, 512 }
            };
            saltLengthComboBox.DataSource = new BindingSource(saltLengthChoices, null);
            saltLengthComboBox.DisplayMember = "Value";
            saltLengthComboBox.ValueMember = "Key";
        }

        private void generateSaltButton_Click(object sender, EventArgs e)
        {
            // First, try find hash algroithm value from combo box dictionary
            int selectedSaltLengthIndex = Convert.ToInt32(saltLengthComboBox.SelectedValue);
            if (selectedSaltLengthIndex >= 1 && selectedSaltLengthIndex <= 4)
            {
                using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
                {
                    // Clear the salt output text box
                    saltTextBox.Clear();

                    // Get the requested salt length
                    int saltLength = ((KeyValuePair<int, int>)saltLengthComboBox.SelectedItem).Value;
                    
                    // Initialize a new byte and populate using the RNG
                    byte[] saltData = new byte[saltLength];
                    rng.GetBytes(saltData);
                    // Convert the bytes to a base64 encoded string
                    string salt = Convert.ToBase64String(saltData);
                    saltTextBox.Text += salt;
                }
            }
            else
            {
                // Show error dialog for incorrent salt length selection
                string message = "Please select a valid salt length from the list...";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }
    }
}
