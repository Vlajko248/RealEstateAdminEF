using System;
using System.Drawing;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class MainForm : Form
    {
        private readonly NekretninaService _nekretninaService = new NekretninaService();
        private readonly CenaService _cenaService = new CenaService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaster()
        {
            dgvMaster.DataSource = null;
            dgvMaster.DataSource = _nekretninaService.GetAll();
            dgvMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaster.MultiSelect = false;
            dgvMaster.ReadOnly = true;

            HideColumn(dgvMaster, "NekretninaID");
            HideColumn(dgvMaster, "ProjekatID");
            HideColumn(dgvMaster, "KategorijaID");
            HideColumn(dgvMaster, "StrukturaID");

            SetHeader(dgvMaster, "ProjekatNaziv", "Projekat");
            SetHeader(dgvMaster, "KategorijaNaziv", "Kategorija");
            SetHeader(dgvMaster, "StrukturaNaziv", "Struktura");

            if (dgvMaster.Columns["Kvadratura"] != null)
                dgvMaster.Columns["Kvadratura"].DefaultCellStyle.Format = "N2";

            LoadDetails();
        }

        private void LoadDetails()
        {
            int nekretninaId = GetSelectedNekretninaId();

            if (nekretninaId <= 0)
            {
                dgvDetails.DataSource = null;
                return;
            }

            try
            {
                dgvDetails.DataSource = null;
                dgvDetails.DataSource = _cenaService.GetByNekretninaId(nekretninaId);
                dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDetails.MultiSelect = false;
                dgvDetails.ReadOnly = true;

                HideColumn(dgvDetails, "CenaID");
                HideColumn(dgvDetails, "NekretninaID");
                HideColumn(dgvDetails, "NekretninaNaziv");

                if (dgvDetails.Columns["Iznos"] != null)
                    dgvDetails.Columns["Iznos"].DefaultCellStyle.Format = "N2";

                if (dgvDetails.Columns["DatumOd"] != null)
                {
                    dgvDetails.Columns["DatumOd"].HeaderText = "Datum od";
                    dgvDetails.Columns["DatumOd"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                if (dgvDetails.Columns["DatumDo"] != null)
                {
                    dgvDetails.Columns["DatumDo"].HeaderText = "Datum do";
                    dgvDetails.Columns["DatumDo"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju cena: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedNekretninaId()
        {
            if (dgvMaster.SelectedRows.Count == 0 || dgvMaster.Columns["NekretninaID"] == null)
                return 0;

            var val = dgvMaster.SelectedRows[0].Cells["NekretninaID"].Value;
            return val is int id ? id : 0;
        }

        private void dgvMaster_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju cena: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajCenu_Click(object sender, EventArgs e)
        {
            try
            {
                int nekretninaId = GetSelectedNekretninaId();

                if (nekretninaId <= 0)
                {
                    MessageBox.Show("Izaberite nekretninu za koju dodajete cenu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var novaCena = new CenaDTO { NekretninaID = nekretninaId };

                using (var form = new CenaEditForm(novaCena))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                        LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju cene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeniCenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Izaberite cenu koju želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = dgvDetails.SelectedRows[0];
                var cena = new CenaDTO
                {
                    CenaID = (int)row.Cells["CenaID"].Value,
                    NekretninaID = (int)row.Cells["NekretninaID"].Value,
                    Iznos = (decimal)row.Cells["Iznos"].Value,
                    DatumOd = (DateTime)row.Cells["DatumOd"].Value,
                    DatumDo = (DateTime)row.Cells["DatumDo"].Value,
                    Aktivna = (bool)row.Cells["Aktivna"].Value
                };

                using (var form = new CenaEditForm(cena))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                        LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri izmeni cene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisiCenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Izaberite cenu koju želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cenaId = (int)dgvDetails.SelectedRows[0].Cells["CenaID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabranu cenu?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _cenaService.Delete(cenaId);
                    LoadDetails();
                    MessageBox.Show("Cena je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju cene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGradovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new GradForm())
                    form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProjekti_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ProjekatForm())
                    form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new KategorijaForm())
                    form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStrukture_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new StrukturaForm())
                    form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNekretnine_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new NekretninaForm())
                    form.ShowDialog(this);

                LoadMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLinqUpiti_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new LINQUpitiForm())
                    form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static void HideColumn(DataGridView dgv, string columnName)
        {
            if (dgv.Columns[columnName] != null)
                dgv.Columns[columnName].Visible = false;
        }

        private static void SetHeader(DataGridView dgv, string columnName, string header)
        {
            if (dgv.Columns[columnName] != null)
                dgv.Columns[columnName].HeaderText = header;
        }
    }
}
