using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.ProdajaForme
{
    public partial class DodajProdajuForma : Form
    {
        private bool rezimIzmene;
        private int id;
        private int idKupca;
        public DodajProdajuForma()
        {
            InitializeComponent();
            this.rezimIzmene = false;
        }

        public DodajProdajuForma(int id, int idKupca)
        {
            InitializeComponent();
            this.rezimIzmene = true;
            this.id = id;
            this.idKupca = idKupca;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(textBoxJMBGZaposlenog.Text == "" || textBoxBrSasije.Text == "" || textBoxIDSalona.Text == "" || textBoxImeKupca.Text == "" || textBoxPrezimeKupca.Text == "" || textBoxBrTelefona.Text == "" || comboBoxTipKupca.Text == "")
            {
                MessageBox.Show("Niste uneli sve podatke!");
                return;
            }

            if (comboBoxTipKupca.Text == "Pravno")
            {
                if (textBoxPIB.Text == "")
                {
                    MessageBox.Show("Niste uneli PIB!");
                    return;
                }
            }
            else
            {
                if (textBoxJMBGKupca.Text == "")
                {
                    MessageBox.Show("Niste uneli JMBG!");
                    return;
                }
            }

            
                KupacBasic kupacBasic = new KupacBasic
                {
                    Id = idKupca,
                    Ime = textBoxImeKupca.Text,
                    Prezime = textBoxPrezimeKupca.Text,
                    BrojTelefona = textBoxBrTelefona.Text,
                    TipKupca = comboBoxTipKupca.Text,
                    Pib = textBoxPIB.Text,
                    MaticniBroj = textBoxJMBGKupca.Text
                };
                ProdajaCreate prodajaCreate = new ProdajaCreate
                {
                    Id = this.id,
                    BrojSasije = textBoxBrSasije.Text,
                    IdKupca = idKupca,
                    IdMestaProdaje = int.Parse(textBoxIDSalona.Text),
                    MBRProdavca = textBoxJMBGZaposlenog.Text,
                    TipKupca = comboBoxTipKupca.Text,
                    Kupac = kupacBasic
                };

            if (this.rezimIzmene)
            {
                
                DTOManager.AzurirajProdaju(prodajaCreate);
            }
            else
            {
                DTOManager.DodajProdaju(prodajaCreate);
            }

            this.Close();
        }

        private void DodajProdajuForma_Load(object sender, EventArgs e)
        {
            if (this.rezimIzmene)
            {
                btnDodaj.Text = "Azuriraj";

                ProdajaView p = DTOManager.VratiProdaju(this.id);

                textBoxJMBGZaposlenog.Text = p.MBRProdavca;
                textBoxBrSasije.Text = p.BrojSasije;
                textBoxIDSalona.Text = p.IdMestaProdaje.ToString();
                textBoxImeKupca.Text = p.ImeKupca;
                textBoxPrezimeKupca.Text = p.PrezimeKupca;
                textBoxBrTelefona.Text = p.BrojTelefona;
                comboBoxTipKupca.Text = p.TipKupca;

                if (p.TipKupca == "Pravno")
                {
                    
                    textBoxPIB.Text = p.Pib;
                    textBoxJMBGKupca.Text = "";
                    textBoxPIB.Enabled = true;
                    textBoxJMBGKupca.Enabled = false;
                }
                else
                {
                    
                    textBoxJMBGKupca.Text = p.MBRKupca;
                    textBoxJMBGKupca.Enabled = true;
                    textBoxPIB.Text = "";
                    textBoxPIB.Enabled = false;
                }

                comboBoxTipKupca.Enabled = false;


            }

        }

        private void comboBoxTipKupca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipKupca.Text == "Pravno")
            {
                textBoxPIB.Enabled = true;
                textBoxJMBGKupca.Enabled = false;
            }
            else
            {
                textBoxPIB.Enabled = false;
                textBoxJMBGKupca.Enabled = true;
            }
        }
    }
}
