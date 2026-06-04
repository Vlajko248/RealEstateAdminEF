using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class ProjekatForm : Form
    {
        private readonly ProjekatService _projekatService = new ProjekatService();

        public ProjekatForm()
        {
            InitializeComponent();
        }

        private void ProjekatForm_Load(object sender, EventArgs e)
        {
            LoadProjekti();
        }

        private void LoadProjekti()
        {
            try
            {
                dgvProjekti.DataSource = _projekatService.GetAll();
                dgvProjekti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvProjekti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProjekti.MultiSelect = false;

                if (dgvProjekti.Columns["ProjekatID"] != null)
                {
                    dgvProjekti.Columns["ProjekatID"].Visible = false;
                }

                if (dgvProjekti.Columns["GradID"] != null)
                {
                    dgvProjekti.Columns["GradID"].Visible = false;
                }

                if (dgvProjekti.Columns["GradNaziv"] != null)
                {
                    dgvProjekti.Columns["GradNaziv"].HeaderText = "Grad";
                    dgvProjekti.Columns["GradNaziv"].DisplayIndex = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju projekata: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ProjekatEditForm())
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadProjekti();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za unos projekta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjekti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite projekat koji želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvProjekti.SelectedRows[0];
                var projekat = new ProjekatDTO
                {
                    ProjekatID = (int)selectedRow.Cells["ProjekatID"].Value,
                    Naziv = selectedRow.Cells["Naziv"].Value?.ToString(),
                    Adresa = selectedRow.Cells["Adresa"].Value?.ToString(),
                    GradID = (int)selectedRow.Cells["GradID"].Value,
                    Opis = selectedRow.Cells["Opis"].Value?.ToString()
                };

                using (var form = new ProjekatEditForm(projekat))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadProjekti();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za izmenu projekta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjekti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite projekat koji želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int projekatId = (int)dgvProjekti.SelectedRows[0].Cells["ProjekatID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabrani projekat?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _projekatService.Delete(projekatId);
                    LoadProjekti();
                    MessageBox.Show("Projekat je uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju projekta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
