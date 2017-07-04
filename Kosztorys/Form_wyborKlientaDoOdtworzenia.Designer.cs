namespace Kosztorys
{
    partial class Form_wyborKlientaDoOdtworzenia
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
            this.listBox_KlienciArchiwum = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_KlienciArchiwum
            // 
            this.listBox_KlienciArchiwum.FormattingEnabled = true;
            this.listBox_KlienciArchiwum.Location = new System.Drawing.Point(12, 12);
            this.listBox_KlienciArchiwum.Name = "listBox_KlienciArchiwum";
            this.listBox_KlienciArchiwum.Size = new System.Drawing.Size(215, 420);
            this.listBox_KlienciArchiwum.TabIndex = 0;
            this.listBox_KlienciArchiwum.DoubleClick += new System.EventHandler(this.listBox_KlienciArchiwum_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wybierz klienta [ENTER]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_wyborKlientaDoOdtworzenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_KlienciArchiwum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_wyborKlientaDoOdtworzenia";
            this.Text = "Wybierz klienta do odtworzenia...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_KlienciArchiwum;
        private System.Windows.Forms.Button button1;
    }
}