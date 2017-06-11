using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosztorys
{
    public partial class Form_NowyKlient : Form
    {
        public string NazwaKlienta { get;private set; }
        public Form_NowyKlient()
        {
            InitializeComponent();
        }

        private void btn_DodajKlienta_Click(object sender, EventArgs e)
        {
            UstaNazweKlienta();
        }

        private void UstaNazweKlienta()
        {
            if (textBox1.Text != "")
            {
                NazwaKlienta = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Wprowadź prawidłową nazwę");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UstaNazweKlienta();
        }
    }
}
