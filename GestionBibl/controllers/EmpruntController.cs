using GestionBibl.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.controllers
{
    internal class EmpruntController
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionbibl";
            MySqlConnection cnn = new MySqlConnection(sql);

            try
            {
                cnn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cnn;
        }

        public static void AjouterEmprunt(Emprunt emprunt)
        {
            string sql = "INSERT INTO emprunt VALUES (@ClientId, @OuvrageId, @dateEmprunt, @dateRendre)";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClientId", MySqlDbType.VarChar).Value = emprunt.ClientId;
            cmd.Parameters.Add("@OuvrageId", MySqlDbType.VarChar).Value = emprunt.OuvrageId;
            cmd.Parameters.Add("@dateEmprunt", MySqlDbType.VarChar).Value = emprunt.DateEmprunt;
            cmd.Parameters.Add("@dateRendre", MySqlDbType.VarChar).Value = emprunt.DateRendre;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'emprunt ajouter aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'emprunt n'est pas ajouter ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void UpdateEmprunt(Emprunt emprunt, string idC, string idO)
        {
            string sql = "UPDATE emprunt SET clientId = @clientId, ouvrageId = @ouvrageId, dateEmprunt = @dateEmprunt, dateRendre = @dateRendre WHERE clientId = @idC and ouvrageId = @idO";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@clientId", MySqlDbType.VarChar).Value = emprunt.ClientId;
            cmd.Parameters.Add("@ouvrageId", MySqlDbType.VarChar).Value = emprunt.OuvrageId;
            cmd.Parameters.Add("@dateEmprunt", MySqlDbType.VarChar).Value = emprunt.DateEmprunt;
            cmd.Parameters.Add("@dateRendre", MySqlDbType.VarChar).Value = emprunt.DateRendre;
            cmd.Parameters.Add("@idC", MySqlDbType.VarChar).Value = idC;
            cmd.Parameters.Add("@idO", MySqlDbType.VarChar).Value = idO;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'emprunt modifier aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'emprunt n'est pas modifier ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void SupprimerEmprunt(string idC, string idO)
        {
            string sql = "DELETE FROM emprunt WHERE clientId = @clientId and ouvrageId = @ouvrageId";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@clientId", MySqlDbType.VarChar).Value = idC;
            cmd.Parameters.Add("@ouvrageId", MySqlDbType.VarChar).Value = idO;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'emprunt supprimer aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'emprunt n'est pas supprimer ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void DisplayAndSearch (string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

    }
}
