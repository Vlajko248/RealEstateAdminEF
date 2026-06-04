using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class ProjekatEditForm : Form
    {
        private readonly ProjekatService _projekatService = new ProjekatService();
        private readonly GradService _gradService = new GradService();
        private readonly ProjekatDTO _projekat;

        public ProjekatEditForm()
            : this(null)
        {
        }

        public ProjekatEditForm(ProjekatDTO projekat)
        {
            InitializeComponent();
            _projekat = projekat;
        }

        private void ProjekatEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGradovi();

                if (_projekat != null)
                {
                    txtNaziv.Text = _projekat.Naziv;
                    txtAdresa.Text = _projekat.Adresa;
                    txtOpis.Text = _projekat.Opis;
                    cmbGrad.SelectedValue = _projekat.GradID;
                }
                else
                {
                    cmbGrad.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGradovi()
        {
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradID";
            cmbGrad.DataSource = _gradService.GetAll();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                var gradId = (int)cmbGrad.SelectedValue;

                if (_projekat == null)
                {
                    var projekat = new ProjekatDTO
                    {
                        Naziv = txtNaziv.Text,
                        Adresa = txtAdresa.Text,
                        GradID = gradId,
                        Opis = txtOpis.Text
                    };

                    _projekatService.Insert(projekat);
                }
                else
                {
                    _projekat.Naziv = txtNaziv.Text;
                    _projekat.Adresa = txtAdresa.Text;
                    _projekat.GradID = gradId;
                    _projekat.Opis = txtOpis.Text;

                    _projekatService.Update(_projekat);
                }

                MessageBox.Show("Projekat je uspešno sačuvan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju projekta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Adresa je obavezna.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdresa.Focus();
                return false;
            }

            if (cmbGrad.SelectedValue == null || !(cmbGrad.SelectedValue is int) || (int)cmbGrad.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite grad.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGrad.Focus();
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
