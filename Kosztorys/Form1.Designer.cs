namespace Kosztorys
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujPomieszczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBox_listaZadań = new System.Windows.Forms.ComboBox();
            this.lbl_Cena = new System.Windows.Forms.Label();
            this.numericUpDown_Dlugosc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Szerokosc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Wysokosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_Ilosc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Uwagi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown_Cena = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Pomieszczenia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Klient = new System.Windows.Forms.Label();
            this.wykonanaUslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Razem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dlugosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Szerokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Wysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ilosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykonanaUslugaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(265, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.dodajKlientaToolStripMenuItem,
            this.otwórzKlientaToolStripMenuItem,
            this.edytujPomieszczeniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator2,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(115, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // dodajKlientaToolStripMenuItem
            // 
            this.dodajKlientaToolStripMenuItem.Name = "dodajKlientaToolStripMenuItem";
            this.dodajKlientaToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.dodajKlientaToolStripMenuItem.Text = "Dodaj klienta";
            this.dodajKlientaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlientaToolStripMenuItem_Click);
            // 
            // otwórzKlientaToolStripMenuItem
            // 
            this.otwórzKlientaToolStripMenuItem.Name = "otwórzKlientaToolStripMenuItem";
            this.otwórzKlientaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.otwórzKlientaToolStripMenuItem.Text = "Otwórz klienta";
            this.otwórzKlientaToolStripMenuItem.Click += new System.EventHandler(this.otwórzKlientaToolStripMenuItem_Click);
            // 
            // edytujPomieszczeniaToolStripMenuItem
            // 
            this.edytujPomieszczeniaToolStripMenuItem.Name = "edytujPomieszczeniaToolStripMenuItem";
            this.edytujPomieszczeniaToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.edytujPomieszczeniaToolStripMenuItem.Text = "Edytuj pomieszczenia";
            this.edytujPomieszczeniaToolStripMenuItem.Click += new System.EventHandler(this.edytujPomieszczeniaToolStripMenuItem_Click);
            // 
            // CBox_listaZadań
            // 
            this.CBox_listaZadań.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBox_listaZadań.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBox_listaZadań.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBox_listaZadań.FormattingEnabled = true;
            this.CBox_listaZadań.Location = new System.Drawing.Point(12, 114);
            this.CBox_listaZadań.Name = "CBox_listaZadań";
            this.CBox_listaZadań.Size = new System.Drawing.Size(247, 21);
            this.CBox_listaZadań.TabIndex = 1;
            this.CBox_listaZadań.SelectedIndexChanged += new System.EventHandler(this.CBox_listaZadań_SelectedIndexChanged);
            this.CBox_listaZadań.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CBox_listaZadań_KeyDown);
            // 
            // lbl_Cena
            // 
            this.lbl_Cena.AutoSize = true;
            this.lbl_Cena.Location = new System.Drawing.Point(15, 148);
            this.lbl_Cena.Name = "lbl_Cena";
            this.lbl_Cena.Size = new System.Drawing.Size(35, 13);
            this.lbl_Cena.TabIndex = 3;
            this.lbl_Cena.Text = "Cena:";
            // 
            // numericUpDown_Dlugosc
            // 
            this.numericUpDown_Dlugosc.Location = new System.Drawing.Point(82, 212);
            this.numericUpDown_Dlugosc.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_Dlugosc.Name = "numericUpDown_Dlugosc";
            this.numericUpDown_Dlugosc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Dlugosc.TabIndex = 3;
            this.numericUpDown_Dlugosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_Szerokosc
            // 
            this.numericUpDown_Szerokosc.Location = new System.Drawing.Point(82, 247);
            this.numericUpDown_Szerokosc.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_Szerokosc.Name = "numericUpDown_Szerokosc";
            this.numericUpDown_Szerokosc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Szerokosc.TabIndex = 4;
            this.numericUpDown_Szerokosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_Wysokosc
            // 
            this.numericUpDown_Wysokosc.Location = new System.Drawing.Point(82, 283);
            this.numericUpDown_Wysokosc.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_Wysokosc.Name = "numericUpDown_Wysokosc";
            this.numericUpDown_Wysokosc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Wysokosc.TabIndex = 5;
            this.numericUpDown_Wysokosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Długość:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Szerokość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wysokość:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj pracę do zestawienia [ENTER]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_Ilosc
            // 
            this.numericUpDown_Ilosc.Location = new System.Drawing.Point(82, 175);
            this.numericUpDown_Ilosc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_Ilosc.Name = "numericUpDown_Ilosc";
            this.numericUpDown_Ilosc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Ilosc.TabIndex = 2;
            this.numericUpDown_Ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Ilosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ilość:";
            // 
            // txtBox_Uwagi
            // 
            this.txtBox_Uwagi.Location = new System.Drawing.Point(18, 346);
            this.txtBox_Uwagi.Multiline = true;
            this.txtBox_Uwagi.Name = "txtBox_Uwagi";
            this.txtBox_Uwagi.Size = new System.Drawing.Size(241, 62);
            this.txtBox_Uwagi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Uwagi:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1199, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown_Cena
            // 
            this.numericUpDown_Cena.Location = new System.Drawing.Point(82, 146);
            this.numericUpDown_Cena.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_Cena.Name = "numericUpDown_Cena";
            this.numericUpDown_Cena.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Cena.TabIndex = 16;
            this.numericUpDown_Cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1199, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Wybierz usługę:";
            // 
            // comboBox_Pomieszczenia
            // 
            this.comboBox_Pomieszczenia.FormattingEnabled = true;
            this.comboBox_Pomieszczenia.Location = new System.Drawing.Point(12, 62);
            this.comboBox_Pomieszczenia.Name = "comboBox_Pomieszczenia";
            this.comboBox_Pomieszczenia.Size = new System.Drawing.Size(247, 21);
            this.comboBox_Pomieszczenia.TabIndex = 19;
            this.comboBox_Pomieszczenia.Click += new System.EventHandler(this.comboBox_Pomieszczenia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Wybierz pomieszczenie:";
            // 
            // lbl_Klient
            // 
            this.lbl_Klient.AutoSize = true;
            this.lbl_Klient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Klient.Location = new System.Drawing.Point(265, 28);
            this.lbl_Klient.Name = "lbl_Klient";
            this.lbl_Klient.Size = new System.Drawing.Size(203, 20);
            this.lbl_Klient.TabIndex = 21;
            this.lbl_Klient.Text = "Nie zdefiniowano klienta";
            // 
            // wykonanaUslugaBindingSource
            // 
            this.wykonanaUslugaBindingSource.DataSource = typeof(Kosztorys.WykonanaUsluga);
            // 
            // textBox_Razem
            // 
            this.textBox_Razem.Location = new System.Drawing.Point(978, 559);
            this.textBox_Razem.Name = "textBox_Razem";
            this.textBox_Razem.ReadOnly = true;
            this.textBox_Razem.Size = new System.Drawing.Size(100, 20);
            this.textBox_Razem.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(924, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "RAZEM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Razem);
            this.Controls.Add(this.lbl_Klient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Pomieszczenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown_Cena);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Uwagi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_Ilosc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Wysokosc);
            this.Controls.Add(this.numericUpDown_Szerokosc);
            this.Controls.Add(this.numericUpDown_Dlugosc);
            this.Controls.Add(this.lbl_Cena);
            this.Controls.Add(this.CBox_listaZadań);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kosztorys - Remonty Jędrzejów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dlugosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Szerokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Wysokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ilosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykonanaUslugaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBox_listaZadań;
        private System.Windows.Forms.Label lbl_Cena;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dlugosc;
        private System.Windows.Forms.NumericUpDown numericUpDown_Szerokosc;
        private System.Windows.Forms.NumericUpDown numericUpDown_Wysokosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ilosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Uwagi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzKlientaToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cena;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Pomieszczenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem edytujPomieszczeniaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Klient;
        private System.Windows.Forms.BindingSource wykonanaUslugaBindingSource;
        private System.Windows.Forms.TextBox textBox_Razem;
        private System.Windows.Forms.Label label8;
    }
}

