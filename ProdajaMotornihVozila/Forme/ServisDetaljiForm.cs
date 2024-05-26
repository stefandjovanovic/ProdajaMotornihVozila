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
    public partial class ServisDetaljiForm : Form
    {
        private int idRadnje;
        public ServisDetaljiForm(int idRadnje)
        {
            InitializeComponent();
            this.idRadnje = idRadnje;
        }

        private void ServisDetaljiForm_Load(object sender, EventArgs e)
        {
            try
            {
                ServisView servis = DTOManager.detaljiServis(idRadnje);

                labelStepenOpr.Text += " " + servis.StepenOpremljenosti;
                labelFarbarske.Text += " " + servis.Farbarske;
                labelLimarske.Text += " " + servis.Limarske;
                labelVulkanizerske.Text += " " + servis.Vulkanizerske;
                labelMehanicarske.Text += " " + servis.Mehanicarske;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServisVisegNizegRangaView servis = DTOManager.servisVisegRanga(idRadnje);
                MessageBox.Show("Servis viseg ranga: " + servis.Adresa + " " + servis.Grad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<ServisVisegNizegRangaView> servisi = DTOManager.servisiNizegRanga(idRadnje);
                if(servisi.Count == 0)
                {
                    MessageBox.Show("Nema servisa nizeg ranga");
                    return;
                }
                StringBuilder sb = new StringBuilder();
                foreach (ServisVisegNizegRangaView servis in servisi)
                {
                    sb.Append(servis.Adresa + " " + servis.Grad + "\n");
                }
                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
