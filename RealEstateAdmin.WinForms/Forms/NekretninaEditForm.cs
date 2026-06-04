using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class NekretninaEditForm : Form
    {
        private readonly NekretninaService _nekretninaService = new NekretninaService();
        private readonly ProjekatService _projekatService = new ProjekatService();
        private readonly KategorijaService _kategorijaService = new KategorijaService();
        private readonly StrukturaService _strukturaService = new StrukturaService();
        private readonly NekretninaDTO _nekretnina;
        private List<StrukturaDTO> _allStrukture;

        public NekretninaEditForm()
            : this(null)
        {
        }

        public NekretninaEditForm(NekretninaDTO nekretnina)
        {
            InitializeComponent();
            _nekretnina = nekretnina;
        }

        private void NekretninaEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProjekti();
                LoadKategorije();
                LoadAllStrukture();

                if (_nekretnina != null)
                {
                    cmbProjekat.SelectedValue = _nekretnina.ProjekatID;
                    cmbKategorija.SelectedValue = _nekretnina.KategorijaID;
                    FilterStrukture(_nekretnina.KategorijaID);
                    cmbStruktura.SelectedValue = _nekretnina.StrukturaID;
                    txtSifra.Text = _nekretnina.Sifra;
                    txtNaziv.Text = _nekretnina.Naziv;
                    nudSprat.Value = _nekretnina.Sprat;
                    txtKvadratura.Text = _nekretnina.Kvadratura.ToString();
                    txtOpis.Text = _nekretnina.Opis;
                    chkAktivna.Checked = _nekretnina.Aktivna;
                }
                else
                {
                    cmbProjekat.SelectedIndex = -1;
                    cmbKategorija.SelectedIndex = -1;
                    cmbStruktura.DataSource = null;
                    chkAktivna.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProjekti()
        {
            cmbProjekat.DisplayMember = "Naziv";
            cmbProjekat.ValueMember = "ProjekatID";
            cmbProjekat.DataSource = _projekatService.GetAll();
        }

        private void LoadKategorije()
        {
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaID";
            cmbKategorija.DataSource = _kategorijaService.GetAll();
        }

        private void LoadAllStrukture()
        {
            _allStrukture = _strukturaService.GetAll();
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedValue is int kategorijaId)
            {
                FilterStrukture(kategorijaId);
            }
        }

        private void FilterStrukture(int kategorijaId)
        {
            var filtered = _allStrukture == null
                ? new List<StrukturaDTO>()
                : _allStrukture.FindAll(x => x.KategorijaID == kategorijaId);

            cmbStruktura.DisplayMember = "Naziv";
            cmbStruktura.ValueMember = "StrukturaID";
            cmbStruktura.DataSource = filtered;

            if (filtered.Count == 0)
            {
                cmbStruktura.SelectedIndex = -1;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out decimal kvadratura))
                {
                    return;
                }

                var projekatId = (int)cmbProjekat.SelectedValue;
                var kategorijaId = (int)cmbKategorija.SelectedValue;
                var strukturaId = (int)cmbStruktura.SelectedValue;

                if (_nekretnina == null)
                {
                    var nekretnina = new NekretninaDTO
                    {
                        ProjekatID = projekatId,
                        KategorijaID = kategorijaId,
                        StrukturaID = strukturaId,
                        Sifra = txtSifra.Text,
                        Naziv = txtNaziv.Text,
                        Sprat = (int)nudSprat.Value,
                        Kvadratura = kvadratura,
                        Opis = txtOpis.Text,
                        Aktivna = chkAktivna.Checked
                    };

                    _nekretninaService.Insert(nekretnina);
                }
                else
                {
                    _nekretnina.ProjekatID = projekatId;
                    _nekretnina.KategorijaID = kategorijaId;
                    _nekretnina.StrukturaID = strukturaId;
                    _nekretnina.Sifra = txtSifra.Text;
                    _nekretnina.Naziv = txtNaziv.Text;
                    _nekretnina.Sprat = (int)nudSprat.Value;
                    _nekretnina.Kvadratura = kvadratura;
                    _nekretnina.Opis = txtOpis.Text;
                    _nekretnina.Aktivna = chkAktivna.Checked;

                    _nekretninaService.Update(_nekretnina);
                }

                MessageBox.Show("Nekretnina je uspešno sačuvana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju nekretnine: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(out decimal kvadratura)
        {
            kvadratura = 0;

            if (cmbProjekat.SelectedValue == null || !(cmbProjekat.SelectedValue is int) || (int)cmbProjekat.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite projekat.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProjekat.Focus();
                return false;
            }

            if (cmbKategorija.SelectedValue == null || !(cmbKategorija.SelectedValue is int) || (int)cmbKategorija.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite kategoriju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKategorija.Focus();
                return false;
            }

            if (cmbStruktura.SelectedValue == null || !(cmbStruktura.SelectedValue is int) || (int)cmbStruktura.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite strukturu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStruktura.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                MessageBox.Show("Šifra je obavezna.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
                return false;
            }

            if (!decimal.TryParse(txtKvadratura.Text, out kvadratura) || kvadratura <= 0)
            {
                MessageBox.Show("Kvadratura mora biti validan broj veći od 0.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKvadratura.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Opis je obavezan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOpis.Focus();
                return false;
            }

            return true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
