namespace RealEstateAdmin.WinForms
{
    partial class CenaEditForm
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
            this.lblNekretnina = new System.Windows.Forms.Label();
            this.cmbNekretnina = new System.Windows.Forms.ComboBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.chkAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNekretnina
            // 
            this.lblNekretnina.AutoSize = true;
            this.lblNekretnina.Location = new System.Drawing.Point(12, 15);
            this.lblNekretnina.Name = "lblNekretnina";
            this.lblNekretnina.Size = new System.Drawing.Size(58, 13);
            this.lblNekretnina.TabIndex = 0;
            this.lblNekretnina.Text = "Nekretnina";
            // 
            // cmbNekretnina
            // 
            this.cmbNekretnina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNekretnina.FormattingEnabled = true;
            this.cmbNekretnina.Location = new System.Drawing.Point(92, 12);
            this.cmbNekretnina.Name = "cmbNekretnina";
            this.cmbNekretnina.Size = new System.Drawing.Size(260, 21);
            this.cmbNekretnina.TabIndex = 1;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(12, 42);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(34, 13);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "Iznos";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(92, 39);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(260, 20);
            this.txtIznos.TabIndex = 3;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(12, 68);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(55, 13);
            this.lblDatumOd.TabIndex = 4;
            this.lblDatumOd.Text = "Datum od";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumOd.Location = new System.Drawing.Point(92, 65);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(260, 20);
            this.dtpDatumOd.TabIndex = 5;
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(12, 94);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(54, 13);
            this.lblDatumDo.TabIndex = 6;
            this.lblDatumDo.Text = "Datum do";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumDo.Location = new System.Drawing.Point(92, 91);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(260, 20);
            this.dtpDatumDo.TabIndex = 7;
            // 
            // chkAktivna
            // 
            this.chkAktivna.AutoSize = true;
            this.chkAktivna.Location = new System.Drawing.Point(92, 117);
            this.chkAktivna.Name = "chkAktivna";
            this.chkAktivna.Size = new System.Drawing.Size(62, 17);
            this.chkAktivna.TabIndex = 8;
            this.chkAktivna.Text = "Aktivna";
            this.chkAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(196, 149);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(277, 149);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // CenaEditForm
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(372, 188);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.chkAktivna);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.cmbNekretnina);
            this.Controls.Add(this.lblNekretnina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CenaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cena";
            this.Load += new System.EventHandler(this.CenaEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNekretnina;
        private System.Windows.Forms.ComboBox cmbNekretnina;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.CheckBox chkAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}
