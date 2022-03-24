using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_Ruyaga
{
    public partial class SortieStock : Form
    {
        public SortieStock(String Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas;//appel du login de l'utilisateur a partir du form d'authentification

            //afficherProduitComboBox();
            afficherStock("");
            afficherSortieStock("");
        }
        public void nettoyageForm()
        {
            textBoxID.Text = "";
            bunifuDropdownProduit.Text = "";
            bunifuTextBoxQuantite.Text = "";
            textBoxIdSortie.Text = "";
            bunifuTextBoxQteSortie.Text = "";
            bunifuTextBoxDestination.Text = "";
            bunifuTextBoxRetour.Text = "";
            bunifuTextBoxQuantiteSortie.Text = "";
        }

        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }
        //fonction affiche Produit comboBox
        public void afficherProduitComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM produit";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    bunifuDropdownProduit.Items.Add(lire.GetString("nom_produit"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void afficherStock(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM stock WHERE CONCAT(nom_produit) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewStock.AllowUserToAddRows = false;
                bunifuDataGridViewStock.DataSource = dt;
                bunifuDataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void envent_Click_remplichageFormStock(object sender, EventArgs e)
        {
            textBoxID.Text = bunifuDataGridViewStock.CurrentRow.Cells[0].Value.ToString();
            bunifuDropdownProduit.Text = bunifuDataGridViewStock.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxQuantite.Text = bunifuDataGridViewStock.CurrentRow.Cells[2].Value.ToString();
        }

        public void afficherSortieStock(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM sortieStock WHERE CONCAT(nom_produit) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewSortie.AllowUserToAddRows = false;
                bunifuDataGridViewSortie.DataSource = dt;
                bunifuDataGridViewSortie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void envent_Click_remplichageFormSortieStock(object sender, EventArgs e)
        {
            textBoxIdSortie.Text = bunifuDataGridViewSortie.CurrentRow.Cells[0].Value.ToString();
            bunifuDropdownProduit.Text = bunifuDataGridViewSortie.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxQuantiteSortie.Text = bunifuDataGridViewSortie.CurrentRow.Cells[2].Value.ToString();
            bunifuDateSortie.Text = bunifuDataGridViewSortie.CurrentRow.Cells[3].Value.ToString();
            bunifuTextBoxDestination.Text = bunifuDataGridViewSortie.CurrentRow.Cells[4].Value.ToString();
            //bunifuTextBoxQuantiteSortie.Text = bunifuDataGridViewSortie.CurrentRow.Cells[5].Value.ToString();
        }

        // Fonction event de recherche
        private void Evenement_TextChange_DeRecherche(object sender, EventArgs e)
        {
            afficherSortieStock(bunifuTextBoxRecherche.Text);
            afficherStock(bunifuTextBoxRecherche.Text);
        }

        public void updateStock()
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {
                
                    connection.Open();
                    string requete = "UPDATE stock SET quantite ='" + bunifuTextBoxQuantite.Text + "' - '" + bunifuTextBoxQteSortie.Text + "' WHERE id_stock ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                   // MessageBox.Show("Bien modifié");
                    afficherStock(""); //affichage de la fonction d'affichage
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuButtonNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxQuantite.Text != "" && bunifuDropdownProduit.Text != "" && bunifuTextBoxQteSortie.Text != "")
                {
                    if (double.Parse(bunifuTextBoxQteSortie.Text) <= double.Parse(bunifuTextBoxQuantite.Text))
                    {
                        updateStock(); //appel fonction updateStock

                        string requete = "INSERT INTO sortieStock(nom_produit,quantite,date_sortie,destination,quantite_Retourne,utilisateur) VALUES('" + this.bunifuDropdownProduit.Text + "','" + this.bunifuTextBoxQteSortie.Text + "','" + this.bunifuDateSortie.Text + "','" + this.bunifuTextBoxDestination.Text + "',0,'"+ this.textBoxUser.Text +"')";
                        MySqlCommand inserer = new MySqlCommand(requete, connection);
                        MySqlDataReader lire;

                        connection.Open();
                        lire = inserer.ExecuteReader();

                        MessageBox.Show("Success");

                        while (lire.Read())
                        {
                            connection.Close();
                        }

                        nettoyageForm(); //nettoyagedu formulaire
                        afficherSortieStock(""); //affichage de la fonction d'affichage
                    }
                    else
                    {
                        MessageBox.Show("La Quantité Stockée n'est pas assez suffisante ou bien c'est épuisé", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Problem of Connection to the Database", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        public void updateStockRetour()
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET quantite = quantite + '" + bunifuTextBoxRetour.Text + "' WHERE nom_produit  ='" + bunifuDropdownProduit.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                // MessageBox.Show("Bien modifié");
                afficherStock(""); //affichage de la fonction d'affichage


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void retournerProduit()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxQuantiteSortie.Text != "" && bunifuDropdownProduit.Text != "" && bunifuTextBoxRetour.Text != "")
                {
                    if (double.Parse(bunifuTextBoxQuantiteSortie.Text) >= double.Parse(bunifuTextBoxRetour.Text))
                    {
                        updateStockRetour();

                        connection.Open();
                        string requete = "UPDATE SortieStock SET quantite_Retourne = quantite_Retourne + '" + bunifuTextBoxRetour.Text + "', quantite = quantite - '" + bunifuTextBoxRetour.Text + "' WHERE id_sortie ='" + textBoxIdSortie.Text + "'";
                        MySqlCommand modifier = new MySqlCommand(requete, connection);

                        modifier.Connection = connection;
                        modifier.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("La Quantité a été bien Retournée");
                        nettoyageForm(); //nettoyagedu formulaire
                        afficherSortieStock(""); //affichage de la fonction d'affichage
                    }
                    else
                    {
                        MessageBox.Show("La Quantité Retournée est Supérieure à la Quantité Sortie", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Problem of Connection to the Database", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonRetour_Click(object sender, EventArgs e)
        {
            retournerProduit();
        }
    }
}
