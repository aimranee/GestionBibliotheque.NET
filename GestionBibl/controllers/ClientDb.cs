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
    internal class ClientDb
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=client";
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

        public static void AjouterClient (Client client)
        {
            string sql = "INSERT INTO client_tab VALUES (NULL, @ClientName, @ClientPrenom, @ClientCin)";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClientName", MySqlDbType.VarChar).Value = client.Name;
            cmd.Parameters.Add("@ClientPrenom", MySqlDbType.VarChar).Value = client.Prenom;
            cmd.Parameters.Add("@ClientCin", MySqlDbType.VarChar).Value = client.CIN;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client ajouter aves success.","Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show("Le client n'est pas ajouter ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void UpdateClient(Client client)
        {
            string sql = "UPDATE client_tab SET nom = @ClientName, prenom = @ClientPrenom, cin = @ClientCin";
            MySqlConnection cnn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClientName", MySqlDbType.VarChar).Value = client.Name;
            cmd.Parameters.Add("@ClientPrenom", MySqlDbType.VarChar).Value = client.Prenom;
            cmd.Parameters.Add("@ClientCin", MySqlDbType.VarChar).Value = client.CIN;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client modifier aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Le client n'est pas modifier ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

        public static void SupprimerClient (int id)
        {
            string sql = "DELETE FROM client_table WHERE id = @id";
            MySqlConnection cnn = GetConnection ();
            MySqlCommand cmd = new MySqlCommand (sql, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client supprimer aves success.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Le client n'est pas supprimer ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnn.Close();
        }

    }
}
