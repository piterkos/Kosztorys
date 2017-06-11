namespace Kosztorys
{
    partial class Form_EdycjaPomieszczen
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
            this.listBox_EdycjaPomieszczen = new System.Windows.Forms.ListBox();
            this.btn_DodajPomieszczenie = new System.Windows.Forms.Button();
            this.btn_UsunPomieszczenie = new System.Windows.Forms.Button();
            this.textBox_pomieszczenieDoDodania = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_EdycjaPomieszczen
            // 
            this.listBox_EdycjaPomieszczen.FormattingEnabled = true;
            this.listBox_EdycjaPomieszczen.Location = new System.Drawing.Point(12, 12);
            this.listBox_EdycjaPomieszczen.Name = "listBox_EdycjaPomieszczen";
            this.listBox_EdycjaPomieszczen.Size = new System.Drawing.Size(242, 290);
            this.listBox_EdycjaPomieszczen.TabIndex = 0;
            // 
            // btn_DodajPomieszczenie
            // 
            this.btn_DodajPomieszczenie.Location = new System.Drawing.Point(12, 335);
            this.btn_DodajPomieszczenie.Name = "btn_DodajPomieszczenie";
            this.btn_DodajPomieszczenie.Size = new System.Drawing.Size(124, 23);
            this.btn_DodajPomieszczenie.TabIndex = 1;
            this.btn_DodajPomieszczenie.Text = "Dodaj pomieszczenie";
            this.btn_DodajPomieszczenie.UseVisualStyleBackColor = true;
            this.btn_DodajPomieszczenie.Click += new System.EventHandler(this.btn_DodajPomieszczenie_Click);
            // 
            // btn_UsunPomieszczenie
            // 
            this.btn_UsunPomieszczenie.Location = new System.Drawing.Point(142, 335);
            this.btn_UsunPomieszczenie.Name = "btn_UsunPomieszczenie";
            this.btn_UsunPomieszczenie.Size = new System.Drawing.Size(111, 23);
            this.btn_UsunPomieszczenie.TabIndex = 2;
            this.btn_UsunPomieszczenie.Text = "Usuń zaznaczone";
            this.btn_UsunPomieszczenie.UseVisualStyleBackColor = true;
            this.btn_UsunPomieszczenie.Click += new System.EventHandler(this.btn_UsunPomieszczenie_Click);
            // 
            // textBox_pomieszczenieDoDodania
            // 
            this.textBox_pomieszczenieDoDodania.Location = new System.Drawing.Point(12, 309);
            this.textBox_pomieszczenieDoDodania.Name = "textBox_pomieszczenieDoDodania";
            this.textBox_pomieszczenieDoDodania.Size = new System.Drawing.Size(241, 20);
            this.textBox_pomieszczenieDoDodania.TabIndex = 3;
            // 
            // Form_EdycjaPomieszczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 366);
            this.Controls.Add(this.textBox_pomieszczenieDoDodania);
            this.Controls.Add(this.btn_UsunPomieszczenie);
            this.Controls.Add(this.btn_DodajPomieszczenie);
            this.Controls.Add(this.listBox_EdycjaPomieszczen);
            this.Name = "Form_EdycjaPomieszczen";
            this.Text = "Edycja Pomieszczeń";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_EdycjaPomieszczen;
        private System.Windows.Forms.Button btn_DodajPomieszczenie;
        private System.Windows.Forms.Button btn_UsunPomieszczenie;
        private System.Windows.Forms.TextBox textBox_pomieszczenieDoDodania;
    }
}