using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Test
{
    public partial class Form2 : Form
    {
        private string username;
        private string password;

        public Form2()
        {
            InitializeComponent();
        }

        private void UBox_TextChanged(object sender, EventArgs e)
        {
            username = UBox.Text.Trim();
        }

        private void PBox_TextChanged(object sender, EventArgs e)
        {
            password = PBox.Text;
        }

        private void RM_CheckedChanged(object sender, EventArgs e)
        {
            PBox.UseSystemPasswordChar = !RM.Checked;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Regex usernameRegex = new Regex(@"^[a-zA-Z0-9]{3,20}$");

            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+]).{8,}$");

            if (string.IsNullOrWhiteSpace(username) || !usernameRegex.IsMatch(username))
            {
                MessageBox.Show("Invalid username. Must be 3-20 alphanumeric characters.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || !passwordRegex.IsMatch(password))
            {
                MessageBox.Show("Invalid password. Must have 8+ chars, include uppercase, lowercase, number, and special character.", "Error");
                return;
            }

            if (username == "admin" && password == "Password123!")
            {
                MessageBox.Show("Login Successful!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new System.Drawing.Bitmap("C:\\Users\\Sachin\\source\\repos\\Test\\Test\\Resources\\B.gif");

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Fill;

            this.Controls.Add(pictureBox);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

            groupBox.Left = (this.ClientSize.Width - groupBox.Width) / 2;
            groupBox.Top = (this.ClientSize.Height - groupBox.Height) / 2;
        }
    }
}