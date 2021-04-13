
namespace AgAccoutingSystem
{
    partial class ViewSubmissions
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
            this.ConfirmBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmBttn
            // 
            this.ConfirmBttn.Location = new System.Drawing.Point(276, 373);
            this.ConfirmBttn.Name = "ConfirmBttn";
            this.ConfirmBttn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBttn.TabIndex = 0;
            this.ConfirmBttn.Text = "Confirm";
            this.ConfirmBttn.UseVisualStyleBackColor = true;
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(416, 373);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(75, 23);
            this.ExitBttn.TabIndex = 1;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            // 
            // ViewSubmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ConfirmBttn);
            this.Name = "ViewSubmissions";
            this.Text = "ViewSubmissions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBttn;
        private System.Windows.Forms.Button ExitBttn;
    }
}