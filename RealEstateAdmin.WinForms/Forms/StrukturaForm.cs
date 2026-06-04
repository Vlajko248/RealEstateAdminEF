using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class StrukturaForm : Form
    {
        private readonly StrukturaService _strukturaService = new StrukturaService();

        public StrukturaForm()
        {
            InitializeComponent();
        }

        private void StrukturaForm_Load(object sender, EventArgs e)
        {
            LoadStrukture();
        }

        private void LoadStrukture()
        {
            try
            {
                dgvStrukture.DataSource = _strukturaService.GetAll();
                dgvStrukture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvStrukture.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvStrukture.MultiSelect = false;

                if (dgvStrukture.Columns["StrukturaID"] != null)
                {
                    dgvStrukture.Columns["StrukturaID"].Visible = false;
                }

                if (dgvStrukture.Columns["KategorijaID"] != null)
                {
                    dgvStrukture.Columns["KategorijaID"].Visible = false;
                }

                if (dgvStrukture.Columns["KategorijaNaziv"] != null)
                {
                    dgvStrukture.Columns["KategorijaNaziv"].HeaderText = "Kategorija";
                    dgvStrukture.Columns["KategorijaNaziv"].DisplayIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju struktura: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new StrukturaEditForm())
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadStrukture();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za unos strukture: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStrukture.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite strukturu koju želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvStrukture.SelectedRows[0];
                var struktura = new StrukturaDTO
                {
                    StrukturaID = (int)selectedRow.Cells["StrukturaID"].Value,
                    KategorijaID = (int)selectedRow.Cells["KategorijaID"].Value,
                    Naziv = selectedRow.Cells["Naziv"].Value?.ToString(),
                    Opis = selectedRow.Cells["Opis"].Value?.ToString()
                };

                using (var form = new StrukturaEditForm(struktura))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadStrukture();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za izmenu strukture: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStrukture.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite strukturu koju želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int strukturaId = (int)dgvStrukture.SelectedRows[0].Cells["StrukturaID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabranu strukturu?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _strukturaService.Delete(strukturaId);
                    LoadStrukture();
                    MessageBox.Show("Struktura je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju strukture: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

