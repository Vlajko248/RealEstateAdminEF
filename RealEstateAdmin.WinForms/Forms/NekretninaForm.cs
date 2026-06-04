using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class NekretninaForm : Form
    {
        private readonly NekretninaService _nekretninaService = new NekretninaService();
        private readonly ProjekatService _projekatService = new ProjekatService();
        private readonly GradService _gradService = new GradService();
        private readonly KategorijaService _kategorijaService = new KategorijaService();
        private readonly StrukturaService _strukturaService = new StrukturaService();
        private readonly CenaService _cenaService = new CenaService();

        private List<NekretninaDTO> _allNekretnine = new List<NekretninaDTO>();
        private List<ProjekatDTO> _allProjekti = new List<ProjekatDTO>();
        private List<StrukturaDTO> _allStrukture = new List<StrukturaDTO>();

        public NekretninaForm()
        {
            InitializeComponent();
        }

        private void NekretninaForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFilterData();
                LoadNekretnine();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju nekretnina: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFilterData()
        {
            _allProjekti = _projekatService.GetAll();
            _allStrukture = _strukturaService.GetAll();

            var projekti = new List<ProjekatDTO> { new ProjekatDTO { ProjekatID = 0, Naziv = "All" } };
            projekti.AddRange(_allProjekti);
            cmbFilterProjekat.DisplayMember = "Naziv";
            cmbFilterProjekat.ValueMember = "ProjekatID";
            cmbFilterProjekat.DataSource = projekti;

            var gradovi = new List<GradDTO> { new GradDTO { GradID = 0, Naziv = "All" } };
            gradovi.AddRange(_gradService.GetAll());
            cmbFilterGrad.DisplayMember = "Naziv";
            cmbFilterGrad.ValueMember = "GradID";
            cmbFilterGrad.DataSource = gradovi;

            var kategorije = new List<KategorijaDTO> { new KategorijaDTO { KategorijaID = 0, Naziv = "All" } };
            kategorije.AddRange(_kategorijaService.GetAll());
            cmbFilterKategorija.DisplayMember = "Naziv";
            cmbFilterKategorija.ValueMember = "KategorijaID";
            cmbFilterKategorija.DataSource = kategorije;

            LoadStruktureFilterByKategorija();

            cmbFilterProjekat.SelectedValue = 0;
            cmbFilterGrad.SelectedValue = 0;
            cmbFilterKategorija.SelectedValue = 0;
            cmbFilterStruktura.SelectedValue = 0;
        }

        private void LoadStruktureFilterByKategorija()
        {
            int kategorijaId = GetSelectedId(cmbFilterKategorija);

            var filtered = _allStrukture
                .Where(x => kategorijaId == 0 || x.KategorijaID == kategorijaId)
                .ToList();

            var strukture = new List<StrukturaDTO>
            {
                new StrukturaDTO { StrukturaID = 0, KategorijaID = 0, Naziv = "All" }
            };
            strukture.AddRange(filtered);

            int currentSelectedId = GetSelectedId(cmbFilterStruktura);

            cmbFilterStruktura.DisplayMember = "Naziv";
            cmbFilterStruktura.ValueMember = "StrukturaID";
            cmbFilterStruktura.DataSource = strukture;

            if (strukture.Any(x => x.StrukturaID == currentSelectedId))
            {
                cmbFilterStruktura.SelectedValue = currentSelectedId;
            }
            else
            {
                cmbFilterStruktura.SelectedValue = 0;
            }
        }

        private void LoadNekretnine()
        {
            _allNekretnine = _nekretninaService.GetAll();
            BindNekretnine(_allNekretnine);
        }

        private void BindNekretnine(List<NekretninaDTO> nekretnine)
        {
            dgvNekretnine.DataSource = null;
            dgvNekretnine.DataSource = nekretnine;
            dgvNekretnine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNekretnine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNekretnine.MultiSelect = false;

            if (dgvNekretnine.Columns["NekretninaID"] != null)
            {
                dgvNekretnine.Columns["NekretninaID"].Visible = false;
            }

            if (dgvNekretnine.Columns["ProjekatID"] != null)
            {
                dgvNekretnine.Columns["ProjekatID"].Visible = false;
            }

            if (dgvNekretnine.Columns["KategorijaID"] != null)
            {
                dgvNekretnine.Columns["KategorijaID"].Visible = false;
            }

            if (dgvNekretnine.Columns["StrukturaID"] != null)
            {
                dgvNekretnine.Columns["StrukturaID"].Visible = false;
            }

            if (dgvNekretnine.Columns["ProjekatNaziv"] != null)
            {
                dgvNekretnine.Columns["ProjekatNaziv"].HeaderText = "Projekat";
                dgvNekretnine.Columns["ProjekatNaziv"].DisplayIndex = 1;
            }

            if (dgvNekretnine.Columns["KategorijaNaziv"] != null)
            {
                dgvNekretnine.Columns["KategorijaNaziv"].HeaderText = "Kategorija";
                dgvNekretnine.Columns["KategorijaNaziv"].DisplayIndex = 2;
            }

            if (dgvNekretnine.Columns["StrukturaNaziv"] != null)
            {
                dgvNekretnine.Columns["StrukturaNaziv"].HeaderText = "Struktura";
                dgvNekretnine.Columns["StrukturaNaziv"].DisplayIndex = 3;
            }

            if (dgvNekretnine.Columns["Kvadratura"] != null)
            {
                dgvNekretnine.Columns["Kvadratura"].DefaultCellStyle.Format = "N2";
            }

            ShowAktuelnaCenaForSelectedNekretnina();
        }

        private List<NekretninaDTO> ApplyFilters()
        {
            int projekatId = GetSelectedId(cmbFilterProjekat);
            int gradId = GetSelectedId(cmbFilterGrad);
            int kategorijaId = GetSelectedId(cmbFilterKategorija);
            int strukturaId = GetSelectedId(cmbFilterStruktura);

            IEnumerable<NekretninaDTO> query = _allNekretnine;

            if (projekatId > 0)
            {
                query = query.Where(x => x.ProjekatID == projekatId);
            }

            if (gradId > 0)
            {
                var projektiIds = _allProjekti
                    .Where(x => x.GradID == gradId)
                    .Select(x => x.ProjekatID)
                    .ToList();

                query = query.Where(x => projektiIds.Contains(x.ProjekatID));
            }

            if (kategorijaId > 0)
            {
                query = query.Where(x => x.KategorijaID == kategorijaId);
            }

            if (strukturaId > 0)
            {
                query = query.Where(x => x.StrukturaID == strukturaId);
            }

            return query.ToList();
        }

        private void ShowAktuelnaCenaForSelectedNekretnina()
        {
            lblAktuelnaCenaValue.Text = "Nema aktivne cene";

            if (dgvNekretnine.CurrentRow == null || dgvNekretnine.CurrentRow.Cells["NekretninaID"].Value == null)
            {
                return;
            }

            int nekretninaId = (int)dgvNekretnine.CurrentRow.Cells["NekretninaID"].Value;
            DateTime today = DateTime.Today;

            var aktuelnaCena = _cenaService.GetAll()
                .Where(x => x.NekretninaID == nekretninaId && x.Aktivna && x.DatumOd.Date <= today && x.DatumDo.Date >= today)
                .OrderByDescending(x => x.DatumOd)
                .FirstOrDefault();

            if (aktuelnaCena != null)
            {
                lblAktuelnaCenaValue.Text = aktuelnaCena.Iznos.ToString("0.00");
            }
        }

        private int GetSelectedId(ComboBox comboBox)
        {
            return comboBox.SelectedValue is int id ? id : 0;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                BindNekretnine(ApplyFilters());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri filtriranju nekretnina: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cmbFilterProjekat.SelectedValue = 0;
                cmbFilterGrad.SelectedValue = 0;
                cmbFilterKategorija.SelectedValue = 0;
                LoadStruktureFilterByKategorija();
                cmbFilterStruktura.SelectedValue = 0;
                LoadNekretnine();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri resetovanju filtera: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFilterKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadStruktureFilterByKategorija();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju struktura filtera: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNekretnine_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ShowAktuelnaCenaForSelectedNekretnina();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri prikazu aktuelne cene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new NekretninaEditForm())
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadNekretnine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za unos nekretnine: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNekretnine.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite nekretninu koju želite izmeniti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvNekretnine.SelectedRows[0];
                var nekretnina = new NekretninaDTO
                {
                    NekretninaID = (int)selectedRow.Cells["NekretninaID"].Value,
                    ProjekatID = (int)selectedRow.Cells["ProjekatID"].Value,
                    KategorijaID = (int)selectedRow.Cells["KategorijaID"].Value,
                    StrukturaID = (int)selectedRow.Cells["StrukturaID"].Value,
                    Sifra = selectedRow.Cells["Sifra"].Value?.ToString(),
                    Naziv = selectedRow.Cells["Naziv"].Value?.ToString(),
                    Sprat = (int)selectedRow.Cells["Sprat"].Value,
                    Kvadratura = (decimal)selectedRow.Cells["Kvadratura"].Value,
                    Opis = selectedRow.Cells["Opis"].Value?.ToString(),
                    Aktivna = (bool)selectedRow.Cells["Aktivna"].Value
                };

                using (var form = new NekretninaEditForm(nekretnina))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadNekretnine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri otvaranju forme za izmenu nekretnine: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNekretnine.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo izaberite nekretninu koju želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nekretninaId = (int)dgvNekretnine.SelectedRows[0].Cells["NekretninaID"].Value;

                DialogResult result = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati izabranu nekretninu?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _nekretninaService.Delete(nekretninaId);
                    LoadNekretnine();
                    MessageBox.Show("Nekretnina je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri brisanju nekretnine: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
