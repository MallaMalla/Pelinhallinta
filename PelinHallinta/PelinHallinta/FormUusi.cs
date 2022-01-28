using ClassPelaajat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelinHallinta
{
    public partial class FormUusi : Form
    {
        public FormUusi()
        {
            InitializeComponent();
        }

        private void tyhjenna()
        {
            tbNimi.Text = "";
            tbEmail.Text = "";
            tbSalasana.Text = "";
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            string sNimi = tbNimi.Text;
            string sEmail = tbEmail.Text;
            string sSalasana = tbSalasana.Text;

            Pelaaja lisaa = new Pelaaja();
            lisaa.Tallenna(sNimi, sEmail, sSalasana);

            if (lisaa.Virhe != "0")
            {
                MessageBox.Show(lisaa.Virhe);
                return;
            }

            if (lisaa.Loytyi == 1)
            {
                MessageBox.Show("Sähköposti on jo olemassa", "Huomio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tyhjenna();
            }
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
