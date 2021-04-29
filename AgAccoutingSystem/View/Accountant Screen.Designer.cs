
namespace AgAccoutingSystem
{
    partial class Accountant_Screen
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
            this.ExitBttn = new System.Windows.Forms.Button();
            this.ViewSubBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(387, 415);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(128, 23);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // ViewSubBttn
            // 
            this.ViewSubBttn.Location = new System.Drawing.Point(253, 415);
            this.ViewSubBttn.Name = "ViewSubBttn";
            this.ViewSubBttn.Size = new System.Drawing.Size(128, 23);
            this.ViewSubBttn.TabIndex = 1;
            this.ViewSubBttn.Text = "View Submissions";
            this.ViewSubBttn.UseVisualStyleBackColor = true;
            this.ViewSubBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accountant_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewSubBttn);
            this.Controls.Add(this.ExitBttn);
            this.Name = "Accountant_Screen";
            this.Text = "Accountant";
            this.Load += new System.EventHandler(this.Accountant_Screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button ViewSubBttn;
    }
}