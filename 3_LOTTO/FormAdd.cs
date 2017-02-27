using System;
using System.Windows.Forms;

namespace _3_LOTTO
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private string data, liczba1, liczba2, liczba3, liczba4, liczba5, liczba6;

        public string Data
        {
            get { return data; }
        }

        public string Liczba1
        {
            get { return liczba1; }
        }
        
        public string Liczba2
        {
            get { return liczba2; }
        }

        public string Liczba3
        {
            get { return liczba3; }
        }

        public string Liczba4
        {
            get { return liczba4; }
        }

        public string Liczba5
        {
            get { return liczba5; }
        }

        public string Liczba6
        {
            get { return liczba6; }
        }
        
        private void btDodajLiczby_Click(object sender, EventArgs e)
        {
            data = dtpDataLosowania.Value.ToShortDateString();
            liczba1 = txt1.Text;
            liczba2 = txt2.Text;
            liczba3 = txt3.Text;
            liczba4 = txt4.Text;
            liczba5 = txt5.Text;
            liczba6 = txt6.Text;

            if (CheckFields())
                DialogResult = DialogResult.OK;

            else
                MessageBox.Show("Podaj wszystkie liczby!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckFields()
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "" || txt6.Text == "")
                return false;
            
            return true;
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
