using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMotornihVozila.Forme.PredstavnistvoForme
{
    enum tipRadnje
    { 
        SERVIS,
        SALON,
        SERVIS_I_SALON
    }


    public partial class UrediRadnjuForma : Form
    {
        private tipRadnje tipRadnje;
        private bool rezimIzmene = false;
        private int idPredstavnistva;
        public UrediRadnjuForma(int idPredstavnistva)
        {
            this.tipRadnje = tipRadnje.SERVIS;
            this.idPredstavnistva = idPredstavnistva;
            InitializeComponent();
        }

        public UrediRadnjuForma(int idPredstavnistva, string tip)
        {
            this.idPredstavnistva = idPredstavnistva;
            if (tip == "SERVIS")
            {
                this.tipRadnje = tipRadnje.SERVIS;
            }
            else if (tip == "SALON")
            {
                this.tipRadnje = tipRadnje.SALON;
            }
            else if (tip == "SERVIS_I_SALON")
            {
                this.tipRadnje = tipRadnje.SERVIS_I_SALON;
            }
            this.rezimIzmene = true;
            InitializeComponent();
        }

        private void UrediRadnjuForma_Load(object sender, EventArgs e)
        {
            if (this.tipRadnje == tipRadnje.SERVIS)
            {
                this.comboBoxTipRadnje.SelectedIndex = 0;
            }
            else if (this.tipRadnje == tipRadnje.SALON)
            {
                this.comboBoxTipRadnje.SelectedIndex = 1;
            }
            else if (this.tipRadnje == tipRadnje.SERVIS_I_SALON)
            {
                this.comboBoxTipRadnje.SelectedIndex = 2;
            }
            comboBoxStepenOpr.SelectedIndex = 0;

            if (rezimIzmene)
            {
                button1.Text = "Izmeni";
                if (this.tipRadnje == tipRadnje.SERVIS || this.tipRadnje == tipRadnje.SERVIS_I_SALON)
                {
                    RadnjaView radnja = DTOManager.prikaziSadrzaj(this.idPredstavnistva);

                    ServisView servis = DTOManager.detaljiServis(radnja.Id);
                    comboBoxStepenOpr.SelectedItem = servis.StepenOpremljenosti;
                    if (servis.Limarske == "Da")
                        checkBoxLimarske.Checked = true;
                    else
                        checkBoxLimarske.Checked = false;
                    if (servis.Mehanicarske == "Da")
                        checkBoxMehanicarske.Checked = true;
                    else
                        checkBoxMehanicarske.Checked = false;
                    if (servis.Vulkanizerske == "Da")
                        checkBoxVulkanizerske.Checked = true;
                    else
                        checkBoxVulkanizerske.Checked = false;
                    if (servis.Farbarske == "Da")
                        checkBoxFarbarske.Checked = true;
                    else
                        checkBoxFarbarske.Checked = false;
                    if (radnja.JmbgSefa != null)
                    {
                        textBoxJMBG.Text = radnja.JmbgSefa;
                    }
                    try
                    {
                        ServisVisegNizegRangaView visegRanga = DTOManager.servisVisegRanga(radnja.Id);
                        if (visegRanga != null)
                        {
                            textBoxServisVisegRanga.Text = visegRanga.Id.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                    }

                }
            }

        }

        private void comboBoxStepenOpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxJMBG.Text.Length != 13 && textBoxJMBG.Text.Length != 0)
            {
                MessageBox.Show("JMBG mora imati 13 cifara!");
                return;
            }
            string? jmbgSefa = textBoxJMBG.Text.Length == 0 ? null : textBoxJMBG.Text;

            string stepenOpremljenosti = comboBoxStepenOpr.SelectedItem.ToString();
            string limarske = checkBoxLimarske.Checked ? "Da" : "Ne";
            string mehanicarske = checkBoxMehanicarske.Checked ? "Da" : "Ne";
            string vulkanizerske = checkBoxVulkanizerske.Checked ? "Da" : "Ne";
            string farbarske = checkBoxFarbarske.Checked ? "Da" : "Ne";
            MessageBox.Show(farbarske + limarske + vulkanizerske + mehanicarske);
            int? idServisVisegRanga = textBoxServisVisegRanga.Text.Length == 0 ? null : Int32.Parse(textBoxServisVisegRanga.Text);

            try
            {
                if (tipRadnje == tipRadnje.SERVIS)
                {
                    ServisBasic servis = new ServisBasic(this.idPredstavnistva, stepenOpremljenosti, farbarske, limarske, vulkanizerske, mehanicarske, jmbgSefa, idServisVisegRanga);

                    if (rezimIzmene)
                    {
                        DTOManager.AzurirajServis(servis);

                    }
                    else
                    {
                        DTOManager.DodajServis(servis);
                    }
                }
                else if (tipRadnje == tipRadnje.SALON)
                {
                    SalonBasic salon = new SalonBasic(this.idPredstavnistva, jmbgSefa);
                    if (rezimIzmene)
                    {
                        DTOManager.AzurirajSalon(salon);
                    }
                    else
                    {
                        DTOManager.DodajSalon(salon);
                    }
                }
                else if (tipRadnje == tipRadnje.SERVIS_I_SALON)
                {
                    ServisISalonBasic servisISalon = new ServisISalonBasic(this.idPredstavnistva, stepenOpremljenosti, farbarske, limarske, vulkanizerske, mehanicarske, jmbgSefa, idServisVisegRanga);
                    if (rezimIzmene)
                    {
                        DTOManager.AzurirajServisISalon(servisISalon);
                    }
                    else
                    {
                        DTOManager.DodajServisISalon(servisISalon);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void comboBoxTipRadnje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipRadnje.SelectedIndex == 0)
            {
                checkBoxLimarske.Enabled = true;
                checkBoxMehanicarske.Enabled = true;
                checkBoxVulkanizerske.Enabled = true;
                checkBoxFarbarske.Enabled = true;

                comboBoxStepenOpr.Enabled = true;
                textBoxServisVisegRanga.Enabled = true;

                this.tipRadnje = tipRadnje.SERVIS;
            }
            else if (comboBoxTipRadnje.SelectedIndex == 2)
            {
                checkBoxLimarske.Enabled = true;
                checkBoxMehanicarske.Enabled = true;
                checkBoxVulkanizerske.Enabled = true;
                checkBoxFarbarske.Enabled = true;

                comboBoxStepenOpr.Enabled = true;
                textBoxServisVisegRanga.Enabled = true;

                this.tipRadnje = tipRadnje.SERVIS_I_SALON;
            }
            else
            {
                checkBoxLimarske.Enabled = false;
                checkBoxMehanicarske.Enabled = false;
                checkBoxVulkanizerske.Enabled = false;
                checkBoxFarbarske.Enabled = false;

                comboBoxStepenOpr.Enabled = true;
                textBoxServisVisegRanga.Enabled = true;

                this.tipRadnje = tipRadnje.SALON;
            }
        }
    }
}
