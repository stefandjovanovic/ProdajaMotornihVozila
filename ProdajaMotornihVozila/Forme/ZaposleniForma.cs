using ProdajaMotornihVozila.Forme.ZaposleniForme;
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
    public partial class ZaposleniForma : Form
    {
        public ZaposleniForma()
        {
            InitializeComponent();
        }

        private void ZaposleniForma_Load(object sender, EventArgs e)
        {
            popuniPodatke();
        }

        private void popuniPodatke()
        {
            listaZaposlenih.Items.Clear();

            List<ZaposleniBasic> zaposleni = DTOManager.vratiSveZaposlene();

            foreach (ZaposleniBasic z in zaposleni)
            {
                ListViewItem item = new ListViewItem(new string[] { z.ZaposleniId, z.Ime, z.Prezime, z.StrucnaSprema, z.TipZaposlenja, z.TipStruke });
                item.Tag = z;
                listaZaposlenih.Items.Add(item);
            }

            listaZaposlenih.Refresh();

        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate selektovati zaposlenog");
                return;
            }

            string jmbg = listaZaposlenih.SelectedItems[0].SubItems[0].Text;
            string tipZaposlenog = listaZaposlenih.SelectedItems[0].SubItems[5].Text;
            string tipZaposlenja = listaZaposlenih.SelectedItems[0].SubItems[4].Text;

            StringBuilder sb = new StringBuilder();

            if (tipZaposlenog == "EkonomskeStruke")
            {
                EkonomStrBasic zaposleni = DTOManager.vratiZaposlenogEkonom(jmbg);
                sb.AppendLine(zaposleni.Ime + " " + zaposleni.Prezime);
                sb.AppendLine("Datum rodjenja: " + zaposleni.DatumRodjenja.ToShortDateString());
                sb.AppendLine("Strucna sprema: " + zaposleni.StrucnaSprema);
                sb.AppendLine("Datum zaposlenja: " + zaposleni.DatumZaposlenja.ToShortDateString());
                sb.AppendLine("Godine radnog staza: " + (DateTime.Now.Year - zaposleni.DatumZaposlenja.Year));
                sb.AppendLine("Tip zaposlenja: " + zaposleni.TipZaposlenja);
                if (tipZaposlenja == "Stalno")
                {
                    sb.AppendLine("Plata: " + zaposleni.Plata);
                }
                else
                {
                    sb.AppendLine("Datum isteka ugovora:" + zaposleni.DatumIstekaUgovora);
                }
                sb.AppendLine("Tip struke: Ekonomske");

                if (zaposleni.PosedujeSertifikat == "Da")
                {
                    sb.AppendLine("Poseduje sertifikat");
                    sb.AppendLine("Datum sticanja sertifikata: " + zaposleni.DatumSticanja);
                }

            }
            else if (tipZaposlenog == "TehnickeStruke")
            {
                TehnickeStrBasic zaposleni = DTOManager.vratiZaposlenogTehnicke(jmbg);
                sb.AppendLine(zaposleni.Ime + " " + zaposleni.Prezime);
                sb.AppendLine("Datum rodjenja: " + zaposleni.DatumRodjenja.ToShortDateString());
                sb.AppendLine("Strucna sprema: " + zaposleni.StrucnaSprema);
                sb.AppendLine("Datum zaposlenja: " + zaposleni.DatumZaposlenja.ToShortDateString());
                sb.AppendLine("Godine radnog staza: " + (DateTime.Now.Year - zaposleni.DatumZaposlenja.Year));
                sb.AppendLine("Tip zaposlenja: " + zaposleni.TipZaposlenja);
                if (tipZaposlenja == "Stalno")
                {
                    sb.AppendLine("Plata: " + zaposleni.Plata);
                }
                else
                {
                    sb.AppendLine("Datum isteka ugovora:" + zaposleni.DatumIstekaUgovora);
                }
                sb.AppendLine("Tip struke: Tehnicke");

                sb.AppendLine("Naziv specijalnosti: " + zaposleni.NazivSpecijalnosti);
                sb.AppendLine("Datum sticanja specijalnosti: " + zaposleni.DatumSticanjaDiplome.ToShortDateString());
                sb.AppendLine("Institucija na kojoj je stekao specijalnost: " + zaposleni.Institucija);
            }
            else
            {
                ZaposleniView zaposleni = DTOManager.vratiZaposlenog(jmbg);
                sb.AppendLine(zaposleni.Ime + " " + zaposleni.Prezime);
                sb.AppendLine("Datum rodjenja: " + zaposleni.DatumRodjenja.ToShortDateString());
                sb.AppendLine("Strucna sprema: " + zaposleni.StrucnaSprema);
                sb.AppendLine("Datum zaposlenja: " + zaposleni.DatumZaposlenja.ToShortDateString());
                sb.AppendLine("Godine radnog staza: " + (DateTime.Now.Year - zaposleni.DatumZaposlenja.Year));
                sb.AppendLine("Tip zaposlenja: " + zaposleni.TipZaposlenja);
                if (tipZaposlenja == "Stalno")
                {
                    sb.AppendLine("Plata: " + zaposleni.Plata);
                }
                else
                {
                    sb.AppendLine("Datum isteka ugovora:" + zaposleni.DatumIstekaUgovora);
                }
                sb.AppendLine("Tip struke: Ostalo");
            }

            MessageBox.Show(sb.ToString());

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForma forma = new DodajZaposlenogForma();
            forma.ShowDialog();
            this.popuniPodatke();
        }
    }
}
