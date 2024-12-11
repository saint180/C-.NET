namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login = new Button();
            Signup = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login.BackColor = Color.LightCoral;
            Login.FlatStyle = FlatStyle.Flat;
            Login.ForeColor = SystemColors.ControlLightLight;
            Login.Location = new Point(94, 108);
            Login.Name = "Login";
            Login.Size = new Size(115, 122);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Signup
            // 
            Signup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Signup.BackColor = Color.LightCoral;
            Signup.FlatStyle = FlatStyle.Flat;
            Signup.ForeColor = SystemColors.ControlLightLight;
            Signup.Location = new Point(261, 108);
            Signup.Name = "Signup";
            Signup.Size = new Size(115, 122);
            Signup.TabIndex = 1;
            Signup.Text = "Signup";
            Signup.UseVisualStyleBackColor = false;
            Signup.Click += Signup_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(Signup);
            groupBox1.Controls.Add(Login);
            groupBox1.Location = new Point(361, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 282);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome to HUP";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.close;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1106, 12);
            button1.Name = "button1";
            button1.Size = new Size(55, 48);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1173, 597);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Login;
        private Button Signup;
        private GroupBox groupBox1;
        private Button button1;
    }
}
