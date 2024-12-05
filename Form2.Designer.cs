namespace Test
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Login = new Button();
            RM = new CheckBox();
            PBox = new TextBox();
            UBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(Login);
            groupBox1.Controls.Add(RM);
            groupBox1.Controls.Add(PBox);
            groupBox1.Controls.Add(UBox);
            groupBox1.Location = new Point(400, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Login
            // 
            Login.Location = new Point(212, 242);
            Login.Name = "Login";
            Login.Size = new Size(112, 34);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // RM
            // 
            RM.AutoSize = true;
            RM.Location = new Point(138, 174);
            RM.Name = "RM";
            RM.Size = new Size(154, 29);
            RM.TabIndex = 2;
            RM.Text = "Remember me";
            RM.UseVisualStyleBackColor = true;
            RM.CheckedChanged += RM_CheckedChanged;
            // 
            // PBox
            // 
            PBox.Location = new Point(138, 121);
            PBox.Name = "PBox";
            PBox.Size = new Size(265, 31);
            PBox.TabIndex = 1;
            PBox.Text = "Password";
            PBox.TextChanged += PBox_TextChanged;
            // 
            // UBox
            // 
            UBox.Location = new Point(138, 61);
            UBox.Name = "UBox";
            UBox.Size = new Size(265, 31);
            UBox.TabIndex = 0;
            UBox.Text = "Username";
            UBox.TextChanged += UBox_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.B;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 598);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Login;
        private CheckBox RM;
        private TextBox PBox;
        private TextBox UBox;
    }
}