namespace ZeroFcksGiven
{
    partial class FailedForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrFailedForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFailed.Location = new System.Drawing.Point(26, 53);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(332, 29);
            this.lblFailed.TabIndex = 0;
            this.lblFailed.Text = "FAILED! FUCK NOT GIVEN!";
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblErrorID.Location = new System.Drawing.Point(130, 112);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(124, 20);
            this.lblErrorID.TabIndex = 1;
            this.lblErrorID.Text = "ID:10T ERROR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tmrFailedForm
            // 
            this.tmrFailedForm.Enabled = true;
            this.tmrFailedForm.Interval = 1000;
            this.tmrFailedForm.Tick += new System.EventHandler(this.tmrFailedForm_Tick);
            // 
            // FailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErrorID);
            this.Controls.Add(this.lblFailed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAILED";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FailedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblErrorID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrFailedForm;
    }
}