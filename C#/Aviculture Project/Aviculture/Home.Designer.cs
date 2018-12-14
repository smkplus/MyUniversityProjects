namespace Aviculture
{
    partial class Home
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
            this.EmployerPage = new System.Windows.Forms.Button();
            this.Aviculture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployerPage
            // 
            this.EmployerPage.Location = new System.Drawing.Point(279, 263);
            this.EmployerPage.Name = "EmployerPage";
            this.EmployerPage.Size = new System.Drawing.Size(138, 34);
            this.EmployerPage.TabIndex = 11;
            this.EmployerPage.Text = "بخش کارمندان";
            this.EmployerPage.UseVisualStyleBackColor = true;
            this.EmployerPage.Click += new System.EventHandler(this.EmployerPage_Click);
            // 
            // Aviculture
            // 
            this.Aviculture.Location = new System.Drawing.Point(279, 202);
            this.Aviculture.Name = "Aviculture";
            this.Aviculture.Size = new System.Drawing.Size(138, 34);
            this.Aviculture.TabIndex = 12;
            this.Aviculture.Text = "بخش مرغداری";
            this.Aviculture.UseVisualStyleBackColor = true;
            this.Aviculture.Click += new System.EventHandler(this.Aviculture_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.Aviculture);
            this.Controls.Add(this.EmployerPage);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EmployerPage;
        private System.Windows.Forms.Button Aviculture;
    }
}

