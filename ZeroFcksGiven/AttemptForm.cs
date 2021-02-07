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
    public partial class AttemptForm : Form
    {
        public AttemptForm()
        {
            InitializeComponent();
        }
        
        private void AttemptForm_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Progress bar that self-closes the form after a set amount of time
        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            //For every second increase the progress bar value by 1
            {
                progressBar1.Value++;
                //lblAtt.Text = progressBar1.Value.ToString();
            }

            // When progress bar value reaches set limit close the form
            if (progressBar1.Value == 82)
            {
                this.Hide();
                Form failedForm = new FailedForm();
                failedForm.Show();
                this.Close();
            }
            


        }

        private void AttemptForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void AttemptForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        public Point mouseLocation;

        private void AttemptForm_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
