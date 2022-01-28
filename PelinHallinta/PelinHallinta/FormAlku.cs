using ClassPelaajat;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelinHallinta
{
    public partial class FormAlku : Form
    {
        public FormAlku()
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
            tbNimi.Text = "";
            tbEmail.Text = "";
            tbSalasana.Text = "";
            lbHistoria.Text = "";
            lbRanking.Text = "";
        }

        private void FormAlku_Load(object sender, EventArgs e)
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

            DataRow row = pelaaja.Dt.Rows[0];

            tbNimi.Text = row["nimi"].ToString();
            tbEmail.Text = row["email"].ToString();
            tbSalasana.Text = row["salasana"].ToString();
        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            var uusiformi = new FormUusi();
            uusiformi.ShowDialog();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "ID")
            {
                MessageBox.Show("Valitse pelaaja");
                return;
            }

            string sEmail = tbEmail.Text;
            string sId = lblID.Text;
            string sNimi = tbNimi.Text;
            string sSalasana = tbSalasana.Text;

            Pelaaja muokkaa = new Pelaaja();
            muokkaa.muokkaaPelaaja(sId, sNimi, sEmail, sSalasana);

            if (muokkaa.Virhe != "0")
            {
                MessageBox.Show(muokkaa.Virhe);
                return;
            }

            if (muokkaa.Loytyi == 1)
            {
                MessageBox.Show("Sähköposti on jo olemassa", "Huomio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tyhjenna();
                cmbPelaaja.Items.Clear();
                LataaCombo();
            }
        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            tbNimi.Text = "";
            tbEmail.Text = "";
            tbSalasana.Text = "";
            lbHistoria.Items.Clear();
            lbRanking.Items.Clear();
            lblID.Text = "ID";
            cmbPelaaja.Items.Clear();

            LataaCombo();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "ID")
            {
                MessageBox.Show("Valitse pelaaja");
                return;
            }
            if (MessageBox.Show("Haluatko varmasti poistaa pelaajan?", "Poista", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                Pelaaja poista = new Pelaaja();
                poista.poistaPelaaja(lblID.Text);

                if (poista.Virhe != "0")
                {
                    MessageBox.Show(poista.Virhe);
                    return;
                }

                tyhjenna();
                cmbPelaaja.Items.Clear();
                LataaCombo();
            }
        }

        private void btnPisteet_Click(object sender, EventArgs e)
        {
            var pisteformi = new FormPisteet();
            pisteformi.ShowDialog();
        }

        private void btnPistehistoria_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "ID")
            {
                MessageBox.Show("Valitse pelaaja");
                return;
            }

            string sId = lblID.Text;

            Piste historia = new Piste();
            historia.HaeHistoria(sId);

            if (historia.Virhe != "0")
            {
                MessageBox.Show(historia.Virhe);
                return;
            }

            for (int i = 0; i < historia.Dt.Rows.Count; i++)
            {
                DataRow row = historia.Dt.Rows[i];
                lbHistoria.Items.Add(row["pvm"] + "   " + row["pisteet"] + "   " + row["nimi"]);
            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            Piste ranking = new Piste();
            ranking.HaeRanking();

            if (ranking.Virhe != "0")
            {
                MessageBox.Show(ranking.Virhe);
                return;
            }

            for (int i = 0; i < ranking.Dt.Rows.Count; i++)
            {
                DataRow row = ranking.Dt.Rows[i];
                lbRanking.Items.Add(row["pvm"] + "   " + row["pisteet"] + "   " + row["nimi"]);
            }
        }

        private void btnRankPDF_Click(object sender, EventArgs e)
        {
            string kansio = "Ranking";

            Piste rankPdf = new Piste();
            rankPdf.HaeRanking();

            if (rankPdf.Virhe != "0")
            {
                MessageBox.Show(rankPdf.Virhe);
                return;
            }

            if (!Directory.Exists(@"D:\" + kansio))
            {
                Directory.CreateDirectory(@"D:\" + kansio);
            }

            PdfWriter writer = new PdfWriter("D:\\" + kansio + "\\ranking.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document pdfDoc = new Document(pdf);

            Paragraph otsikko = new Paragraph("RANKINGTILANNE").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            pdfDoc.Add(otsikko);

            for (int i = 0; i < rankPdf.Dt.Rows.Count; i++)
            {
                DataRow row = rankPdf.Dt.Rows[i];
                Paragraph rank = new Paragraph(row["pvm"] + "     " + row["pisteet"] + "     " + row["nimi"]);
                pdfDoc.Add(rank);
            }

            MessageBox.Show("Rankingtilanne on tulostettu kansioon D:\\" + kansio);
            pdfDoc.Close();
        }

        private void btnHistoriaPDF_Click(object sender, EventArgs e)
        {
            string kansio = "Pistehistoria";

            if (lblID.Text == "ID")
            {
                MessageBox.Show("Valitse pelaaja");
                return;
            }

            string sId = lblID.Text;

            Piste historiaPdf = new Piste();
            historiaPdf.HaeHistoria(sId);

            if (historiaPdf.Virhe != "0")
            {
                MessageBox.Show(historiaPdf.Virhe);
                return;
            }

            if (!Directory.Exists(@"D:\" + kansio))
            {
                Directory.CreateDirectory(@"D:\" + kansio);
            }

            PdfWriter writer = new PdfWriter("D:\\" + kansio + "\\historiaID" + sId + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document pdfDoc = new Document(pdf);

            Paragraph otsikko = new Paragraph("PISTEHISTORIA").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            pdfDoc.Add(otsikko);

            for (int i = 0; i < historiaPdf.Dt.Rows.Count; i++)
            {
                DataRow row = historiaPdf.Dt.Rows[i];
                Paragraph rank = new Paragraph(row["pvm"] + "     " + row["pisteet"] + "     " + row["nimi"]);
                pdfDoc.Add(rank);
            }

            MessageBox.Show("Pelaajan pistehistoria on tulostettu kansioon D:\\" + kansio);
            pdfDoc.Close();
        }
    }
}
