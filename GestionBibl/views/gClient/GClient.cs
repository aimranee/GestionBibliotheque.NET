using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBibl.controllers;

namespace GestionBibl.views
{
    public partial class GClient : UserControl
    {
        public GClient()
        {
            InitializeComponent();
        }

        private void GClient_Load(object sender, EventArgs e)
        {
            clearInputs();
            dataGridView.DataSource = controllerClient.LoadData();


        }


        public void Ajouter()
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
            {
                controllerClient.Ajouter(txtNom.Text, txtPrenom.Text, txtCIN.Text, comboBox1.Items[comboBox1.SelectedIndex].ToString());
                clearInputs();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

        }


        public void SearchData()
        {
            if (txtSrch.Text != "")
            {
                dataGridView.DataSource = controllerClient.Rechercher(txtSrch.Text);
            }
            else
            {
                dataGridView.DataSource = controllerClient.LoadData();
                MessageBox.Show("Veuillez remplir le champ du recherche");
            }


        }


        public void clearInputs()
        {
            txtCIN.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtId.Clear();
            comboBox1.SelectedIndex = -1;

        }


        public void Modifier()
        {
            if (txtId.Text != "")
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
                {
                    DialogResult result = MessageBox.Show("voulez-vous vraiment modifier le client ?", "Modifier", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        controllerClient.Modifier(txtNom.Text, txtPrenom.Text, txtCIN.Text, comboBox1.Items[comboBox1.SelectedIndex].ToString(), txtId.Text);
                        clearInputs();
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectioner le client que vous-voulez modifier");

            }



        }

        public void Supprimer()
        {
            if (txtId.Text != "")
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
                {
                    DialogResult result = MessageBox.Show("voulez-vous vraiment supprimer le client ?", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        controllerClient.Supprimer(txtId.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectioner le client que vous voulez supprimer");
            }




        }

       

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNom.Text = row.Cells["nom"].Value.ToString();
                txtPrenom.Text = row.Cells["prenom"].Value.ToString();
                txtCIN.Text = row.Cells["cin"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["statut"].Value.ToString();
                pictureBox_Modifier.Enabled = true;
                pictureBox_supprimer.Enabled = true;
            }
        }

       

        private void pictureBox_Rechercher_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void pictureBox_supprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
            dataGridView.DataSource = controllerClient.LoadData();
        }

        private void pictureBox_Modifier_Click(object sender, EventArgs e)
        {
            Modifier();
            dataGridView.DataSource = controllerClient.LoadData();
        }

        private void pictureBox_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter();
            dataGridView.DataSource = controllerClient.LoadData();
        }

        
    }
}
