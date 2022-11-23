using GestionBibl.controllers;
using GestionBibl.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibl.views.gOuvrage
{
    public partial class FormOuvrage : Form
    {
        public FormOuvrage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Vous devez choisisez la date de rendre");
                return;
            }
            if (button5.Text == "Enregistrer")
            {
                Cd cd = new Cd(auteur.Text.Trim(),Convert.ToInt32(stock.Text.Trim()), Cote.Text.Trim(), titre.Text.Trim(), "CD");
                OuvrageController.AddCd(cd);
                /*OuvrageController.UpdateStockOuvrageM(stock, emprunt.OuvrageId);*/
                //Clear();
                this.Hide();
            }
            if (button5.Text == "Editer")
            {

                /*Emprunt emprunt = new Emprunt(OuvrageId.Text.Trim(), ClientId.Text.Trim(), dateTimePicker.Value.ToString(), dateTimePicker1.Value.ToString());
                EmpruntController.UpdateEmprunt(emprunt, idC, idO);
                Clear();*/
                this.Hide();
            }
        }
    }
}
