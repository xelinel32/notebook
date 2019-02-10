namespace TellPhoneBook
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblhelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.Location = new System.Drawing.Point(32, 66);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(326, 104);
            this.lblhelp.TabIndex = 0;
            this.lblhelp.Text = resources.GetString("lblhelp.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 247);
            this.Controls.Add(this.lblhelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 285);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhelp;
    }
}