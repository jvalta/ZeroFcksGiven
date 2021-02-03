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
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //Progress bar that self-closes the form after a set amount of time
        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            //For every second increase the progress bar value by 1
            {
                progressBar1.Value++;
            }

            // When progress bar value reaches set limit close the form
            if (progressBar1.Value == 12)
            {
                this.Hide();

                Form failedForm = new FailedForm();
                failedForm.Show();
                this.Close();
            }
            //return;


        }
        
    }
}
