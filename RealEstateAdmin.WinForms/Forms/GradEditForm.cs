using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class GradEditForm : Form
    {
        private readonly GradService _gradService = new GradService();
        private readonly GradDTO _grad;

        public GradEditForm()
            : this(null)
        {
        }

        public GradEditForm(GradDTO grad)
        {
            InitializeComponent();
            _grad = grad;

            if (_grad != null)
            {
                txtNaziv.Text = _grad.Naziv;
                txtPostanskiBroj.Text = _grad.PostanskiBroj;
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

                if (_grad == null)
                {
                    var grad = new GradDTO
                    {
                        Naziv = txtNaziv.Text,
                        PostanskiBroj = txtPostanskiBroj.Text
                    };

                    _gradService.Insert(grad);
                }
                else
                {
                    _grad.Naziv = txtNaziv.Text;
                    _grad.PostanskiBroj = txtPostanskiBroj.Text;
                    _gradService.Update(_grad);
                }

                MessageBox.Show("Grad je uspešno sačuvan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju grada: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                MessageBox.Show("Poštanski broj je obavezan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPostanskiBroj.Focus();
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
