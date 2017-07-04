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
            this.CBox_BazaUslug = new System.Windows.Forms.ComboBox();
            this.lbl_Cena = new System.Windows.Forms.Label();
            this.numericUpDown_Dlugosc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Szerokosc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Wysokosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DodajUsluge = new System.Windows.Forms.Button();
            this.numericUpDown_Ilosc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Uwagi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Drukuj = new System.Windows.Forms.Button();
            this.numericUpDown_Cena = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Pomieszczenia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Klient = new System.Windows.Forms.Label();
            this.textBox_Razem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_JednostkaMiary = new System.Windows.Forms.Label();
            this.lbl_MiaraPrzyIlosci = new System.Windows.Forms.Label();
            this.btn_UsunWgZaznaczenia = new System.Windows.Forms.Button();
            this.lbl_bledy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dlugosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Szerokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Wysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ilosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cena)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(265, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.dodajKlientaToolStripMenuItem,
            this.otwórzKlientaToolStripMenuItem,
            this.edytujPomieszczeniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.AutoSize = false;
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator2,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
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
            this.dodajKlientaToolStripMenuItem.AutoSize = false;
            this.dodajKlientaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.dodajKlientaToolStripMenuItem.Name = "dodajKlientaToolStripMenuItem";
            this.dodajKlientaToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.dodajKlientaToolStripMenuItem.Text = "Dodaj klienta";
            this.dodajKlientaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlientaToolStripMenuItem_Click);
            // 
            // otwórzKlientaToolStripMenuItem
            // 
            this.otwórzKlientaToolStripMenuItem.AutoSize = false;
            this.otwórzKlientaToolStripMenuItem.Name = "otwórzKlientaToolStripMenuItem";
            this.otwórzKlientaToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.otwórzKlientaToolStripMenuItem.Text = "Otwórz klienta";
            this.otwórzKlientaToolStripMenuItem.Click += new System.EventHandler(this.otwórzKlientaToolStripMenuItem_Click);
            // 
            // edytujPomieszczeniaToolStripMenuItem
            // 
            this.edytujPomieszczeniaToolStripMenuItem.AutoSize = false;
            this.edytujPomieszczeniaToolStripMenuItem.Name = "edytujPomieszczeniaToolStripMenuItem";
            this.edytujPomieszczeniaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.edytujPomieszczeniaToolStripMenuItem.Text = "Edytuj pomieszczenia";
            this.edytujPomieszczeniaToolStripMenuItem.Click += new System.EventHandler(this.edytujPomieszczeniaToolStripMenuItem_Click);
            // 
            // CBox_BazaUslug
            // 
            this.CBox_BazaUslug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBox_BazaUslug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBox_BazaUslug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBox_BazaUslug.FormattingEnabled = true;
            this.CBox_BazaUslug.Location = new System.Drawing.Point(12, 114);
            this.CBox_BazaUslug.Name = "CBox_BazaUslug";
            this.CBox_BazaUslug.Size = new System.Drawing.Size(247, 21);
            this.CBox_BazaUslug.TabIndex = 2;
            this.CBox_BazaUslug.SelectedIndexChanged += new System.EventHandler(this.CBox_BazaUslug_SelectedIndexChanged);
            this.CBox_BazaUslug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CBox_BazaUslug_KeyDown);
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
            this.numericUpDown_Dlugosc.TabIndex = 4;
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
            this.numericUpDown_Szerokosc.TabIndex = 5;
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
            this.numericUpDown_Wysokosc.TabIndex = 6;
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
            // btn_DodajUsluge
            // 
            this.btn_DodajUsluge.Location = new System.Drawing.Point(12, 414);
            this.btn_DodajUsluge.Name = "btn_DodajUsluge";
            this.btn_DodajUsluge.Size = new System.Drawing.Size(247, 23);
            this.btn_DodajUsluge.TabIndex = 8;
            this.btn_DodajUsluge.Text = "Dodaj pracę do zestawienia [ENTER]";
            this.btn_DodajUsluge.UseVisualStyleBackColor = true;
            this.btn_DodajUsluge.Click += new System.EventHandler(this.btn_DodajUsluge_Click);
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
            this.numericUpDown_Ilosc.TabIndex = 3;
            this.numericUpDown_Ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Ilosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Ilosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_Ilosc_KeyDown);
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
            this.txtBox_Uwagi.TabIndex = 7;
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
            // btn_Drukuj
            // 
            this.btn_Drukuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Drukuj.Location = new System.Drawing.Point(265, 562);
            this.btn_Drukuj.Name = "btn_Drukuj";
            this.btn_Drukuj.Size = new System.Drawing.Size(139, 30);
            this.btn_Drukuj.TabIndex = 15;
            this.btn_Drukuj.Text = "Drukuj";
            this.btn_Drukuj.UseVisualStyleBackColor = true;
            this.btn_Drukuj.Click += new System.EventHandler(this.btn_Drukuj_Click);
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
            this.comboBox_Pomieszczenia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Pomieszczenia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Pomieszczenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Pomieszczenia.FormattingEnabled = true;
            this.comboBox_Pomieszczenia.Location = new System.Drawing.Point(12, 62);
            this.comboBox_Pomieszczenia.Name = "comboBox_Pomieszczenia";
            this.comboBox_Pomieszczenia.Size = new System.Drawing.Size(247, 21);
            this.comboBox_Pomieszczenia.TabIndex = 1;
            this.comboBox_Pomieszczenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Pomieszczenia_KeyDown);
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
            // textBox_Razem
            // 
            this.textBox_Razem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Razem.Location = new System.Drawing.Point(978, 562);
            this.textBox_Razem.Multiline = true;
            this.textBox_Razem.Name = "textBox_Razem";
            this.textBox_Razem.ReadOnly = true;
            this.textBox_Razem.Size = new System.Drawing.Size(100, 30);
            this.textBox_Razem.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(902, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "RAZEM:";
            // 
            // lbl_JednostkaMiary
            // 
            this.lbl_JednostkaMiary.AutoSize = true;
            this.lbl_JednostkaMiary.Location = new System.Drawing.Point(208, 148);
            this.lbl_JednostkaMiary.Name = "lbl_JednostkaMiary";
            this.lbl_JednostkaMiary.Size = new System.Drawing.Size(0, 13);
            this.lbl_JednostkaMiary.TabIndex = 24;
            // 
            // lbl_MiaraPrzyIlosci
            // 
            this.lbl_MiaraPrzyIlosci.AutoSize = true;
            this.lbl_MiaraPrzyIlosci.Location = new System.Drawing.Point(208, 177);
            this.lbl_MiaraPrzyIlosci.Name = "lbl_MiaraPrzyIlosci";
            this.lbl_MiaraPrzyIlosci.Size = new System.Drawing.Size(0, 13);
            this.lbl_MiaraPrzyIlosci.TabIndex = 25;
            // 
            // btn_UsunWgZaznaczenia
            // 
            this.btn_UsunWgZaznaczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_UsunWgZaznaczenia.Location = new System.Drawing.Point(424, 562);
            this.btn_UsunWgZaznaczenia.Name = "btn_UsunWgZaznaczenia";
            this.btn_UsunWgZaznaczenia.Size = new System.Drawing.Size(208, 30);
            this.btn_UsunWgZaznaczenia.TabIndex = 26;
            this.btn_UsunWgZaznaczenia.Text = "Usuń zaznaczony wpis";
            this.btn_UsunWgZaznaczenia.UseVisualStyleBackColor = true;
            this.btn_UsunWgZaznaczenia.Click += new System.EventHandler(this.btn_UsunWgZaznaczenia_Click);
            // 
            // lbl_bledy
            // 
            this.lbl_bledy.AutoSize = true;
            this.lbl_bledy.Location = new System.Drawing.Point(12, 539);
            this.lbl_bledy.Name = "lbl_bledy";
            this.lbl_bledy.Size = new System.Drawing.Size(0, 13);
            this.lbl_bledy.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 672);
            this.Controls.Add(this.lbl_bledy);
            this.Controls.Add(this.btn_UsunWgZaznaczenia);
            this.Controls.Add(this.lbl_MiaraPrzyIlosci);
            this.Controls.Add(this.lbl_JednostkaMiary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Razem);
            this.Controls.Add(this.lbl_Klient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Pomieszczenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Cena);
            this.Controls.Add(this.btn_Drukuj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Uwagi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_Ilosc);
            this.Controls.Add(this.btn_DodajUsluge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Wysokosc);
            this.Controls.Add(this.numericUpDown_Szerokosc);
            this.Controls.Add(this.numericUpDown_Dlugosc);
            this.Controls.Add(this.lbl_Cena);
            this.Controls.Add(this.CBox_BazaUslug);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBox_BazaUslug;
        private System.Windows.Forms.Label lbl_Cena;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dlugosc;
        private System.Windows.Forms.NumericUpDown numericUpDown_Szerokosc;
        private System.Windows.Forms.NumericUpDown numericUpDown_Wysokosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DodajUsluge;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ilosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Uwagi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Drukuj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzKlientaToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Pomieszczenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem edytujPomieszczeniaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Klient;
        //private System.Windows.Forms.BindingSource wykonanaUslugaBindingSource;
        private System.Windows.Forms.TextBox textBox_Razem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_JednostkaMiary;
        private System.Windows.Forms.Label lbl_MiaraPrzyIlosci;
        private System.Windows.Forms.Button btn_UsunWgZaznaczenia;
        private System.Windows.Forms.Label lbl_bledy;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

