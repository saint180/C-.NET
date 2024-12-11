using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Test
{
    public partial class Form4 : Form
    {
        private DateTime loginTime;
        private List<DateTime> loginTimes = new List<DateTime>();

        private DateTime lastLoginTime;
        private List<DateTime> dateTimes = new List<DateTime>();

        private static TimeSpan totalusagetime = TimeSpan.Zero;

        private const string usagefile = "usage.txt";

        bool sidebarExpand;

        public Form4(DateTime currentTime)
        {
            InitializeComponent();
            this.loginTime = currentTime;
            loginTimes.Add(loginTime);

            if (File.Exists(usagefile))
            {
                string savedTime = File.ReadAllText(usagefile);
                if (TimeSpan.TryParse(savedTime, out TimeSpan loadedTime))
                {
                    totalusagetime = loadedTime;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.lastLoginTime = DateTime.Now;
            dateTimes.Add(lastLoginTime);
            TimeSpan sessionDuration = lastLoginTime - loginTime;

            totalusagetime += sessionDuration;

            File.WriteAllText(usagefile, totalusagetime.ToString());

            MessageBox.Show("Total useage time for this session :" + sessionDuration + "Total app useage time: " + totalusagetime);

            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new Home());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadForm(new Inbox());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new Explore());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new Notification());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new Settings());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new Account());
        }
    }
}
