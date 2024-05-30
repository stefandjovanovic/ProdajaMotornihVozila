using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.ZaposleniForme
{
    public partial class DodajZaposlenogForma : Form
    {
        private bool rezimIzmene;
        private string? jmbgZaposlenog;
        private string? tipStruke;
        public DodajZaposlenogForma()
        {
            this.rezimIzmene = false;
            InitializeComponent();
        }

        public DodajZaposlenogForma(string jmbgZaposlenog, string tipStruke)
        {
            this.rezimIzmene = true;
            this.jmbgZaposlenog = jmbgZaposlenog;
            this.tipStruke = tipStruke;
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || comboBoxTipZaposlenja.SelectedItem == null || comboBoxTipStruke.SelectedItem == null
                || textBoxJMBG.Text == "" || textBoxStrucnaSprema.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja");
                return;
            }

            if (textBoxJMBG.Text.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara");
                return;
            }

            float? plata = null;
            DateTime? datumIstekaUgovora = null;
            if (comboBoxTipZaposlenja.SelectedItem!.ToString() == "Stalno")
            {
                plata = (float)numericUpDownPlata.Value;
            }
            else
            {
                datumIstekaUgovora = dateTimePickerIstekaUgovora.Value;
            }

            if (comboBoxTipStruke.SelectedItem!.ToString() == "Ekonomske")
            {
                if (comboBoxSertifikat.SelectedItem == null)
                {
                    MessageBox.Show("Morate popuniti sva polja");
                    return;
                }

                EkonomStrBasic ekonmske = new EkonomStrBasic(
                    textBoxJMBG.Text,
                    textBoxIme.Text,
                    textBoxPrezime.Text,
                    textBoxStrucnaSprema.Text,
                    comboBoxTipZaposlenja.SelectedItem!.ToString(),
                    dateTimePickerRodjenja.Value,
                    dateTimePickerZaposlenja.Value,
                    plata,
                    datumIstekaUgovora,
                    "EkonomskeStruke",
                    comboBoxSertifikat.SelectedItem!.ToString(),
                    comboBoxSertifikat.SelectedItem!.ToString() == "Da" ? dateTimePickerSertifikata.Value : null
                    );

                try
                {
                    if (this.rezimIzmene)
                    {
                        DTOManager.azurirajEkonomskeStruke(ekonmske);
                    }
                    else
                    {
                        DTOManager.dodajEkonomskeStruke(ekonmske);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                


            }
            else if (comboBoxTipStruke.SelectedItem!.ToString() == "Tehnicke")
            {
                if (textBoxNazivSpecijalnosti.Text == "" || textBoxInstitucija.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");
                    return;
                }

                TehnickeStrBasic tehnicke = new TehnickeStrBasic(

                    textBoxJMBG.Text,
                    textBoxIme.Text,
                    textBoxPrezime.Text,
                    textBoxStrucnaSprema.Text,
                    comboBoxTipZaposlenja.SelectedItem!.ToString(),
                    "TehnickeStruke",
                    dateTimePickerRodjenja.Value,
                    dateTimePickerZaposlenja.Value,
                    plata,
                    datumIstekaUgovora,
                    textBoxInstitucija.Text,
                    textBoxNazivSpecijalnosti.Text,
                    dateTimePickerDiplome.Value
                    );

                try
                {
                    if (this.rezimIzmene)
                    {
                        DTOManager.azurirajTehnickeStuke(tehnicke);
                    }
                    else
                    {
                        DTOManager.dodajTehnickeStruke(tehnicke);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                



            }
            else
            {
                ZaposleniView zaposleni = new ZaposleniView(
                    textBoxJMBG.Text,
                    textBoxIme.Text,
                    textBoxPrezime.Text,
                    textBoxStrucnaSprema.Text,
                    comboBoxTipZaposlenja.SelectedItem!.ToString(),
                    "Ostalo",
                    dateTimePickerRodjenja.Value,
                    dateTimePickerZaposlenja.Value,
                    plata,
                    datumIstekaUgovora
                    );

                try
                {
                    if (this.rezimIzmene)
                    {
                        DTOManager.azurirajZaposlenog(zaposleni);
                    }
                    else
                    {
                        DTOManager.dodajZaposlenog(zaposleni);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                

            }



            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTipZaposlenja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipZaposlenja.SelectedItem!.ToString() == "Stalno")
            {
                numericUpDownPlata.Enabled = true;
                dateTimePickerIstekaUgovora.Enabled = false;
            }
            else
            {
                numericUpDownPlata.Enabled = false;
                dateTimePickerIstekaUgovora.Enabled = true;
            }
        }

        private void comboBoxTipStruke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipStruke.SelectedItem!.ToString() == "Ekonomske")
            {
                textBoxNazivSpecijalnosti.Enabled = false;
                dateTimePickerDiplome.Enabled = false;
                textBoxInstitucija.Enabled = false;

                comboBoxSertifikat.Enabled = true;
                //dateTimePickerSertifikata.Enabled = true;
            }
            else if (comboBoxTipStruke.SelectedItem!.ToString() == "Tehnicke")
            {
                textBoxNazivSpecijalnosti.Enabled = true;
                dateTimePickerDiplome.Enabled = true;
                textBoxInstitucija.Enabled = true;

                comboBoxSertifikat.Enabled = false;
                dateTimePickerSertifikata.Enabled = false;
            }
            else
            {
                textBoxNazivSpecijalnosti.Enabled = false;
                dateTimePickerDiplome.Enabled = false;
                textBoxInstitucija.Enabled = false;

                comboBoxSertifikat.Enabled = false;
                dateTimePickerSertifikata.Enabled = false;
            }
        }

        private void comboBoxSertifikat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSertifikat.SelectedItem!.ToString() == "Da")
            {
                dateTimePickerSertifikata.Enabled = true;
            }
            else
            {
                dateTimePickerSertifikata.Enabled = false;
            }
        }

        private void DodajZaposlenogForma_Load(object sender, EventArgs e)
        {
            if(this.rezimIzmene)
            {
                button1.Text = "Azuriraj";

                if (this.tipStruke == "TehnickeStruke")
                {
                    TehnickeStrBasic tehnicke = DTOManager.vratiZaposlenogTehnicke(this.jmbgZaposlenog!);
                    textBoxIme.Text = tehnicke.Ime;
                    textBoxPrezime.Text = tehnicke.Prezime;
                    textBoxJMBG.Text = tehnicke.ZaposleniId;
                    textBoxStrucnaSprema.Text = tehnicke.StrucnaSprema;
                    dateTimePickerRodjenja.Value = tehnicke.DatumRodjenja;
                    dateTimePickerZaposlenja.Value = tehnicke.DatumZaposlenja;
                    comboBoxTipZaposlenja.SelectedItem = tehnicke.TipZaposlenja;
                    if(tehnicke.TipZaposlenja == "Stalno")
                    {
                        numericUpDownPlata.Value = (decimal)tehnicke.Plata!;
                    }
                    else
                    {
                        dateTimePickerIstekaUgovora.Value = tehnicke.DatumIstekaUgovora ?? new DateTime();
                    }
                    comboBoxTipStruke.SelectedItem = "Tehnicke";
                    comboBoxTipStruke.Enabled = false;
                    textBoxInstitucija.Text = tehnicke.Institucija;
                    textBoxNazivSpecijalnosti.Text = tehnicke.NazivSpecijalnosti;
                    dateTimePickerDiplome.Value = tehnicke.DatumSticanjaDiplome;
                    textBoxInstitucija.Enabled = true;
                    textBoxNazivSpecijalnosti.Enabled = true;
                    dateTimePickerDiplome.Enabled = true;

                    //sakrij za ekonomsku struku
                    comboBoxSertifikat.Visible = false;
                    dateTimePickerSertifikata.Visible = false;

                }
                else if (this.tipStruke == "EkonomskeStruke")
                {
                    EkonomStrBasic ekonomske = DTOManager.vratiZaposlenogEkonom(this.jmbgZaposlenog!);

                    textBoxIme.Text = ekonomske.Ime;
                    textBoxPrezime.Text = ekonomske.Prezime;
                    textBoxJMBG.Text = ekonomske.ZaposleniId;
                    textBoxStrucnaSprema.Text = ekonomske.StrucnaSprema;
                    dateTimePickerRodjenja.Value = ekonomske.DatumRodjenja;
                    dateTimePickerZaposlenja.Value = ekonomske.DatumZaposlenja;
                    comboBoxTipZaposlenja.SelectedItem = ekonomske.TipZaposlenja;
                    if (ekonomske.TipZaposlenja == "Stalno")
                    {
                        numericUpDownPlata.Value = (decimal)ekonomske.Plata!;
                    }
                    else
                    {
                        dateTimePickerIstekaUgovora.Value = ekonomske.DatumIstekaUgovora ?? new DateTime();
                    }
                    comboBoxTipStruke.SelectedItem = "Ekonomske";
                    comboBoxTipStruke.Enabled = false;
                    comboBoxSertifikat.SelectedItem = ekonomske.PosedujeSertifikat;
                    comboBoxSertifikat.Enabled = true;
                    if (ekonomske.PosedujeSertifikat == "Da")
                    {
                        dateTimePickerSertifikata.Value = ekonomske.DatumSticanja ?? new DateTime();
                    }

                    //sakrij za tehnicku struku
                    textBoxInstitucija.Visible = false;
                    textBoxNazivSpecijalnosti.Visible = false;
                    dateTimePickerDiplome.Visible = false;

                }
                else
                {
                    ZaposleniView zaposleni = DTOManager.vratiZaposlenog(this.jmbgZaposlenog!);
                    textBoxIme.Text = zaposleni.Ime;
                    textBoxPrezime.Text = zaposleni.Prezime;
                    textBoxJMBG.Text = zaposleni.ZaposleniId;
                    textBoxStrucnaSprema.Text = zaposleni.StrucnaSprema;
                    dateTimePickerRodjenja.Value = zaposleni.DatumRodjenja;
                    dateTimePickerZaposlenja.Value = zaposleni.DatumZaposlenja;
                    comboBoxTipZaposlenja.SelectedItem = zaposleni.TipZaposlenja;
                    if (zaposleni.TipZaposlenja == "Stalno")
                    {
                        numericUpDownPlata.Value = (decimal)zaposleni.Plata!;
                    }
                    else
                    {
                        dateTimePickerIstekaUgovora.Value = zaposleni.DatumIstekaUgovora ?? new DateTime();
                    }
                    comboBoxTipStruke.SelectedItem = "Ostalo";
                    comboBoxTipStruke.Enabled = false;

                    //sakrij za tehnicku struku i ekonomsku struku
                    textBoxInstitucija.Visible = false;
                    textBoxNazivSpecijalnosti.Visible = false;
                    dateTimePickerDiplome.Visible = false;

                    comboBoxSertifikat.Visible = false;
                    dateTimePickerSertifikata.Visible = false;
                }
            }
        }
    }
}
