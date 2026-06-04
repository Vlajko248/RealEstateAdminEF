namespace RealEstateAdmin.WinForms
{
    partial class NekretninaForm
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
            this.lblFilterProjekat = new System.Windows.Forms.Label();
            this.cmbFilterProjekat = new System.Windows.Forms.ComboBox();
            this.lblFilterGrad = new System.Windows.Forms.Label();
            this.cmbFilterGrad = new System.Windows.Forms.ComboBox();
            this.lblFilterKategorija = new System.Windows.Forms.Label();
            this.cmbFilterKategorija = new System.Windows.Forms.ComboBox();
            this.lblFilterStruktura = new System.Windows.Forms.Label();
            this.cmbFilterStruktura = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvNekretnine = new System.Windows.Forms.DataGridView();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblAktuelnaCenaTitle = new System.Windows.Forms.Label();
            this.lblAktuelnaCenaValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterProjekat
            // 
            this.lblFilterProjekat.AutoSize = true;
            this.lblFilterProjekat.Location = new System.Drawing.Point(12, 15);
            this.lblFilterProjekat.Name = "lblFilterProjekat";
            this.lblFilterProjekat.Size = new System.Drawing.Size(47, 13);
            this.lblFilterProjekat.TabIndex = 0;
            this.lblFilterProjekat.Text = "Projekat";
            // 
            // cmbFilterProjekat
            // 
            this.cmbFilterProjekat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterProjekat.FormattingEnabled = true;
            this.cmbFilterProjekat.Location = new System.Drawing.Point(79, 12);
            this.cmbFilterProjekat.Name = "cmbFilterProjekat";
            this.cmbFilterProjekat.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterProjekat.TabIndex = 1;
            // 
            // lblFilterGrad
            // 
            this.lblFilterGrad.AutoSize = true;
            this.lblFilterGrad.Location = new System.Drawing.Point(277, 15);
            this.lblFilterGrad.Name = "lblFilterGrad";
            this.lblFilterGrad.Size = new System.Drawing.Size(30, 13);
            this.lblFilterGrad.TabIndex = 2;
            this.lblFilterGrad.Text = "Grad";
            // 
            // cmbFilterGrad
            // 
            this.cmbFilterGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterGrad.FormattingEnabled = true;
            this.cmbFilterGrad.Location = new System.Drawing.Point(329, 12);
            this.cmbFilterGrad.Name = "cmbFilterGrad";
            this.cmbFilterGrad.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterGrad.TabIndex = 3;
            // 
            // lblFilterKategorija
            // 
            this.lblFilterKategorija.AutoSize = true;
            this.lblFilterKategorija.Location = new System.Drawing.Point(527, 15);
            this.lblFilterKategorija.Name = "lblFilterKategorija";
            this.lblFilterKategorija.Size = new System.Drawing.Size(57, 13);
            this.lblFilterKategorija.TabIndex = 4;
            this.lblFilterKategorija.Text = "Kategorija";
            // 
            // cmbFilterKategorija
            // 
            this.cmbFilterKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterKategorija.FormattingEnabled = true;
            this.cmbFilterKategorija.Location = new System.Drawing.Point(602, 12);
            this.cmbFilterKategorija.Name = "cmbFilterKategorija";
            this.cmbFilterKategorija.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterKategorija.TabIndex = 5;
            this.cmbFilterKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbFilterKategorija_SelectedIndexChanged);
            // 
            // lblFilterStruktura
            // 
            this.lblFilterStruktura.AutoSize = true;
            this.lblFilterStruktura.Location = new System.Drawing.Point(800, 15);
            this.lblFilterStruktura.Name = "lblFilterStruktura";
            this.lblFilterStruktura.Size = new System.Drawing.Size(48, 13);
            this.lblFilterStruktura.TabIndex = 6;
            this.lblFilterStruktura.Text = "Struktura";
            // 
            // cmbFilterStruktura
            // 
            this.cmbFilterStruktura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStruktura.FormattingEnabled = true;
            this.cmbFilterStruktura.Location = new System.Drawing.Point(870, 12);
            this.cmbFilterStruktura.Name = "cmbFilterStruktura";
            this.cmbFilterStruktura.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterStruktura.TabIndex = 7;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(870, 39);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(85, 23);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(965, 39);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(85, 23);
            this.btnResetFilter.TabIndex = 9;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // dgvNekretnine
            // 
            this.dgvNekretnine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNekretnine.Location = new System.Drawing.Point(12, 75);
            this.dgvNekretnine.Name = "dgvNekretnine";
            this.dgvNekretnine.Size = new System.Drawing.Size(1038, 350);
            this.dgvNekretnine.TabIndex = 10;
            this.dgvNekretnine.SelectionChanged += new System.EventHandler(this.dgvNekretnine_SelectionChanged);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(12, 431);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNovi.TabIndex = 11;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(93, 431);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 12;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(174, 431);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblAktuelnaCenaTitle
            // 
            this.lblAktuelnaCenaTitle.AutoSize = true;
            this.lblAktuelnaCenaTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAktuelnaCenaTitle.Location = new System.Drawing.Point(759, 433);
            this.lblAktuelnaCenaTitle.Name = "lblAktuelnaCenaTitle";
            this.lblAktuelnaCenaTitle.Size = new System.Drawing.Size(99, 19);
            this.lblAktuelnaCenaTitle.TabIndex = 14;
            this.lblAktuelnaCenaTitle.Text = "Aktuelna cena:";
            // 
            // lblAktuelnaCenaValue
            // 
            this.lblAktuelnaCenaValue.AutoSize = true;
            this.lblAktuelnaCenaValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAktuelnaCenaValue.Location = new System.Drawing.Point(864, 433);
            this.lblAktuelnaCenaValue.Name = "lblAktuelnaCenaValue";
            this.lblAktuelnaCenaValue.Size = new System.Drawing.Size(118, 19);
            this.lblAktuelnaCenaValue.TabIndex = 15;
            this.lblAktuelnaCenaValue.Text = "Nema aktivne cene";
            // 
            // NekretninaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 466);
            this.Controls.Add(this.lblAktuelnaCenaValue);
            this.Controls.Add(this.lblAktuelnaCenaTitle);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.dgvNekretnine);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cmbFilterStruktura);
            this.Controls.Add(this.lblFilterStruktura);
            this.Controls.Add(this.cmbFilterKategorija);
            this.Controls.Add(this.lblFilterKategorija);
            this.Controls.Add(this.cmbFilterGrad);
            this.Controls.Add(this.lblFilterGrad);
            this.Controls.Add(this.cmbFilterProjekat);
            this.Controls.Add(this.lblFilterProjekat);
            this.Name = "NekretninaForm";
            this.Text = "Upravljanje nekretninama";
            this.Load += new System.EventHandler(this.NekretninaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFilterProjekat;
        private System.Windows.Forms.ComboBox cmbFilterProjekat;
        private System.Windows.Forms.Label lblFilterGrad;
        private System.Windows.Forms.ComboBox cmbFilterGrad;
        private System.Windows.Forms.Label lblFilterKategorija;
        private System.Windows.Forms.ComboBox cmbFilterKategorija;
        private System.Windows.Forms.Label lblFilterStruktura;
        private System.Windows.Forms.ComboBox cmbFilterStruktura;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvNekretnine;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblAktuelnaCenaTitle;
        private System.Windows.Forms.Label lblAktuelnaCenaValue;
    }
}
