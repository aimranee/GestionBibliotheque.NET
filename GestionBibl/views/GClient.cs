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

namespace GestionBibl.views
{
    public partial class GClient : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataTable dt;
        string conString = "server=localhost;uid=root;password=;database=gestionbiblio";

        public GClient()
        {
            InitializeComponent();
        }

        private void GClient_Load(object sender, EventArgs e)
        {
            clearInputs();
            dataGridView.DataSource = LoadData();


        }

        public DataTable LoadData()
        {
            conn = new(conString);
            string LoadData = "select * from client";
            conn.Open();
            cmd=new MySqlCommand(LoadData,conn);
            reader = cmd.ExecuteReader();
            dt=new DataTable();
            dt.Load(reader);
            conn.Close();
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            return dt;
            
        }
        public void Ajouter()
        {
            if(txtNom.Text!="" && txtPrenom.Text!="" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
            {
                conn = new(conString);
                string LoadData = "insert into client(nom,prenom,cin,statut) values('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtCIN.Text + "','" + comboBox1.Items[comboBox1.SelectedIndex].ToString() + "');";
                conn.Open();
                cmd = new MySqlCommand(LoadData, conn);
                int resp = cmd.ExecuteNonQuery();
                conn.Close();
                if (resp == 0)
                {
                    MessageBox.Show("Echec d'ajout !");
                }
                else
                {
                    MessageBox.Show("Le Client est ajouter avec succes");
                    clearInputs();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            
        }


        public void SearchData()
        {
            if(txtSrch.Text!="")
            {
                conn = new(conString);
                string loadData = "select * from client where cin='" + txtSrch.Text+"'";
                conn.Open();
                cmd = new MySqlCommand(loadData, conn);
                reader = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dataGridView.DataSource = dt;
                conn.Close();
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
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
            if(txtId.Text != "")
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
                {
                    conn = new(conString);
                    string LoadData = "update client set nom='" + txtNom.Text + "',prenom='" + txtPrenom.Text + "',cin='" + txtCIN.Text + "',statut='" + comboBox1.Items[comboBox1.SelectedIndex].ToString() + "' where id=" + txtId.Text + ";";
                    conn.Open();
                    cmd = new MySqlCommand(LoadData, conn);
                    int resp = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (resp == 0)
                    {
                        MessageBox.Show("Echec de modification !");
                    }
                    else
                    {
                        MessageBox.Show("Client modifier avec succes");
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
                MessageBox.Show("Veuillez selectioner le client que vous voulez modifier");

            }



        }

        public void Supprimer()
        {
            if(txtId.Text != "")
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && txtCIN.Text != "" && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
                {
                    DialogResult result = MessageBox.Show("voulez vous vraiment supprimer le client ?", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        conn = new(conString);
                        string LoadData = "delete from client where id=" + txtId.Text;
                        conn.Open();
                        cmd = new MySqlCommand(LoadData, conn);
                        int resp = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (resp == 0)
                        {
                            MessageBox.Show("Echec de suppression !");
                        }
                        else
                        {
                            MessageBox.Show("Le Client est supprimer avec succes");
                            clearInputs();
                        }
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
            dataGridView.DataSource = LoadData();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNom.Text = row.Cells["nom"].Value.ToString();
                txtPrenom.Text = row.Cells["prenom"].Value.ToString();
                txtCIN.Text = row.Cells["cin"].Value.ToString();
                comboBox1.SelectedItem=row.Cells["statut"].Value.ToString();
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier();
            dataGridView.DataSource = LoadData();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
            dataGridView.DataSource = LoadData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
