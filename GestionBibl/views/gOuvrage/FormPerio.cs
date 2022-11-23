using GestionBibl.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibl.views
{
    public partial class FormPerio : Form
    {
        public FormPerio()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Clear();
            this.Close();
        }
        public void Dispaly()
        {
            EmpruntController.DisplayAndSearch("SELECT id, cote, titre, qntt, nump, periodicite FROM ouvrage WHERE type LIKE '%Per%'", dataGridView);
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
    }
}
