using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ricardoNewYearAlarm
{
    public partial class NewYearAlarm : Form
    {
        public NewYearAlarm()
        {
            InitializeComponent();
        }
        String currentYear;
        String starterYear;
        int current;
        int starter;
        int elapsedSeconds = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            currentYear = DateTime.Now.ToString("yyyy");
            currentLbl.Text = currentYear;
            starterLbl.Text = currentYear;
          
            secondsLbl.Text = "0";
        }
        private Timer timer1;
        private void initTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; 
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            secondsLbl.Text = Convert.ToString(elapsedSeconds);
            //Check if new year

            currentYear = DateTime.Now.ToString("yyyy");
            currentLbl.Text = currentYear;
            current = Convert.ToInt32(currentYear);
         
            
            if (current > starter)
            {

                System.Diagnostics.Process.Start("https://youtu.be/dvxVQp2-qCk?t=33");
                timer1.Stop();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            starterYear = DateTime.Now.ToString("yyyy");
            starterLbl.Text = starterYear;
            starter = Convert.ToInt32(starterYear);
            
            initTimer();

         

        }

        private void currentLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
