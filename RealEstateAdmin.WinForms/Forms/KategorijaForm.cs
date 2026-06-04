using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class KategorijaForm : Form
    {
        private readonly KategorijaService _kategorijaService = new KategorijaService();

        public KategorijaForm()
        {
            InitializeComponent();
        }

        private void KategorijaForm_Load(object sender, EventArgs e)
        {
            LoadKategorije();
        }

        private void LoadKategorije()
        {
            try
            {
                dgvKategorije.DataSource = _kategorijaService.GetAll();
                dgvKategorije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvKategorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKategorije.MultiSelect = false;

                if (dgvKategorije.Columns["KategorijaID"] != null)
                {
                    dgvKategorije.Columns["KategorijaID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju kategorija: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new KategorijaEditForm())
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadKategorije();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za unos kategorije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKategorije.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite kategoriju koju želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvKategorije.SelectedRows[0];
                var kategorija = new KategorijaDTO
                {
                    KategorijaID = (int)selectedRow.Cells["KategorijaID"].Value,
                    Naziv = selectedRow.Cells["Naziv"].Value?.ToString(),
                    Opis = selectedRow.Cells["Opis"].Value?.ToString()
                };

                using (var form = new KategorijaEditForm(kategorija))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadKategorije();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za izmenu kategorije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKategorije.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite kategoriju koju želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int kategorijaId = (int)dgvKategorije.SelectedRows[0].Cells["KategorijaID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabranu kategoriju?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _kategorijaService.Delete(kategorijaId);
                    LoadKategorije();
                    MessageBox.Show("Kategorija je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju kategorije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
