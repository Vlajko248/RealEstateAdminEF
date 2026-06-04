using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class KategorijaEditForm : Form
    {
        private readonly KategorijaService _kategorijaService = new KategorijaService();
        private readonly KategorijaDTO _kategorija;

        public KategorijaEditForm()
            : this(null)
        {
        }

        public KategorijaEditForm(KategorijaDTO kategorija)
        {
            InitializeComponent();
            _kategorija = kategorija;

            if (_kategorija != null)
            {
                txtNaziv.Text = _kategorija.Naziv;
                txtOpis.Text = _kategorija.Opis;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                if (_kategorija == null)
                {
                    var kategorija = new KategorijaDTO
                    {
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text
                    };

                    _kategorijaService.Insert(kategorija);
                }
                else
                {
                    _kategorija.Naziv = txtNaziv.Text;
                    _kategorija.Opis = txtOpis.Text;
                    _kategorijaService.Update(_kategorija);
                }

                MessageBox.Show("Kategorija je uspešno sačuvana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju kategorije: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
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
