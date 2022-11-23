using GestionBibl.models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl
{
    internal class OuvrageController
    {
        public static MySqlConnection GetConnection() 
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionbibl";
            MySqlConnection con = new MySqlConnection();
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddCd(Cd cd)
        {
            string sql = "INSERT INTO ouvrage (id, cote, qntt, titre, auteur, type) Values (NULL, @cote, @qntt, @titre, @auteur, \"CD\")";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = cd.Cote;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = cd.Auteur;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = cd.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = cd.Titre;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le CD est ajouter avec success", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le CD n'est pas ajouter. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void AddLivre(Livre livre)
        {
            string sql = "INSERT INTO ouvrage (id, cote, qntt, titre, auteur, type, editeur) Values (NULL, @cote, @qntt, @titre, @auteur, \"Livre\", @editeur)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = livre.Cote;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = livre.Auteur;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = livre.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = livre.Titre;
            cmd.Parameters.Add("@editeur", MySqlDbType.VarChar).Value = livre.Editeur;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le LIVRE est ajouter avec success", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le LIVRE n'est pas ajouter. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void AddPeriodique(Periodique periodique)
        {
            string sql = "INSERT INTO ouvrage (id, cote, qntt, titre, nump, type, periodicite) Values (NULL, @cote, @qntt, @titre, @auteur, \"Periodique\", @periodicite)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = periodique.Cote;
            cmd.Parameters.Add("@nump", MySqlDbType.VarChar).Value = periodique.Nump;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = periodique.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = periodique.Titre;
            cmd.Parameters.Add("@periodicite", MySqlDbType.VarChar).Value = periodique.Periodicite;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Periodique est ajouter avec success", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le Periodique n'est pas ajouter. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateCd(Cd cd, string id)
        {
            string sql = "UPDATE INTO ouvrage SET cote = @cote, qntt = @qntt, titre = @titre, auteur = @auteur WHERE id = @cdId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = cd.Cote;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = cd.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = cd.Titre;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = cd.Auteur;
            cmd.Parameters.Add("@cdId", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le CD est modifie avec success.", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le CD n'est pas modifie.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateLivre(Livre livre, string id)
        {
            string sql = "UPDATE INTO ouvrage SET cote = @cote, qntt = @qntt, titre = @titre, auteur = @auteur, editeur = @editeur WHERE id = @cdId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = livre.Cote;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = livre.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = livre.Titre;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = livre.Auteur;
            cmd.Parameters.Add("@editeur", MySqlDbType.VarChar).Value = livre.Editeur;
            cmd.Parameters.Add("@cdId", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Livre est modifie avec success.", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le Livre n'est pas modifie.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdatePeriodique(Periodique periodique, string id)
        {
            string sql = "UPDATE INTO ouvrage SET cote = @cote, qntt = @qntt, titre = @titre, auteur = @nump, periodicite = @periodicite WHERE id = @cdId";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cote", MySqlDbType.VarChar).Value = periodique.Cote;
            cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = periodique.Stock;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = periodique.Titre;
            cmd.Parameters.Add("@periodicite", MySqlDbType.VarChar).Value = periodique.Periodicite;
            cmd.Parameters.Add("@nump", MySqlDbType.VarChar).Value = periodique.Nump;
            cmd.Parameters.Add("@cdId", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le Periodique est modifie avec success.", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le Periodique n'est pas modifie.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateStock(int stock, string id)
        {
            string sql = "UPDATE ouvrage SET qntt = @qntt WHERE id = 5";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@qntt", stock);
            /*cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = stock;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;*/
            MessageBox.Show(stock + "  " + id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le stock est modifie avec success.", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le stock n'est pas modifie.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*
                public static void UpdateStockOuvrageM(int stock, string id)
                {
                    int stq = 9;
                    string sql = "UPDATE INTO ouvrage SET qntt = @qntt WHERE id = @cdId";
                    MySqlConnection con = GetConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    *//*stq = stock--;*//*
                    cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = stq;
                    cmd.Parameters.Add("@cdId", MySqlDbType.VarChar).Value = id;
                    MessageBox.Show(stq + "  " + id );
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock updated. \n" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }

                public static void UpdateStockOuvrageP(int stock, string id)
                {
                    int stq = 0;
                    string sql = "UPDATE INTO ouvrage SET qntt = @qntt WHERE id = @cdId";
                    MySqlConnection con = GetConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    stq = stock++;
                    cmd.Parameters.Add("@qntt", MySqlDbType.VarChar).Value = stq;
                    cmd.Parameters.Add("@cdId", MySqlDbType.VarChar).Value = id;
                    MessageBox.Show("  " + stq + "  " + id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock updated. \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }*/

        public static void DeleteOuvrage(string id) 
        {
            string sql = "DELETE FROM ouvrage WHERE ID = @OuvrageID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@OuvrageID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "InformationError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ouvrage not deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
        }
    }
}
