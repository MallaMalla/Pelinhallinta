namespace PelinHallinta
{
    partial class FormAlku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlku));
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmbPelaaja = new System.Windows.Forms.ComboBox();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalasana = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSalasana = new System.Windows.Forms.TextBox();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPisteet = new System.Windows.Forms.Button();
            this.btnUusi = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnPistehistoria = new System.Windows.Forms.Button();
            this.btnHistoriaPDF = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnRankPDF = new System.Windows.Forms.Button();
            this.lbHistoria = new System.Windows.Forms.ListBox();
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Pelaaja";
            // 
            // cmbPelaaja
            // 
            this.cmbPelaaja.FormattingEnabled = true;
            this.cmbPelaaja.Location = new System.Drawing.Point(16, 30);
            this.cmbPelaaja.Name = "cmbPelaaja";
            this.cmbPelaaja.Size = new System.Drawing.Size(231, 21);
            this.cmbPelaaja.TabIndex = 1;
            this.cmbPelaaja.SelectedIndexChanged += new System.EventHandler(this.cmbPelaaja_SelectedIndexChanged);
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(16, 68);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(27, 13);
            this.lblNimi.TabIndex = 2;
            this.lblNimi.Text = "Nimi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblSalasana
            // 
            this.lblSalasana.AutoSize = true;
            this.lblSalasana.Location = new System.Drawing.Point(16, 182);
            this.lblSalasana.Name = "lblSalasana";
            this.lblSalasana.Size = new System.Drawing.Size(51, 13);
            this.lblSalasana.TabIndex = 4;
            this.lblSalasana.Text = "Salasana";
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(16, 84);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(228, 20);
            this.tbNimi.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(16, 140);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(289, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbSalasana
            // 
            this.tbSalasana.Location = new System.Drawing.Point(16, 198);
            this.tbSalasana.Name = "tbSalasana";
            this.tbSalasana.Size = new System.Drawing.Size(289, 20);
            this.tbSalasana.TabIndex = 7;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(16, 245);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(289, 23);
            this.btnMuokkaa.TabIndex = 8;
            this.btnMuokkaa.Text = "Muokkaa yllä ja tallenna tästä";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPisteet
            // 
            this.btnPisteet.Location = new System.Drawing.Point(16, 300);
            this.btnPisteet.Name = "btnPisteet";
            this.btnPisteet.Size = new System.Drawing.Size(289, 79);
            this.btnPisteet.TabIndex = 9;
            this.btnPisteet.Text = "Lisää pelaajalle pisteitä";
            this.btnPisteet.UseVisualStyleBackColor = true;
            this.btnPisteet.Click += new System.EventHandler(this.btnPisteet_Click);
            // 
            // btnUusi
            // 
            this.btnUusi.Location = new System.Drawing.Point(16, 418);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(228, 23);
            this.btnUusi.TabIndex = 10;
            this.btnUusi.Text = "Lisää uusi pelaaja";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(16, 458);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(228, 23);
            this.btnPoista.TabIndex = 11;
            this.btnPoista.Text = "Poista pelaaja";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(16, 523);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(289, 75);
            this.btnTyhjenna.TabIndex = 12;
            this.btnTyhjenna.Text = "Tyhjennä kentät";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(253, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // btnPistehistoria
            // 
            this.btnPistehistoria.Location = new System.Drawing.Point(439, 13);
            this.btnPistehistoria.Name = "btnPistehistoria";
            this.btnPistehistoria.Size = new System.Drawing.Size(161, 23);
            this.btnPistehistoria.TabIndex = 14;
            this.btnPistehistoria.Text = "Pelaajan pistehistoria";
            this.btnPistehistoria.UseVisualStyleBackColor = true;
            this.btnPistehistoria.Click += new System.EventHandler(this.btnPistehistoria_Click);
            // 
            // btnHistoriaPDF
            // 
            this.btnHistoriaPDF.Location = new System.Drawing.Point(439, 236);
            this.btnHistoriaPDF.Name = "btnHistoriaPDF";
            this.btnHistoriaPDF.Size = new System.Drawing.Size(161, 23);
            this.btnHistoriaPDF.TabIndex = 15;
            this.btnHistoriaPDF.Text = "Pistehistoria PDF";
            this.btnHistoriaPDF.UseVisualStyleBackColor = true;
            this.btnHistoriaPDF.Click += new System.EventHandler(this.btnHistoriaPDF_Click);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(439, 300);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(161, 23);
            this.btnRank.TabIndex = 16;
            this.btnRank.Text = "Ranking tilanne";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnRankPDF
            // 
            this.btnRankPDF.Location = new System.Drawing.Point(439, 575);
            this.btnRankPDF.Name = "btnRankPDF";
            this.btnRankPDF.Size = new System.Drawing.Size(161, 23);
            this.btnRankPDF.TabIndex = 17;
            this.btnRankPDF.Text = "Ranking PDF";
            this.btnRankPDF.UseVisualStyleBackColor = true;
            this.btnRankPDF.Click += new System.EventHandler(this.btnRankPDF_Click);
            // 
            // lbHistoria
            // 
            this.lbHistoria.FormattingEnabled = true;
            this.lbHistoria.Location = new System.Drawing.Point(384, 44);
            this.lbHistoria.Name = "lbHistoria";
            this.lbHistoria.Size = new System.Drawing.Size(275, 186);
            this.lbHistoria.TabIndex = 18;
            // 
            // lbRanking
            // 
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.Location = new System.Drawing.Point(384, 331);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(275, 238);
            this.lbRanking.TabIndex = 19;
            // 
            // FormAlku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 635);
            this.Controls.Add(this.lbRanking);
            this.Controls.Add(this.lbHistoria);
            this.Controls.Add(this.btnRankPDF);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnHistoriaPDF);
            this.Controls.Add(this.btnPistehistoria);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.btnPisteet);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.tbSalasana);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.lblSalasana);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.cmbPelaaja);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlku";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAlku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmbPelaaja;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalasana;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSalasana;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPisteet;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnPistehistoria;
        private System.Windows.Forms.Button btnHistoriaPDF;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnRankPDF;
        private System.Windows.Forms.ListBox lbHistoria;
        private System.Windows.Forms.ListBox lbRanking;
    }
}

