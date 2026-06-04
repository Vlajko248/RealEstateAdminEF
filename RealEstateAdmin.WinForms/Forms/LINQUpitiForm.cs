using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;

namespace RealEstateAdmin.WinForms
{
    public partial class LINQUpitiForm : Form
    {
        private readonly NekretninaService _nekretninaService = new NekretninaService();

        public LINQUpitiForm()
        {
            InitializeComponent();
        }

        private void LINQUpitiForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLinqUpiti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri izvršavanju upita: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLinqUpiti()
        {
            var rezultat = _nekretninaService.GetNekretninaCenaStat();

            dgvLinqUpiti.DataSource = null;
            dgvLinqUpiti.DataSource = rezultat;
            dgvLinqUpiti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLinqUpiti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLinqUpiti.MultiSelect = false;
            dgvLinqUpiti.ReadOnly = true;

            if (dgvLinqUpiti.Columns["Sifra"] != null)
                dgvLinqUpiti.Columns["Sifra"].HeaderText = "Šifra";

            if (dgvLinqUpiti.Columns["NekretninaNaziv"] != null)
                dgvLinqUpiti.Columns["NekretninaNaziv"].HeaderText = "Nekretnina";

            if (dgvLinqUpiti.Columns["ProjekatNaziv"] != null)
                dgvLinqUpiti.Columns["ProjekatNaziv"].HeaderText = "Projekat";

            if (dgvLinqUpiti.Columns["BrojCena"] != null)
                dgvLinqUpiti.Columns["BrojCena"].HeaderText = "Broj cena";

            if (dgvLinqUpiti.Columns["MinIznos"] != null)
            {
                dgvLinqUpiti.Columns["MinIznos"].HeaderText = "Min iznos (RSD)";
                dgvLinqUpiti.Columns["MinIznos"].DefaultCellStyle.Format = "N2";
            }

            if (dgvLinqUpiti.Columns["MaxIznos"] != null)
            {
                dgvLinqUpiti.Columns["MaxIznos"].HeaderText = "Max iznos (RSD)";
                dgvLinqUpiti.Columns["MaxIznos"].DefaultCellStyle.Format = "N2";
            }

            if (dgvLinqUpiti.Columns["UkupnoIznos"] != null)
            {
                dgvLinqUpiti.Columns["UkupnoIznos"].HeaderText = "Ukupno (RSD)";
                dgvLinqUpiti.Columns["UkupnoIznos"].DefaultCellStyle.Format = "N2";
            }

            lblBrojZapisa.Text = $"Ukupno nekretnina: {rezultat.Count}";
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
