namespace PelinHallinta
{
    partial class FormUusi
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
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalasana = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSalasana = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnSulje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(13, 22);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(27, 13);
            this.lblNimi.TabIndex = 0;
            this.lblNimi.Text = "Nimi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(282, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblSalasana
            // 
            this.lblSalasana.AutoSize = true;
            this.lblSalasana.Location = new System.Drawing.Point(590, 22);
            this.lblSalasana.Name = "lblSalasana";
            this.lblSalasana.Size = new System.Drawing.Size(51, 13);
            this.lblSalasana.TabIndex = 2;
            this.lblSalasana.Text = "Salasana";
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(16, 39);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(225, 20);
            this.tbNimi.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(247, 39);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(326, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbSalasana
            // 
            this.tbSalasana.Location = new System.Drawing.Point(579, 39);
            this.tbSalasana.Name = "tbSalasana";
            this.tbSalasana.Size = new System.Drawing.Size(209, 20);
            this.tbSalasana.TabIndex = 5;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(173, 92);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(141, 23);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna pelaaja";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(500, 92);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(141, 23);
            this.btnSulje.TabIndex = 7;
            this.btnSulje.Text = "Sulje ikkuna";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // FormUusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 143);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.tbSalasana);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.lblSalasana);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNimi);
            this.Name = "FormUusi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalasana;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSalasana;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnSulje;
    }
}