namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

            groupBox.Left = (this.ClientSize.Width - groupBox.Width) / 2;
            groupBox.Top = (this.ClientSize.Height - groupBox.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
