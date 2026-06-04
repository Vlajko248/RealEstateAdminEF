using System;
using System.Windows.Forms;
using RealEstateAdmin.Business;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.WinForms
{
    public partial class CenaEditForm : Form
    {
        private readonly CenaService _cenaService = new CenaService();
        private readonly NekretninaService _nekretninaService = new NekretninaService();
        private readonly CenaDTO _cena;

        public CenaEditForm()
            : this(null)
        {
        }

        public CenaEditForm(CenaDTO cena)
        {
            InitializeComponent();
            _cena = cena;
        }

        private void CenaEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNekretnine();

                if (_cena != null)
                {
                    cmbNekretnina.SelectedValue = _cena.NekretninaID;
                    txtIznos.Text = _cena.Iznos.ToString();
                    dtpDatumOd.Value = _cena.DatumOd;
                    dtpDatumDo.Value = _cena.DatumDo;
                    chkAktivna.Checked = _cena.Aktivna;
                }
                else
                {
                    cmbNekretnina.SelectedIndex = -1;
                    chkAktivna.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNekretnine()
        {
            cmbNekretnina.DisplayMember = "Naziv";
            cmbNekretnina.ValueMember = "NekretninaID";
            cmbNekretnina.DataSource = _nekretninaService.GetAll();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out decimal iznos))
                {
                    return;
                }

                var nekretninaId = (int)cmbNekretnina.SelectedValue;

                if (_cena == null || _cena.CenaID == 0)
                {
                    var cena = new CenaDTO
                    {
                        NekretninaID = nekretninaId,
                        Iznos = iznos,
                        DatumOd = dtpDatumOd.Value.Date,
                        DatumDo = dtpDatumDo.Value.Date,
                        Aktivna = chkAktivna.Checked
                    };

                    _cenaService.Insert(cena);
                }
                else
                {
                    _cena.NekretninaID = nekretninaId;
                    _cena.Iznos = iznos;
                    _cena.DatumOd = dtpDatumOd.Value.Date;
                    _cena.DatumDo = dtpDatumDo.Value.Date;
                    _cena.Aktivna = chkAktivna.Checked;
                    _cenaService.Update(_cena);
                }

                MessageBox.Show("Cena je uspešno sačuvana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju cene: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(out decimal iznos)
        {
            iznos = 0;

            if (cmbNekretnina.SelectedValue == null || !(cmbNekretnina.SelectedValue is int) || (int)cmbNekretnina.SelectedValue <= 0)
            {
                MessageBox.Show("Izaberite nekretninu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNekretnina.Focus();
                return false;
            }

            if (!decimal.TryParse(txtIznos.Text, out iznos) || iznos <= 0)
            {
                MessageBox.Show("Iznos mora biti validan broj veći od 0.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIznos.Focus();
                return false;
            }

            if (dtpDatumOd.Value.Date > dtpDatumDo.Value.Date)
            {
                MessageBox.Show("Datum od ne sme biti veći od datuma do.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatumOd.Focus();
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
