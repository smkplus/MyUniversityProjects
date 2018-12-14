namespace Aviculture
{
    partial class AviculturePage
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
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.AddHen = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(234, 291);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(85, 32);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "ویرایش";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(418, 291);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(87, 32);
            this.Remove.TabIndex = 17;
            this.Remove.Text = "حذف";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddHen
            // 
            this.AddHen.Location = new System.Drawing.Point(325, 291);
            this.AddHen.Name = "AddHen";
            this.AddHen.Size = new System.Drawing.Size(87, 32);
            this.AddHen.TabIndex = 16;
            this.AddHen.Text = "اضافه کردن";
            this.AddHen.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(313, 224);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(171, 22);
            this.ID.TabIndex = 15;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(313, 185);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(171, 22);
            this.Type.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "شناسه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "نوع";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(256, 144);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(23, 17);
            this.Agelabel.TabIndex = 11;
            this.Agelabel.Text = "سن";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(313, 144);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(171, 22);
            this.Age.TabIndex = 10;
            // 
            // Aviculture
            // 
            this.ClientSize = new System.Drawing.Size(738, 466);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.AddHen);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.Age);
            this.Name = "Aviculture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button AddHen;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.TextBox Age;
    }
}
