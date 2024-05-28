using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.ServisForme
{
    public partial class DodajServisForma : Form
    {
        private bool rezimIzmene = false;
        private int idServisaZaIzmenu;

        public DodajServisForma()
        {
            rezimIzmene = false;
            idServisaZaIzmenu = -1;
            InitializeComponent();
        }

        public DodajServisForma(int idServisa)
        {
            rezimIzmene = true;
            idServisaZaIzmenu = idServisa;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajServisForma_Load(object sender, EventArgs e)
        {
            if(rezimIzmene)
            {
                try
                {
                    ObavljeniServisView servis = DTOManager.vratiObavljeniServis(idServisaZaIzmenu);
                    dateTimePicker1.Value = servis.DatumPrijema;
                    if(servis.DatumZavrsetka != null)
                    {
                        checkBoxZavrsen.Checked = true;
                        dateTimePicker2.Value = (DateTime)servis.DatumZavrsetka;
                    }
                    textBoxMBRIzvrsioca.Text = servis.MbrIzvrsiocaPrijema;
                    textBoxIDServisa.Text = servis.ServisId.ToString();
                    textBoxBrSasije.Text = servis.BrojSasijeVozila;
                    textBoxRegistarskiBr.Text = servis.RegistarskiBroj;
                    textBoxModel.Text = servis.Model;
                    textBoxOpis.Text = servis.Opis;
                    textBoxGodProizv.Text = servis.GodinaProizvodnje;

                    btnDodaj.Text = "Izmeni";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(textBoxMBRIzvrsioca.Text == "" || textBoxIDServisa.Text == "" || textBoxBrSasije.Text == "" || textBoxRegistarskiBr.Text == "" || textBoxModel.Text == "" || textBoxOpis.Text == "" || textBoxGodProizv.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja.");
                return;
            }
            if(textBoxMBRIzvrsioca.Text.Length != 13)
            {
                MessageBox.Show("Maticni broj izvrsioca mora imati 13 cifara.");
                return;
            }


            DateTime datumPrijema = dateTimePicker1.Value;
            DateTime? datumZavrsetka;
            if (checkBoxZavrsen.Checked)
            {
                datumZavrsetka = dateTimePicker2.Value;
            }
            else
            {
                datumZavrsetka = null;
            }
            string mbrIzvrsiocaPrijema = textBoxMBRIzvrsioca.Text;
            int idServisa = int.Parse(textBoxIDServisa.Text);
            string brojSasije = textBoxBrSasije.Text;
            string regBroj = textBoxRegistarskiBr.Text;
            string model = textBoxModel.Text;
            string opis = textBoxOpis.Text;
            string godinaProizvodnje = textBoxGodProizv.Text;

            ObavljeniServisCreate obavljeniServis = new ObavljeniServisCreate()
            {
                Id = idServisaZaIzmenu,
                ServisId = idServisa,
                RegistarskiBroj = regBroj,
                Model = model,
                Opis = opis,
                GodinaProizvodnje = godinaProizvodnje,
                BrojSasijeVozila = brojSasije,
                DatumPrijemaVozila = datumPrijema,
                DatumZavrsetkaServisa = datumZavrsetka,
                MbrIzvrsiocaPrijema = mbrIzvrsiocaPrijema
            };

            try
            {
                if(rezimIzmene)
                    DTOManager.azurirajObavljeniServis(obavljeniServis);
                else
                    DTOManager.ObaviServis(obavljeniServis);
                MessageBox.Show("Servis uspesno dodat.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBoxZavrsen_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = checkBoxZavrsen.Checked;
        }
    }
}
