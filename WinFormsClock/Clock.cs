using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("d");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss"); //argentina


            DateTime date1 = DateTime.UtcNow;

            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");

            DateTime date2 = TimeZoneInfo.ConvertTime(date1, tz);

            //this.label2.Text = DateTime.Now.ToString("HH:mm:ss"); //mexico

            this.label2.Text = date2.ToString("HH:mm:ss");
            //TimeZoneInfo TZI = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
