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
        public DodajZaposlenogForma()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxIme.Text == "" || textBoxPrezime.Text == "" || comboBoxTipZaposlenja.SelectedItem == null || comboBoxTipStruke.SelectedItem == null
                || textBoxJMBG.Text == "" || textBoxStrucnaSprema.Text=="")
            {
                MessageBox.Show("Morate popuniti sva polja");
                return;
            }

            if(textBoxJMBG.Text.Length != 13)
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
                if(comboBoxSertifikat.SelectedItem == null)
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

                DTOManager.dodajEkonomskeStruke(ekonmske);

            }
            else if(comboBoxTipStruke.SelectedItem!.ToString() == "Tehnicke")
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

                DTOManager.dodajTehnickeStruke(tehnicke);


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

                DTOManager.dodajZaposlenog(zaposleni);
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
            if(comboBoxSertifikat.SelectedItem!.ToString() == "Da")
            {
                dateTimePickerSertifikata.Enabled = true;
            }
            else
            {
                dateTimePickerSertifikata.Enabled = false;
            }
        }
    }
}
