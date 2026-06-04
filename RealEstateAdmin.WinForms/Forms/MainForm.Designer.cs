namespace RealEstateAdmin.WinForms
{
    partial class MainForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnLinqUpiti = new System.Windows.Forms.Button();
            this.btnNekretnine = new System.Windows.Forms.Button();
            this.btnStrukture = new System.Windows.Forms.Button();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.btnProjekti = new System.Windows.Forms.Button();
            this.btnGradovi = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpMaster = new System.Windows.Forms.GroupBox();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.pnlDetailsBtns = new System.Windows.Forms.Panel();
            this.btnObrisiCenu = new System.Windows.Forms.Button();
            this.btnIzmeniCenu = new System.Windows.Forms.Button();
            this.btnDodajCenu = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.pnlDetailsBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlMenu.Controls.Add(this.btnIzlaz);
            this.pnlMenu.Controls.Add(this.btnLinqUpiti);
            this.pnlMenu.Controls.Add(this.btnNekretnine);
            this.pnlMenu.Controls.Add(this.btnStrukture);
            this.pnlMenu.Controls.Add(this.btnKategorije);
            this.pnlMenu.Controls.Add(this.btnProjekti);
            this.pnlMenu.Controls.Add(this.btnGradovi);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 861);
            this.pnlMenu.TabIndex = 0;
            //
            // btnIzlaz
            //
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnIzlaz.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz.Location = new System.Drawing.Point(0, 809);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnIzlaz.Size = new System.Drawing.Size(260, 52);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            //
            // btnLinqUpiti
            //
            this.btnLinqUpiti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinqUpiti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLinqUpiti.FlatAppearance.BorderSize = 0;
            this.btnLinqUpiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinqUpiti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLinqUpiti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.btnLinqUpiti.Location = new System.Drawing.Point(0, 350);
            this.btnLinqUpiti.Name = "btnLinqUpiti";
            this.btnLinqUpiti.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLinqUpiti.Size = new System.Drawing.Size(260, 52);
            this.btnLinqUpiti.TabIndex = 6;
            this.btnLinqUpiti.Text = "LINQ Upiti";
            this.btnLinqUpiti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinqUpiti.UseVisualStyleBackColor = false;
            this.btnLinqUpiti.Click += new System.EventHandler(this.btnLinqUpiti_Click);
            //
            // btnNekretnine
            //
            this.btnNekretnine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNekretnine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNekretnine.FlatAppearance.BorderSize = 0;
            this.btnNekretnine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNekretnine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNekretnine.ForeColor = System.Drawing.Color.White;
            this.btnNekretnine.Location = new System.Drawing.Point(0, 298);
            this.btnNekretnine.Name = "btnNekretnine";
            this.btnNekretnine.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNekretnine.Size = new System.Drawing.Size(260, 52);
            this.btnNekretnine.TabIndex = 5;
            this.btnNekretnine.Text = "Nekretnine";
            this.btnNekretnine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNekretnine.UseVisualStyleBackColor = false;
            this.btnNekretnine.Click += new System.EventHandler(this.btnNekretnine_Click);
            //
            // btnStrukture
            //
            this.btnStrukture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStrukture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStrukture.FlatAppearance.BorderSize = 0;
            this.btnStrukture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrukture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStrukture.ForeColor = System.Drawing.Color.White;
            this.btnStrukture.Location = new System.Drawing.Point(0, 246);
            this.btnStrukture.Name = "btnStrukture";
            this.btnStrukture.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnStrukture.Size = new System.Drawing.Size(260, 52);
            this.btnStrukture.TabIndex = 4;
            this.btnStrukture.Text = "Strukture";
            this.btnStrukture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStrukture.UseVisualStyleBackColor = false;
            this.btnStrukture.Click += new System.EventHandler(this.btnStrukture_Click);
            //
            // btnKategorije
            //
            this.btnKategorije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKategorije.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategorije.FlatAppearance.BorderSize = 0;
            this.btnKategorije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategorije.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKategorije.ForeColor = System.Drawing.Color.White;
            this.btnKategorije.Location = new System.Drawing.Point(0, 194);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnKategorije.Size = new System.Drawing.Size(260, 52);
            this.btnKategorije.TabIndex = 3;
            this.btnKategorije.Text = "Kategorije";
            this.btnKategorije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategorije.UseVisualStyleBackColor = false;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            //
            // btnProjekti
            //
            this.btnProjekti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjekti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjekti.FlatAppearance.BorderSize = 0;
            this.btnProjekti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjekti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProjekti.ForeColor = System.Drawing.Color.White;
            this.btnProjekti.Location = new System.Drawing.Point(0, 142);
            this.btnProjekti.Name = "btnProjekti";
            this.btnProjekti.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnProjekti.Size = new System.Drawing.Size(260, 52);
            this.btnProjekti.TabIndex = 2;
            this.btnProjekti.Text = "Projekti";
            this.btnProjekti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjekti.UseVisualStyleBackColor = false;
            this.btnProjekti.Click += new System.EventHandler(this.btnProjekti_Click);
            //
            // btnGradovi
            //
            this.btnGradovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGradovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGradovi.FlatAppearance.BorderSize = 0;
            this.btnGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradovi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGradovi.ForeColor = System.Drawing.Color.White;
            this.btnGradovi.Location = new System.Drawing.Point(0, 90);
            this.btnGradovi.Name = "btnGradovi";
            this.btnGradovi.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnGradovi.Size = new System.Drawing.Size(260, 52);
            this.btnGradovi.TabIndex = 1;
            this.btnGradovi.Text = "Gradovi";
            this.btnGradovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGradovi.UseVisualStyleBackColor = false;
            this.btnGradovi.Click += new System.EventHandler(this.btnGradovi_Click);
            //
            // pnlLogo
            //
            this.pnlLogo.Controls.Add(this.lblAppTitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 90);
            this.pnlLogo.TabIndex = 0;
            //
            // lblAppTitle
            //
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(260, 90);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "RealEstate Admin\r\nLINQ to SQL";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlTopBar
            //
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlTopBar.Controls.Add(this.lblSectionTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 60);
            this.pnlTopBar.TabIndex = 1;
            //
            // lblSectionTitle
            //
            this.lblSectionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(24, 0);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(1316, 60);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "Nekretnine → Cene   (Master - Details)";
            this.lblSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlContent
            //
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContent.Size = new System.Drawing.Size(1340, 801);
            this.pnlContent.TabIndex = 2;
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.grpMaster);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.grpDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 777);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 0;
            //
            // grpMaster
            //
            this.grpMaster.Controls.Add(this.dgvMaster);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpMaster.Location = new System.Drawing.Point(0, 0);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Padding = new System.Windows.Forms.Padding(8);
            this.grpMaster.Size = new System.Drawing.Size(1316, 370);
            this.grpMaster.TabIndex = 0;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Nekretnine  (Master)";
            //
            // dgvMaster
            //
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            this.dgvMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMaster.Location = new System.Drawing.Point(8, 21);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.RowHeadersVisible = false;
            this.dgvMaster.Size = new System.Drawing.Size(1300, 341);
            this.dgvMaster.TabIndex = 0;
            this.dgvMaster.SelectionChanged += new System.EventHandler(this.dgvMaster_SelectionChanged);
            //
            // grpDetails
            //
            this.grpDetails.Controls.Add(this.dgvDetails);
            this.grpDetails.Controls.Add(this.pnlDetailsBtns);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(0, 0);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(8);
            this.grpDetails.Size = new System.Drawing.Size(1316, 403);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Cene za izabranu nekretninu  (Details)";
            //
            // pnlDetailsBtns
            //
            this.pnlDetailsBtns.Controls.Add(this.btnObrisiCenu);
            this.pnlDetailsBtns.Controls.Add(this.btnIzmeniCenu);
            this.pnlDetailsBtns.Controls.Add(this.btnDodajCenu);
            this.pnlDetailsBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetailsBtns.Location = new System.Drawing.Point(8, 351);
            this.pnlDetailsBtns.Name = "pnlDetailsBtns";
            this.pnlDetailsBtns.Size = new System.Drawing.Size(1300, 44);
            this.pnlDetailsBtns.TabIndex = 1;
            //
            // btnObrisiCenu
            //
            this.btnObrisiCenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnObrisiCenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiCenu.FlatAppearance.BorderSize = 0;
            this.btnObrisiCenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiCenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnObrisiCenu.ForeColor = System.Drawing.Color.White;
            this.btnObrisiCenu.Location = new System.Drawing.Point(284, 6);
            this.btnObrisiCenu.Name = "btnObrisiCenu";
            this.btnObrisiCenu.Size = new System.Drawing.Size(130, 32);
            this.btnObrisiCenu.TabIndex = 2;
            this.btnObrisiCenu.Text = "Obriši cenu";
            this.btnObrisiCenu.UseVisualStyleBackColor = false;
            this.btnObrisiCenu.Click += new System.EventHandler(this.btnObrisiCenu_Click);
            //
            // btnIzmeniCenu
            //
            this.btnIzmeniCenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnIzmeniCenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeniCenu.FlatAppearance.BorderSize = 0;
            this.btnIzmeniCenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniCenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIzmeniCenu.ForeColor = System.Drawing.Color.White;
            this.btnIzmeniCenu.Location = new System.Drawing.Point(146, 6);
            this.btnIzmeniCenu.Name = "btnIzmeniCenu";
            this.btnIzmeniCenu.Size = new System.Drawing.Size(130, 32);
            this.btnIzmeniCenu.TabIndex = 1;
            this.btnIzmeniCenu.Text = "Izmeni cenu";
            this.btnIzmeniCenu.UseVisualStyleBackColor = false;
            this.btnIzmeniCenu.Click += new System.EventHandler(this.btnIzmeniCenu_Click);
            //
            // btnDodajCenu
            //
            this.btnDodajCenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnDodajCenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajCenu.FlatAppearance.BorderSize = 0;
            this.btnDodajCenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajCenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDodajCenu.ForeColor = System.Drawing.Color.White;
            this.btnDodajCenu.Location = new System.Drawing.Point(8, 6);
            this.btnDodajCenu.Name = "btnDodajCenu";
            this.btnDodajCenu.Size = new System.Drawing.Size(130, 32);
            this.btnDodajCenu.TabIndex = 0;
            this.btnDodajCenu.Text = "Dodaj cenu";
            this.btnDodajCenu.UseVisualStyleBackColor = false;
            this.btnDodajCenu.Click += new System.EventHandler(this.btnDodajCenu_Click);
            //
            // dgvDetails
            //
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetails.Location = new System.Drawing.Point(8, 21);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.Size = new System.Drawing.Size(1300, 330);
            this.dgvDetails.TabIndex = 0;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 861);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealEstate Admin - LINQ to SQL";
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.pnlDetailsBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnGradovi;
        private System.Windows.Forms.Button btnProjekti;
        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.Button btnStrukture;
        private System.Windows.Forms.Button btnNekretnine;
        private System.Windows.Forms.Button btnLinqUpiti;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpMaster;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Panel pnlDetailsBtns;
        private System.Windows.Forms.Button btnDodajCenu;
        private System.Windows.Forms.Button btnIzmeniCenu;
        private System.Windows.Forms.Button btnObrisiCenu;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}
