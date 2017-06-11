namespace Kosztorys
{
    partial class Form_NowyKlient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_DodajKlienta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_DodajKlienta
            // 
            this.btn_DodajKlienta.Location = new System.Drawing.Point(13, 39);
            this.btn_DodajKlienta.Name = "btn_DodajKlienta";
            this.btn_DodajKlienta.Size = new System.Drawing.Size(309, 23);
            this.btn_DodajKlienta.TabIndex = 1;
            this.btn_DodajKlienta.Text = "Dodaj klienta [ENTER]";
            this.btn_DodajKlienta.UseVisualStyleBackColor = true;
            this.btn_DodajKlienta.Click += new System.EventHandler(this.btn_DodajKlienta_Click);
            // 
            // Form_NowyKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 69);
            this.Controls.Add(this.btn_DodajKlienta);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_NowyKlient";
            this.Text = "Wprowadź nazwę nowego klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_DodajKlienta;
    }
}