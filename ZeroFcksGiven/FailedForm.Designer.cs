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
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOK);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(48, 118);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 17);
            this.lblTimer.TabIndex = 3;
            // 
            // FailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnOk);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FailedForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FailedForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FailedForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblErrorID;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTimer;
    }
}