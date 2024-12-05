namespace Test
{
    partial class Form3
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
            PhoneBox = new TextBox();
            MBox = new TextBox();
            CPBox = new TextBox();
            FN = new TextBox();
            Signin = new Button();
            PBox = new TextBox();
            UBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(PhoneBox);
            groupBox1.Controls.Add(MBox);
            groupBox1.Controls.Add(CPBox);
            groupBox1.Controls.Add(FN);
            groupBox1.Controls.Add(Signin);
            groupBox1.Controls.Add(PBox);
            groupBox1.Controls.Add(UBox);
            groupBox1.Location = new Point(386, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 538);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Signin";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(138, 249);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(265, 31);
            PhoneBox.TabIndex = 7;
            PhoneBox.Text = "Phone No";
            PhoneBox.TextChanged += PhoneBox_TextChanged;
            // 
            // MBox
            // 
            MBox.Location = new Point(138, 187);
            MBox.Name = "MBox";
            MBox.Size = new Size(265, 31);
            MBox.TabIndex = 6;
            MBox.Text = "Mail";
            MBox.TextChanged += MBox_TextChanged;
            // 
            // CPBox
            // 
            CPBox.Location = new Point(138, 369);
            CPBox.Name = "CPBox";
            CPBox.Size = new Size(265, 31);
            CPBox.TabIndex = 5;
            CPBox.Text = "Confirm Password";
            CPBox.TextChanged += CPBox_TextChanged;
            // 
            // FN
            // 
            FN.Location = new Point(138, 127);
            FN.Name = "FN";
            FN.Size = new Size(265, 31);
            FN.TabIndex = 4;
            FN.Text = "Name";
            FN.TextChanged += FN_TextChanged;
            // 
            // Signin
            // 
            Signin.Location = new Point(194, 447);
            Signin.Name = "Signin";
            Signin.Size = new Size(112, 34);
            Signin.TabIndex = 3;
            Signin.Text = "Signin";
            Signin.UseVisualStyleBackColor = true;
            Signin.Click += Signin_Click;
            // 
            // PBox
            // 
            PBox.Location = new Point(138, 311);
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.B;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1392, 888);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox PhoneBox;
        private TextBox MBox;
        private TextBox CPBox;
        private TextBox FN;
        private Button Signin;
        private TextBox PBox;
        private TextBox UBox;
    }
}