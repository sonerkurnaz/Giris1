namespace SystemIOWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDriver = new System.Windows.Forms.ListBox();
            this.lstKlasörler = new System.Windows.Forms.ListBox();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDriver
            // 
            this.lstDriver.FormattingEnabled = true;
            this.lstDriver.ItemHeight = 15;
            this.lstDriver.Location = new System.Drawing.Point(12, 12);
            this.lstDriver.Name = "lstDriver";
            this.lstDriver.Size = new System.Drawing.Size(205, 64);
            this.lstDriver.TabIndex = 0;
            this.lstDriver.SelectedIndexChanged += new System.EventHandler(this.lstDriver_SelectedIndexChanged);
            // 
            // lstKlasörler
            // 
            this.lstKlasörler.FormattingEnabled = true;
            this.lstKlasörler.ItemHeight = 15;
            this.lstKlasörler.Location = new System.Drawing.Point(12, 82);
            this.lstKlasörler.Name = "lstKlasörler";
            this.lstKlasörler.Size = new System.Drawing.Size(205, 334);
            this.lstKlasörler.TabIndex = 1;
            this.lstKlasörler.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 15;
            this.lstDosyalar.Location = new System.Drawing.Point(223, 82);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(205, 334);
            this.lstDosyalar.TabIndex = 2;
            this.lstDosyalar.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDosyalar);
            this.Controls.Add(this.lstKlasörler);
            this.Controls.Add(this.lstDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDriver;
        private System.Windows.Forms.ListBox lstKlasörler;
        private System.Windows.Forms.ListBox lstDosyalar;
    }
}
