using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class StrukturaEditForm : Form
    {
        private readonly StrukturaService _strukturaService = new StrukturaService();
        private readonly KategorijaService _kategorijaService = new KategorijaService();
        private readonly StrukturaDTO _struktura;

        public StrukturaEditForm()
            : this(null)
        {
        }

        public StrukturaEditForm(StrukturaDTO struktura)
        {
            InitializeComponent();
            _struktura = struktura;
        }

        private void StrukturaEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKategorije();

                if (_struktura != null)
                {
                    cmbKategorija.SelectedValue = _struktura.KategorijaID;
                    txtNaziv.Text = _struktura.Naziv;
                    txtOpis.Text = _struktura.Opis;
                }
                else
                {
                    cmbKategorija.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKategorije()
        {
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaID";
            cmbKategorija.DataSource = _kategorijaService.GetAll();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                var kategorijaId = (int)cmbKategorija.SelectedValue;

                if (_struktura == null)
                {
                    var struktura = new StrukturaDTO
                    {
                        KategorijaID = kategorijaId,
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text
                    };

                    _strukturaService.Insert(struktura);
                }
                else
                {
                    _struktura.KategorijaID = kategorijaId;
                    _struktura.Naziv = txtNaziv.Text;
                    _struktura.Opis = txtOpis.Text;
                    _strukturaService.Update(_struktura);
                }

                MessageBox.Show("Struktura je uspešno sačuvana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju strukture: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cmbKategorija.SelectedValue == null || !(cmbKategorija.SelectedValue is int) || (int)cmbKategorija.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite kategoriju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKategorija.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv je obavezan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Focus();
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
