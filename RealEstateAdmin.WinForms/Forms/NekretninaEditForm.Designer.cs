namespace RealEstateAdmin.WinForms
{
    partial class NekretninaEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblProjekat = new System.Windows.Forms.Label();
            this.cmbProjekat = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.lblStruktura = new System.Windows.Forms.Label();
            this.cmbStruktura = new System.Windows.Forms.ComboBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblSprat = new System.Windows.Forms.Label();
            this.nudSprat = new System.Windows.Forms.NumericUpDown();
            this.lblKvadratura = new System.Windows.Forms.Label();
            this.txtKvadratura = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.chkAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSprat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjekat
            // 
            this.lblProjekat.AutoSize = true;
            this.lblProjekat.Location = new System.Drawing.Point(12, 15);
            this.lblProjekat.Name = "lblProjekat";
            this.lblProjekat.Size = new System.Drawing.Size(47, 13);
            this.lblProjekat.TabIndex = 0;
            this.lblProjekat.Text = "Projekat";
            // 
            // cmbProjekat
            // 
            this.cmbProjekat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjekat.FormattingEnabled = true;
            this.cmbProjekat.Location = new System.Drawing.Point(92, 12);
            this.cmbProjekat.Name = "cmbProjekat";
            this.cmbProjekat.Size = new System.Drawing.Size(260, 21);
            this.cmbProjekat.TabIndex = 1;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(12, 42);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(57, 13);
            this.lblKategorija.TabIndex = 2;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(92, 39);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(260, 21);
            this.cmbKategorija.TabIndex = 3;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // lblStruktura
            // 
            this.lblStruktura.AutoSize = true;
            this.lblStruktura.Location = new System.Drawing.Point(12, 69);
            this.lblStruktura.Name = "lblStruktura";
            this.lblStruktura.Size = new System.Drawing.Size(48, 13);
            this.lblStruktura.TabIndex = 4;
            this.lblStruktura.Text = "Struktura";
            // 
            // cmbStruktura
            // 
            this.cmbStruktura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStruktura.FormattingEnabled = true;
            this.cmbStruktura.Location = new System.Drawing.Point(92, 66);
            this.cmbStruktura.Name = "cmbStruktura";
            this.cmbStruktura.Size = new System.Drawing.Size(260, 21);
            this.cmbStruktura.TabIndex = 5;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(12, 96);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 6;
            this.lblSifra.Text = "Šifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(92, 93);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(260, 20);
            this.txtSifra.TabIndex = 7;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 122);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(92, 119);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(260, 20);
            this.txtNaziv.TabIndex = 9;
            // 
            // lblSprat
            // 
            this.lblSprat.AutoSize = true;
            this.lblSprat.Location = new System.Drawing.Point(12, 148);
            this.lblSprat.Name = "lblSprat";
            this.lblSprat.Size = new System.Drawing.Size(32, 13);
            this.lblSprat.TabIndex = 10;
            this.lblSprat.Text = "Sprat";
            // 
            // nudSprat
            // 
            this.nudSprat.Location = new System.Drawing.Point(92, 146);
            this.nudSprat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSprat.Name = "nudSprat";
            this.nudSprat.Size = new System.Drawing.Size(120, 20);
            this.nudSprat.TabIndex = 11;
            // 
            // lblKvadratura
            // 
            this.lblKvadratura.AutoSize = true;
            this.lblKvadratura.Location = new System.Drawing.Point(12, 174);
            this.lblKvadratura.Name = "lblKvadratura";
            this.lblKvadratura.Size = new System.Drawing.Size(60, 13);
            this.lblKvadratura.TabIndex = 12;
            this.lblKvadratura.Text = "Kvadratura";
            // 
            // txtKvadratura
            // 
            this.txtKvadratura.Location = new System.Drawing.Point(92, 171);
            this.txtKvadratura.Name = "txtKvadratura";
            this.txtKvadratura.Size = new System.Drawing.Size(120, 20);
            this.txtKvadratura.TabIndex = 13;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(12, 200);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(28, 13);
            this.lblOpis.TabIndex = 14;
            this.lblOpis.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(92, 197);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(260, 80);
            this.txtOpis.TabIndex = 15;
            // 
            // chkAktivna
            // 
            this.chkAktivna.AutoSize = true;
            this.chkAktivna.Location = new System.Drawing.Point(92, 283);
            this.chkAktivna.Name = "chkAktivna";
            this.chkAktivna.Size = new System.Drawing.Size(62, 17);
            this.chkAktivna.TabIndex = 16;
            this.chkAktivna.Text = "Aktivna";
            this.chkAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(196, 314);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(277, 314);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 18;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // NekretninaEditForm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(372, 352);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.chkAktivna);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtKvadratura);
            this.Controls.Add(this.lblKvadratura);
            this.Controls.Add(this.nudSprat);
            this.Controls.Add(this.lblSprat);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.cmbStruktura);
            this.Controls.Add(this.lblStruktura);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.cmbProjekat);
            this.Controls.Add(this.lblProjekat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NekretninaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nekretnina";
            this.Load += new System.EventHandler(this.NekretninaEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSprat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProjekat;
        private System.Windows.Forms.ComboBox cmbProjekat;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label lblStruktura;
        private System.Windows.Forms.ComboBox cmbStruktura;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblSprat;
        private System.Windows.Forms.NumericUpDown nudSprat;
        private System.Windows.Forms.Label lblKvadratura;
        private System.Windows.Forms.TextBox txtKvadratura;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox chkAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}
