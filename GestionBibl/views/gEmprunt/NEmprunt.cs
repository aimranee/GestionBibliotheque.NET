using GestionBibl.controllers;
using GestionBibl.models;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionBibl.views
{
    public partial class NEmprunt : Form
    {

        private readonly GEmpunts _prunt;
        public string idC, idO;
        public DateTime dateD;
        public DateTime dateF;
        public int stock = 0;

        public NEmprunt(GEmpunts prunt)
        {
            InitializeComponent();
            _prunt = prunt;
            Dispaly();
        }

        public void UpdateEmprunt()
        {
            label1.Text = "Éditer Emrunt";
            button5.Text = "Editer";
            ClientId.Text = idC;
            OuvrageId.Text = idO;
            dateTimePicker.Value = dateD;
            dateTimePicker1.Value = dateF;
        }

        public void Dispaly()
        {
            EmpruntController.DisplayAndSearch("SELECT id, nom, prenom, statut FROM client", dataGridView1);
            EmpruntController.DisplayAndSearch("SELECT id, titre, type, qntt FROM ouvrage", dataGridView2);
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Clear()
        {
            ClientId.Text = OuvrageId.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ClientId.Text.Trim().Length < 1)
            {
                MessageBox.Show("Vous devez choisisez le client");
                return;
            }
            if (OuvrageId.Text.Trim().Length < 1)
            {
                MessageBox.Show("Vous devez choisisez l'ouvrage");
                return;
            }
            if (dateTimePicker.Value >= dateTimePicker1.Value)
            {
                MessageBox.Show("Vous devez choisisez la date de rendre");
                return;
            }
            if (button5.Text == "Enregistrer")
            {
                Emprunt emprunt = new Emprunt(ClientId.Text.Trim(), OuvrageId.Text.Trim(), dateTimePicker.Value.ToString(), dateTimePicker1.Value.ToString());
                
                EmpruntController.AjouterEmprunt(emprunt, stock);

                Clear();
            }
            if (button5.Text == "Editer")
            {

                Emprunt emprunt = new Emprunt(ClientId.Text.Trim(), OuvrageId.Text.Trim(), dateTimePicker.Value.ToString(), dateTimePicker1.Value.ToString());
                EmpruntController.UpdateEmprunt(emprunt, idC, idO);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmpruntController.DisplayAndSearch("SELECT id, titre, type, qntt FROM ouvrage WHERE titre LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            EmpruntController.DisplayAndSearch("SELECT id, nom, prenom, statut FROM client WHERE nom LIKE '%" + textBox2.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ClientId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if (int.Parse(row.Cells[3].Value.ToString()!) < 1)
                {
                    MessageBox.Show("Le stock est vide!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    stock = int.Parse(row.Cells[3].Value.ToString()!);
                    OuvrageId.Text = row.Cells[0].Value.ToString();
                }
                
            }
        }
    }
}
