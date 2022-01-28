namespace PelinHallinta
{
    partial class FormPisteet
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmbPelaaja = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPisteet = new System.Windows.Forms.Label();
            this.lblPvm = new System.Windows.Forms.Label();
            this.tbPisteet = new System.Windows.Forms.TextBox();
            this.tbPvm = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(39, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Pelaaja";
            // 
            // cmbPelaaja
            // 
            this.cmbPelaaja.FormattingEnabled = true;
            this.cmbPelaaja.Location = new System.Drawing.Point(42, 53);
            this.cmbPelaaja.Name = "cmbPelaaja";
            this.cmbPelaaja.Size = new System.Drawing.Size(226, 21);
            this.cmbPelaaja.TabIndex = 1;
            this.cmbPelaaja.SelectedIndexChanged += new System.EventHandler(this.cmbPelaaja_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(274, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblPisteet
            // 
            this.lblPisteet.AutoSize = true;
            this.lblPisteet.Location = new System.Drawing.Point(39, 117);
            this.lblPisteet.Name = "lblPisteet";
            this.lblPisteet.Size = new System.Drawing.Size(39, 13);
            this.lblPisteet.TabIndex = 3;
            this.lblPisteet.Text = "Pisteet";
            // 
            // lblPvm
            // 
            this.lblPvm.AutoSize = true;
            this.lblPvm.Location = new System.Drawing.Point(274, 117);
            this.lblPvm.Name = "lblPvm";
            this.lblPvm.Size = new System.Drawing.Size(107, 13);
            this.lblPvm.TabIndex = 4;
            this.lblPvm.Text = "PVM (YYYY-MM-DD)";
            // 
            // tbPisteet
            // 
            this.tbPisteet.Location = new System.Drawing.Point(42, 134);
            this.tbPisteet.Name = "tbPisteet";
            this.tbPisteet.Size = new System.Drawing.Size(120, 20);
            this.tbPisteet.TabIndex = 5;
            // 
            // tbPvm
            // 
            this.tbPvm.Location = new System.Drawing.Point(277, 134);
            this.tbPvm.Name = "tbPvm";
            this.tbPvm.Size = new System.Drawing.Size(192, 20);
            this.tbPvm.TabIndex = 6;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(42, 208);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(120, 23);
            this.btnTallenna.TabIndex = 7;
            this.btnTallenna.Text = "Tallenna pisteet";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(277, 208);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(120, 23);
            this.btnSulje.TabIndex = 8;
            this.btnSulje.Text = "Sulje ikkuna";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // FormPisteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 276);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.tbPvm);
            this.Controls.Add(this.tbPisteet);
            this.Controls.Add(this.lblPvm);
            this.Controls.Add(this.lblPisteet);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbPelaaja);
            this.Controls.Add(this.lbl1);
            this.Name = "FormPisteet";
            this.Text = "FormPisteet";
            this.Load += new System.EventHandler(this.FormPisteet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmbPelaaja;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPisteet;
        private System.Windows.Forms.Label lblPvm;
        private System.Windows.Forms.TextBox tbPisteet;
        private System.Windows.Forms.TextBox tbPvm;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnSulje;
    }
}