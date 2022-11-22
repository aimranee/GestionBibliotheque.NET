using GestionBibl.controllers;
using GestionBibl.views;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibl
{
    public partial class GEmpunts : UserControl
    {
        NEmprunt formEmprunt;
        public int stock = 0;
        public GEmpunts()
        {
            InitializeComponent();
            formEmprunt = new NEmprunt(this);
            Dispaly();
        }

        private void GEmpunts_Load(object sender, EventArgs e)
        {
            Dispaly();
        }

        public void Dispaly()
        {
            EmpruntController.DisplayAndSearch("SELECT clientid, ouvrageid, dateEmprunt, dateRendre FROM emprunt", dataGridView);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formEmprunt.Clear();
            formEmprunt.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispaly();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formEmprunt.Clear();
                formEmprunt.idC = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()!;
                formEmprunt.idO = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!;
                formEmprunt.dateD = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()!);
                formEmprunt.dateF = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()!);
                formEmprunt.UpdateEmprunt();
                formEmprunt.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Souhaitez-vous supprimer l'emprunt ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    stock = int.Parse(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()!);
                    EmpruntController.SupprimerEmprunt(stock, dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()!, dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!);
                }

                return;
            }
        }

        private void ClientName_TextChanged(object sender, EventArgs e)
        {
            EmpruntController.DisplayAndSearch("SELECT clientid, ouvrageid, dateEmprunt, dateRendre FROM emprunt WHERE clientid LIKE '%"+ SearchB.Text+"%'", dataGridView);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            formEmprunt.Clear();
            formEmprunt.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dispaly();
        }
    }
}
