using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class GradForm : Form
    {
        private readonly GradService _gradService = new GradService();

        public GradForm()
        {
            InitializeComponent();
        }

        private void GradForm_Load(object sender, EventArgs e)
        {
            LoadGradovi();
        }

        private void LoadGradovi()
        {
            try
            {
                var gradovi = _gradService.GetAll();
                dgvGradovi.DataSource = gradovi;
                dgvGradovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvGradovi.MultiSelect = false;

                if (dgvGradovi.Columns["GradID"] != null)
                {
                    dgvGradovi.Columns["GradID"].Visible = false;
                }

                if (dgvGradovi.Columns["PostanskiBroj"] != null)
                {
                    dgvGradovi.Columns["PostanskiBroj"].HeaderText = "Poštanski Broj";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju gradova: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new GradEditForm())
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadGradovi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za unos grada: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGradovi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite grad koji želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvGradovi.SelectedRows[0];
                var grad = new GradDTO
                {
                    GradID = (int)selectedRow.Cells["GradID"].Value,
                    Naziv = selectedRow.Cells["Naziv"].Value?.ToString(),
                    PostanskiBroj = selectedRow.Cells["PostanskiBroj"].Value?.ToString()
                };

                using (var form = new GradEditForm(grad))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadGradovi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za izmenu grada: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGradovi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite grad koji želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int gradId = (int)dgvGradovi.SelectedRows[0].Cells["GradID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabrani grad?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _gradService.Delete(gradId);
                    LoadGradovi();
                    MessageBox.Show("Grad je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju grada: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
