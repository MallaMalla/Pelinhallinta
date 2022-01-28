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
    public partial class FormPisteet : Form
    {
        public FormPisteet()
        {
            InitializeComponent();
        }

        private void LataaCombo()
        {
            Pelaaja pelaaja = new Pelaaja();
            pelaaja.HaePelaajat();

            if (pelaaja.Virhe != "0")
            {
                MessageBox.Show(pelaaja.Virhe);
                return;
            }

            for (int i = 0; i < pelaaja.Dt.Rows.Count; i++)
            {
                DataRow row = pelaaja.Dt.Rows[i];
                cmbPelaaja.Items.Add(row["pelaajaID"] + " " + row["nimi"]);
            }
        }

        private void tyhjenna()
        {
            tbPisteet.Text = "";
            tbPvm.Text = "";
        }

        private void FormPisteet_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;

            LataaCombo();
        }

        private void cmbPelaaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sId, sCmb;

            sCmb = cmbPelaaja.SelectedItem.ToString();
            sId = sCmb.Split(' ')[0];

            lblID.Text = sId;

            Pelaaja pelaaja = new Pelaaja();
            pelaaja.HaePelaaja(sId);

            if (pelaaja.Virhe != "0")
            {
                MessageBox.Show(pelaaja.Virhe);
                return;
            }
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            string sID = lblID.Text;
            string sPisteet = tbPisteet.Text;
            string sPvm = tbPvm.Text;

            Piste lisaa = new Piste();
            lisaa.Tallenna(sID, sPisteet, sPvm);

            if (lisaa.Virhe != "0")
            {
                MessageBox.Show(lisaa.Virhe);
                return;
            }

            tyhjenna();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
