using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.VozilaForme
{
    public partial class DodajVoziloForma : Form
    {
        private bool rezimIzmene;
        private string? brojSasije;
        private string? vlasnistvoVozila;

        public DodajVoziloForma()
        {
            this.rezimIzmene = false;
            InitializeComponent();
        }

        public DodajVoziloForma(string brojSasije, string vlasnistvo)
        {
            this.rezimIzmene = true;
            this.brojSasije = brojSasije;
            vlasnistvoVozila = vlasnistvo;


            InitializeComponent();
        }

        private void DodajVoziloForma_Load(object sender, EventArgs e)
        {
            if (this.rezimIzmene)
            {
                btnDodaj.Text = "Azuriraj";
                if (this.vlasnistvoVozila == "NezavisnoVozilo")
                {
                    NezavisnoVoziloBasic vozilo = DTOManager.vratiNezavisnoVozilo(this.brojSasije);
                    textBoxModel.Text = vozilo.Model;
                    textBoxBoja.Text = vozilo.Boja;
                    textBoxBrMotora.Text = vozilo.BrojMotora;
                    numericUpDownKubikaza.Value = vozilo.Kubikaza;
                    comboBoxTipGoriva.SelectedItem = vozilo.TipGoriva;
                    textBoxBrSasije.Text = vozilo.BrojSasije;

                    comboBoxVlasnistvo.SelectedItem = "Nezavisno vozilo";
                    gbNezavisno.Enabled = true;

                    textBoxImeVlasnika.Text = vozilo.ImeVlasnika;
                    textBoxPrezimeVlasnika.Text = vozilo.PrezimeVlasnika;
                    textBoxBrTelefona.Text = vozilo.BrojTelefonaVlasnika;

                    if (vozilo.PutnickaF == "Da" && vozilo.TeretnaF == "Ne")
                    {
                        comboBoxTipVozila.SelectedItem = "Putnicko";
                        textBoxBrPutnika.Enabled = true;
                        textBoxBrPutnika.Text = vozilo.BrojPutnika.ToString();
                    }
                    else if (vozilo.PutnickaF == "Ne" && vozilo.TeretnaF == "Da")
                    {
                        comboBoxTipVozila.SelectedItem = "Teretno";
                        textBoxNosivost.Enabled = true;
                        textBoxNosivost.Text = vozilo.Nosivost.ToString();
                        comboBox1.Enabled = true;
                        comboBox1.SelectedItem = vozilo.TeretniProstorOtvorenogTipa;
                    }
                    else
                    {
                        comboBoxTipVozila.SelectedItem = "PutnickoTeretno";
                        textBoxBrPutnika.Enabled = true;
                        textBoxBrPutnika.Text = vozilo.BrojPutnika.ToString();
                        textBoxNosivost.Enabled = true;
                        textBoxNosivost.Text = vozilo.Nosivost.ToString();
                        comboBox1.Enabled = true;
                        comboBox1.SelectedItem = vozilo.TeretniProstorOtvorenogTipa;
                    }



                }

                else
                {
                    VoziloKompanijeBasic vozilo = DTOManager.vratiVoziloKompanije(this.brojSasije);
                    textBoxModel.Text = vozilo.Model;
                    textBoxBoja.Text = vozilo.Boja;
                    textBoxBrMotora.Text = vozilo.BrojMotora;
                    numericUpDownKubikaza.Value = vozilo.Kubikaza;
                    comboBoxTipGoriva.SelectedItem = vozilo.TipGoriva;
                    textBoxBrSasije.Text = vozilo.BrojSasije;

                    comboBoxVlasnistvo.SelectedItem = "Vozilo Kompanije";
                    gbSluzbeno.Enabled = true;

                    

                    if (vozilo.UvezenoF == "Da")
                    {
                        cbUvezeno.Checked = true;
                        cbUvezeno.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        dateTimePicker1.Value = (DateTime)vozilo.DatumUvoza;
                        
                        if (vozilo.MbrIzvrsiocaPrijemaUvoza != null)
                        {
                            cbUvezeno.Checked = true;
                            textBoxZaposleniPrijem.Text = vozilo.MbrIzvrsiocaPrijemaUvoza;
                        }

                        else
                            cbIzlozeno.Checked = false;

                    }
                    else if(vozilo.IdSalona != -1)
                    {
                        cbIzlozeno.Checked = true;
                        cbIzlozeno.Enabled = true;
                        textBoxBrSalona.Enabled = true;
                        textBoxBrSalona.Text = vozilo.IdSalona.ToString();
                    }
                    else if(vozilo.IdSalona == -1 && vozilo.UvezenoF == "Da")
                    {
                        cbUvezeno.Checked = true;
                        cbUvezeno.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        dateTimePicker1.Value = (DateTime)vozilo.DatumUvoza;

                        if (vozilo.MbrIzvrsiocaPrijemaUvoza != null)
                        {
                            cbUvezeno.Checked = true;
                            textBoxZaposleniPrijem.Text = vozilo.MbrIzvrsiocaPrijemaUvoza;
                        }

                        else
                            cbIzlozeno.Checked = false;

                        cbIzlozeno.Checked = true;
                        cbIzlozeno.Enabled = true;
                        textBoxBrSalona.Enabled = true;
                        textBoxBrSalona.Text = vozilo.IdSalona.ToString();
                    }
                    else
                    {
                        cbUvezeno.Checked = false;
                        cbUvezeno.Enabled = false;
                        dateTimePicker1.Enabled = false;


                    }



                    if (vozilo.PutnickaF == "Da" && vozilo.TeretnaF == "Ne")
                    {
                        comboBoxTipVozila.SelectedItem = "Putnicko";
                        textBoxBrPutnika.Enabled = true;
                        textBoxBrPutnika.Text = vozilo.BrojPutnika.ToString();
                    }
                    else if (vozilo.PutnickaF == "Ne" && vozilo.TeretnaF == "Da")
                    {
                        comboBoxTipVozila.SelectedItem = "Teretno";
                        textBoxNosivost.Enabled = true;
                        textBoxNosivost.Text = vozilo.Nosivost.ToString();
                        comboBox1.Enabled = true;
                        comboBox1.SelectedItem = vozilo.TeretniProstorOtvorenogTipa;
                    }
                    else
                    {
                        comboBoxTipVozila.SelectedItem = "PutnickoTeretno";
                        textBoxBrPutnika.Enabled = true;
                        textBoxBrPutnika.Text = vozilo.BrojPutnika.ToString();
                        textBoxNosivost.Enabled = true;
                        textBoxNosivost.Text = vozilo.Nosivost.ToString();
                        comboBox1.Enabled = true;
                        comboBox1.SelectedItem = vozilo.TeretniProstorOtvorenogTipa;
                    }
                }


            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxModel.Text == "" || textBoxBoja.Text == "" || textBoxBrMotora.Text == "" || numericUpDownKubikaza.Value == 0 ||
                comboBoxTipGoriva.SelectedItem == null || textBoxBrSasije.Text == "")
            {
                MessageBox.Show("Niste uneli sve podatke!");
                return;
            }

            if (comboBoxVlasnistvo.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali vlasnistvo vozila!");
                return;
            }

            if (comboBoxVlasnistvo.SelectedItem.ToString() == "Nezavisno vozilo")
            {
                if (textBoxImeVlasnika.Text == "" || textBoxPrezimeVlasnika.Text == "" || textBoxBrTelefona.Text == "")
                {
                    MessageBox.Show("Niste uneli sve podatke o vlasniku vozila!");
                    return;
                }

                if (comboBoxTipVozila.SelectedItem == null)
                {
                    MessageBox.Show("Niste odabrali tip vozila!");
                    return;
                }

                if (comboBoxTipVozila.SelectedItem.ToString() == "Putnicko")
                {
                    if (textBoxBrPutnika.Text == "")
                    {
                        MessageBox.Show("Niste uneli broj putnika!");
                        return;
                    }
                }
                else if (comboBoxTipVozila.SelectedItem.ToString() == "Teretno")
                {
                    if (textBoxNosivost.Text == "" || comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Niste uneli sve podatke o teretnom vozilu!");
                        return;
                    }
                }
                else
                {
                    if (textBoxBrPutnika.Text == "" || textBoxNosivost.Text == "" || comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Niste uneli sve podatke o putnicko-teretnom vozilu!");
                        return;
                    }
                }

                
                
                    NezavisnoVoziloBasic vozilo = new NezavisnoVoziloBasic();
                    vozilo.Model = textBoxModel.Text;
                    vozilo.Boja = textBoxBoja.Text;
                    vozilo.BrojMotora = textBoxBrMotora.Text;
                    vozilo.Kubikaza = (int)numericUpDownKubikaza.Value;
                    vozilo.TipGoriva = comboBoxTipGoriva.SelectedItem.ToString();
                    vozilo.BrojSasije = textBoxBrSasije.Text;
                    vozilo.ImeVlasnika = textBoxImeVlasnika.Text;
                    vozilo.PrezimeVlasnika = textBoxPrezimeVlasnika.Text;
                    vozilo.BrojTelefonaVlasnika = textBoxBrTelefona.Text;

                    if (comboBoxTipVozila.SelectedItem.ToString() == "Putnicko")
                    {
                        vozilo.PutnickaF = "Da";
                        vozilo.TeretnaF = "Ne";
                    }
                    else if(comboBoxTipVozila.SelectedItem.ToString() == "Teretno")
                    {
                        vozilo.TeretnaF = "Da";
                        vozilo.PutnickaF = "Ne";
                        vozilo.Nosivost = int.Parse(textBoxNosivost.Text);
                        vozilo.TeretniProstorOtvorenogTipa = comboBox1.SelectedItem.ToString();
                    }
                    else
                    {
                        vozilo.PutnickaF = "Da";
                        vozilo.TeretnaF = "Da";
                        vozilo.Nosivost = int.Parse(textBoxNosivost.Text);
                        vozilo.TeretniProstorOtvorenogTipa = comboBox1.SelectedItem.ToString();
                    }

                if (this.rezimIzmene)
                   // DTOManager.azuriraj(vozilo);
                    

                if(!this.rezimIzmene)
                    DTOManager.dodajNezavisnoVozilo(vozilo);



            }
            else
            {
                if (comboBoxTipVozila.SelectedItem == null)
                {
                    MessageBox.Show("Niste odabrali tip vozila!");
                    return;
                }

                if (comboBoxTipVozila.SelectedItem.ToString() == "Putnicko")
                {
                    if (textBoxBrPutnika.Text == "")
                    {
                        MessageBox.Show("Niste uneli broj putnika!");
                        return;
                    }
                }
                else if (comboBoxTipVozila.SelectedItem.ToString() == "Teretno")
                {
                    if (textBoxNosivost.Text == "" || comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Niste uneli sve podatke o teretnom vozilu!");
                        return;
                    }
                }
                else
                {
                    if (textBoxBrPutnika.Text == "" || textBoxNosivost.Text == "" || comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Niste uneli sve podatke o putnicko-teretnom vozilu!");
                        return;
                    }
                }



                
                


                VoziloKompanijeBasic vozilo = new VoziloKompanijeBasic();
                    vozilo.Model = textBoxModel.Text;
                    vozilo.Boja = textBoxBoja.Text;
                    vozilo.BrojMotora = textBoxBrMotora.Text;
                    vozilo.Kubikaza = (int)numericUpDownKubikaza.Value;
                    vozilo.TipGoriva = comboBoxTipGoriva.SelectedItem.ToString();
                    vozilo.BrojSasije = textBoxBrSasije.Text;


                    if (cbUvezeno.Checked)
                    {
                        vozilo.UvezenoF = "Da";
                        vozilo.DatumUvoza = dateTimePicker1.Value;
                        vozilo.MbrIzvrsiocaPrijemaUvoza = textBoxZaposleniPrijem.Text;
                    }
                    else
                    {
                        vozilo.UvezenoF = "Ne";
                    }

                    if (cbIzlozeno.Checked)
                    {
                        if (int.TryParse(textBoxBrSalona.Text, out int n) == false)
                        {
                            MessageBox.Show("Broj salona mora biti broj!");
                            return;
                        }
                        vozilo.IdSalona = n;
                    }
                    else
                    {
                        vozilo.IdSalona = -1;
                    }

                


                if (comboBoxTipVozila.SelectedItem.ToString() == "Putnicko")
                    {
                        vozilo.PutnickaF = "Da";
                        vozilo.TeretnaF = "Ne";
                        vozilo.BrojPutnika = int.Parse(textBoxBrPutnika.Text);
                }
                    else if (comboBoxTipVozila.SelectedItem.ToString() == "Teretno")
                    {
                        vozilo.TeretnaF = "Da";
                        vozilo.PutnickaF = "Ne";
                        vozilo.Nosivost = int.Parse(textBoxNosivost.Text);
                        vozilo.TeretniProstorOtvorenogTipa = comboBox1.SelectedItem.ToString();
                    }
                    else
                    {
                        vozilo.PutnickaF = "Da";
                        vozilo.TeretnaF = "Da";
                        vozilo.Nosivost = int.Parse(textBoxNosivost.Text);
                        vozilo.TeretniProstorOtvorenogTipa = comboBox1.SelectedItem.ToString();
                        vozilo.BrojPutnika = int.Parse(textBoxBrPutnika.Text);

                }


                if (this.rezimIzmene)
                    return;
                    // DTOManager.azurirajNezavisnoVozilo(vozilo);

                if (!this.rezimIzmene)
                    DTOManager.dodajVoziloKompanije(vozilo);
            }

            this.Close();

        }

        private void comboBoxVlasnistvo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVlasnistvo.SelectedItem.ToString() == "Nezavisno vozilo")
            {
                gbNezavisno.Enabled = true;
                gbSluzbeno.Enabled = false;
            }
            else
            {
                gbSluzbeno.Enabled = true;
                gbNezavisno.Enabled = false;
            }
        }

        private void cbUvezeno_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = cbUvezeno.Checked;
            textBoxZaposleniPrijem.Enabled = cbUvezeno.Checked;
        }

        private void cbIzlozeno_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBrSalona.Enabled = cbIzlozeno.Checked;
        }

        private void comboBoxTipVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipVozila.SelectedItem.ToString() == "Putnicko")
            {
                textBoxBrPutnika.Enabled = true;
                textBoxNosivost.Enabled = false;
                comboBox1.Enabled = false;
            }
            else if (comboBoxTipVozila.SelectedItem.ToString() == "Teretno")
            {
                textBoxNosivost.Enabled = true;
                comboBox1.Enabled = true;
                textBoxBrPutnika.Enabled = false;
            }
            else
            {
                textBoxBrPutnika.Enabled = true;
                textBoxNosivost.Enabled = true;
                comboBox1.Enabled = true;
            }

        }
    }
}
