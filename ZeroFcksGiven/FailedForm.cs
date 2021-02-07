using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroFcksGiven
{


    public partial class FailedForm : Form
    {

        public FailedForm()
        {
            InitializeComponent();
        }
        private Timer timer = new Timer();
        private int elapsedTime;
        private void FailedForm_Load(object sender, EventArgs e)
        {

            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            {
                //lblTimer.Text = elapsedTime.ToString();
            }

            if (elapsedTime == 5)
            {
                this.Hide();
                Program.ShowAttForm();                
                this.Close();
            }
            
        }

        private void FailedForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void BtnOK(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FailedForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        public Point mouseLocation;
        private void FailedForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;

        }
    
    }
}
