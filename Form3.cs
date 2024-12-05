using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Test
{
    public partial class Form3 : Form
    {
        private string username, firstName, email, phone, password, confirmPassword;
        private const string AccountSid = "AC6cdfb2ecd8dd829f7b3541bec3c8358a";
        private const string AuthToken = "44450da08f4b1680821a0122c26ef429";
        private const string TwilioPhoneNumber = "+17754599292";
        private string verificationCode;

        public static string AccountSid1 => AccountSid2;

        public static string AccountSid2 => AccountSid;

        public static string AuthToken1 => AuthToken;

        public Form3()
        {
            InitializeComponent();
            TwilioClient.Init(AccountSid, AuthToken);
        }

        private void UBox_TextChanged(object sender, EventArgs e)
        {
            username = UBox.Text.Trim();
        }

        private void FN_TextChanged(object sender, EventArgs e)
        {
            firstName = FN.Text.Trim();
        }

        private void MBox_TextChanged(object sender, EventArgs e)
        {
            email = MBox.Text.Trim();
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            phone = PhoneBox.Text.Trim();
        }

        private void PBox_TextChanged(object sender, EventArgs e)
        {
            password = PBox.Text;
        }

        private void CPBox_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = CPBox.Text;
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            // Regular expressions for validation
            Regex usernameRegex = new Regex(@"^[a-zA-Z0-9]{3,20}$");
            Regex nameRegex = new Regex(@"^[a-zA-Z\s-]{2,50}$");
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            // Updated phone number validation regex (country code + 10 digits)
            Regex phoneRegex = new Regex(@"^\+?\d{1,4}?\d{10}$"); // Country code + 10 digits

            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+]).{8,}$");

            // Validate the username
            if (string.IsNullOrWhiteSpace(username) || !usernameRegex.IsMatch(username))
            {
                MessageBox.Show("Invalid username. Must be 3-20 alphanumeric characters.", "Error");
                return;
            }

            // Validate the first name
            if (string.IsNullOrWhiteSpace(firstName) || !nameRegex.IsMatch(firstName))
            {
                MessageBox.Show("Invalid first name. Must be 2-50 letters, spaces, or hyphens.", "Error");
                return;
            }

            // Validate the email address
            if (string.IsNullOrWhiteSpace(email) || !emailRegex.IsMatch(email))
            {
                MessageBox.Show("Invalid email address.", "Error");
                return;
            }

            // Validate the phone number (12 digits including country code)
            if (string.IsNullOrWhiteSpace(phone) || !phoneRegex.IsMatch(phone))
            {
                MessageBox.Show("Invalid phone number. Must be 12 digits, including country code.", "Error");
                return;
            }

            // Validate the password
            if (string.IsNullOrWhiteSpace(password) || !passwordRegex.IsMatch(password))
            {
                MessageBox.Show("Invalid password. Must have 8+ chars, include uppercase, lowercase, number, and special character.", "Error");
                return;
            }

            // Check if the passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error");
                return;
            }

            // Send the verification SMS
            SendVerificationSMS(phone);
        }

        private void SendVerificationSMS(string toPhoneNumber)
        {
            verificationCode = GenerateVerificationCode();

            try
            {
                var message = MessageResource.Create(
                    body: $"Your verification code is: {verificationCode}",
                    from: new PhoneNumber(TwilioPhoneNumber),
                    to: new PhoneNumber(toPhoneNumber) // Using the phone number passed to this method
                );

                Form verificationForm = new Form
                {
                    Text = "Phone Verification",
                    Size = new System.Drawing.Size(300, 200)
                };

                Label instructionLabel = new Label
                {
                    Text = "Enter the 6-digit code sent to your phone:",
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(260, 30)
                };

                TextBox codeTextBox = new TextBox
                {
                    Location = new System.Drawing.Point(20, 60),
                    Size = new System.Drawing.Size(260, 30)
                };

                Button verifyButton = new Button
                {
                    Text = "Verify",
                    Location = new System.Drawing.Point(100, 100),
                    Size = new System.Drawing.Size(260, 30)
                };

                verifyButton.Click += (s, ev) =>
                {
                    if (codeTextBox.Text.Trim() == verificationCode)
                    {
                        MessageBox.Show("Phone number verified successfully!", "Success");
                        verificationForm.DialogResult = DialogResult.OK;
                        verificationForm.Close();
                        MessageBox.Show("Registration Successful!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid verification code.", "Error");
                    }
                };

                verificationForm.Controls.Add(instructionLabel);
                verificationForm.Controls.Add(codeTextBox);
                verificationForm.Controls.Add(verifyButton);

                verificationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send SMS: {ex.Message}", "Error");
            }
        }

        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
