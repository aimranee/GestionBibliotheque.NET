using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.controllers
{
    public class controllerClient
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionbibl";
            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void Ajouter(string nom, string prenom, string cin, string statut)
        {
            MySqlConnection conn = GetConnection();
            string LoadData = "insert into client(nom,prenom,cin,statut) values('" + nom + "','" + prenom + "','" + cin + "','" + statut + "');";
            MySqlCommand cmd = new MySqlCommand(LoadData, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client est ajouté aves succés.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Le client n'est pas ajouté ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();


        }

        public static void Modifier(string nom, string prenom, string cin, string statut, string id)
        {
            MySqlConnection conn = GetConnection();
            string LoadData = "update client set nom='" + nom + "',prenom='" + prenom + "',cin='" + cin + "',statut='" + statut + "' where id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(LoadData, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client est modifié aves succés.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Le client n'est pas modifié ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();


        }

        public static void Supprimer(string id)
        {
            MySqlConnection conn = GetConnection();
            string LoadData = "delete from client where id=" + id;
            MySqlCommand cmd = new MySqlCommand(LoadData, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client est supprimé aves succés.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Le client n'est pas supprimer ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        public static DataTable Rechercher(string cin)
        {
            MySqlConnection conn = GetConnection();
            string loadData = "select * from client where cin='" + cin + "'";
            MySqlCommand cmd = new MySqlCommand(loadData, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public static DataTable LoadData()
        {
            MySqlConnection conn = GetConnection();
            string loadData = "select * from client";
            MySqlCommand cmd = new MySqlCommand(loadData, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            return dt;
        }
    }
}
