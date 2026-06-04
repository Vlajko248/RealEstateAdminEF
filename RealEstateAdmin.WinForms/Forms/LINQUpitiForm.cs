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
                MessageBox.Show($"Greška pri izvršavanju LINQ upita: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLinqUpiti()
        {
            var rezultat = _nekretninaService.GetNekretnineCenaLeftJoin();

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

            if (dgvLinqUpiti.Columns["Iznos"] != null)
            {
                dgvLinqUpiti.Columns["Iznos"].HeaderText = "Iznos (RSD)";
                dgvLinqUpiti.Columns["Iznos"].DefaultCellStyle.Format = "N2";
            }

            if (dgvLinqUpiti.Columns["DatumOd"] != null)
            {
                dgvLinqUpiti.Columns["DatumOd"].HeaderText = "Datum od";
                dgvLinqUpiti.Columns["DatumOd"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvLinqUpiti.Columns["DatumDo"] != null)
            {
                dgvLinqUpiti.Columns["DatumDo"].HeaderText = "Datum do";
                dgvLinqUpiti.Columns["DatumDo"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvLinqUpiti.Columns["CenaAktivna"] != null)
                dgvLinqUpiti.Columns["CenaAktivna"].HeaderText = "Cena aktivna";

            lblBrojZapisa.Text = $"Ukupno zapisa: {rezultat.Count}";
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
