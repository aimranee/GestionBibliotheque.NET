using GestionBibl.controllers;
using GestionBibl.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionBibl
{ 
    public partial class GOuvrages : UserControl
    {
        FormPerio formPerio;
        FormCd formCd;
        FormLivre formLivre;
        public GOuvrages()
        {
            InitializeComponent();
            formCd = new FormCd();
            formPerio = new FormPerio();
            formLivre = new FormLivre();
            Dispaly();
        }

        public void Dispaly()
        {
            EmpruntController.DisplayAndSearch("SELECT id, cote, titre, type, qntt FROM ouvrage", dataGridView);
        }

        private void GOuvrages_Load(object sender, EventArgs e)
        {
            Dispaly();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                /*formOuvrage.Clear();
                formOuvrage.idO = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!;
                formOuvrage.idC = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()!;
                formOuvrage.dateD = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()!);
                formOuvrage.dateF = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()!);
                formOuvrage.UpdateEmprunt();
                formOuvrage.ShowDialog();*/

                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Souhaitez-vous supprimer l'emprunt ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //stock = Int16.Parse(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString()!)+1;
                    //OuvrageController.UpdateStock(stock, dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!);
                    EmpruntController.SupprimerEmprunt(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()!, dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!);

                }

                return;
            }
        }

        private void SearchB_TextChanged(object sender, EventArgs e)
        {
            EmpruntController.DisplayAndSearch("SELECT id, cote, titre, type, qntt FROM ouvrage WHERE cote LIKE '%" + SearchB.Text + "%'", dataGridView);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formCd.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            formLivre.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            formPerio.ShowDialog();
        }
    }
}
