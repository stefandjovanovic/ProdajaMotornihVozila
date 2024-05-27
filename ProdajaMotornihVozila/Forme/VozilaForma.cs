using ProdajaMotornihVozila.Forme.VozilaForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme
{
    public partial class VozilaForma : Form
    {
        public VozilaForma()
        {
            InitializeComponent();
        }

        private void VozilaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listaVozila.Items.Clear();

            List<VoziloBasic> voziloBasics = DTOManager.vratiSvaVozila();

            foreach (VoziloBasic v in voziloBasics)
            {
                ListViewItem item = new ListViewItem(new string[] { v.BrojSasije, v.Boja, v.Model, v.TipGoriva, v.Kubikaza.ToString(), v.BrojMotora, v.VlasnistvoVozila });
                item.Tag = v;
                listaVozila.Items.Add(item);
            }

            listaVozila.Refresh();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali vozilo!");
                return;
            }

            string brojSasije = listaVozila.SelectedItems[0].SubItems[0].Text;
            string tipVlasnistva = listaVozila.SelectedItems[0].SubItems[6].Text;

            string poruka = "Da li zelite da obrisete izabrano vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    if(tipVlasnistva == "NezavisnoVozilo")
                    {
                        DTOManager.obrisiNezavisnoVozilo(brojSasije);
                        MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                        this.popuniPodacima();
                    }
                    else
                    {
                        DTOManager.obrisiVoziloKompanije(brojSasije);
                        MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                        this.popuniPodacima();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajVoziloForma forma = new DodajVoziloForma();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali vozilo!");
                return;
            }

            string brojSasije = listaVozila.SelectedItems[0].SubItems[0].Text;
            

            StringBuilder sb = new StringBuilder();

            try
            {
                VoziloView vw = DTOManager.prikaziVozilo(brojSasije);
                sb.Append("Broj sasije: " + vw.BrojSasije + "\n");
                sb.Append("Boja: " + vw.Boja + "\n");
                sb.Append("Model: " + vw.Model + "\n");
                sb.Append("Tip goriva: " + vw.TipGoriva + "\n");
                sb.Append("Kubikaza: " + vw.Kubikaza + "\n");
                sb.Append("Broj motora: " + vw.BrojMotora + "\n");
                sb.Append("Vlasnistvo vozila: " + vw.VlasnistvoVozila + "\n");
                if (vw.PutnickaF == "Da")
                    sb.Append("Broj Putnika: " + vw.BrojPutnika + "\n");
                else
                {
                    sb.Append("Nosivost: " + vw.Nosivost + "\n");
                    sb.Append("Teretni Prostor je otvorenog tipa : " + vw.TeretniProstorOtvorenogTipa + "\n");
                }

                MessageBox.Show(sb.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali vozilo!");
                return;
            }

            string brojSasije = listaVozila.SelectedItems[0].SubItems[0].Text;
            string vlasnistvo = listaVozila.SelectedItems[0].SubItems[6].Text;


            DodajVoziloForma forma = new DodajVoziloForma(brojSasije, vlasnistvo);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
