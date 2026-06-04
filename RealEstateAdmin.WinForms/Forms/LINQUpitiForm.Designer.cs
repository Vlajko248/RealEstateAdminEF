namespace RealEstateAdmin.WinForms
{
    partial class LINQUpitiForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblBrojZapisa = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvLinqUpiti = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinqUpiti)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlTop.Controls.Add(this.lblOpis);
            this.pnlTop.Controls.Add(this.lblNaslov);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.pnlTop.Size = new System.Drawing.Size(1200, 80);
            this.pnlTop.TabIndex = 0;
            //
            // lblNaslov
            //
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(16, 8);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "LINQ Upit - LEFT OUTER JOIN: Nekretnine i Cene";
            //
            // lblOpis
            //
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblOpis.Location = new System.Drawing.Point(16, 38);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Prikazuje sve nekretnine i njihove cene (uključujući nekretnine bez cena)  •  Realizovano LINQ to SQL LEFT OUTER JOIN upitom";
            //
            // pnlBottom
            //
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnZatvori);
            this.pnlBottom.Controls.Add(this.lblBrojZapisa);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 618);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.pnlBottom.Size = new System.Drawing.Size(1200, 52);
            this.pnlBottom.TabIndex = 1;
            //
            // lblBrojZapisa
            //
            this.lblBrojZapisa.AutoSize = true;
            this.lblBrojZapisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBrojZapisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblBrojZapisa.Location = new System.Drawing.Point(16, 16);
            this.lblBrojZapisa.Name = "lblBrojZapisa";
            this.lblBrojZapisa.TabIndex = 0;
            this.lblBrojZapisa.Text = "Ukupno zapisa: 0";
            //
            // btnZatvori
            //
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(1076, 8);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(108, 34);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            //
            // dgvLinqUpiti
            //
            this.dgvLinqUpiti.AllowUserToAddRows = false;
            this.dgvLinqUpiti.AllowUserToDeleteRows = false;
            this.dgvLinqUpiti.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinqUpiti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLinqUpiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinqUpiti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLinqUpiti.Location = new System.Drawing.Point(0, 80);
            this.dgvLinqUpiti.Name = "dgvLinqUpiti";
            this.dgvLinqUpiti.RowHeadersVisible = false;
            this.dgvLinqUpiti.Size = new System.Drawing.Size(1200, 538);
            this.dgvLinqUpiti.TabIndex = 2;
            //
            // LINQUpitiForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.dgvLinqUpiti);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.LINQUpitiForm_Load);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "LINQUpitiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LINQ Upiti - Nekretnine i Cene";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinqUpiti)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblBrojZapisa;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvLinqUpiti;
    }
}
