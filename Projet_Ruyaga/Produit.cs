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
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();

            afficherProduit("");
        }

        private void Produit_Load(object sender, EventArgs e)
        {

        }
       
        public void nettoyageForm()
        {
            bunifuTextBoxNomProd.Text = "";
            bunifuTextBoxTypeProd.Text = "";
            textBoxID.Text = "";
            bunifuTextBoxRecherche.Text = "";
        }
        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }

        public void afficherProduit(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM produit WHERE CONCAT(nom_produit, type_produit) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewProd.AllowUserToAddRows = false;
                bunifuDataGridViewProd.DataSource = dt;
                bunifuDataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

/*
                //les outils pour compter les bres des produits
                int effectif = dataGridViewAgence.RowCount;
                double nombre = effectif;
                textBoxTotalAgence.Text = nombre.ToString();

                // textBoxEffectifProduit.Text = Convert.ToString(nombre);
*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void envent_Click_remplichageForm(object sender, EventArgs e)
        {
            textBoxID.Text = bunifuDataGridViewProd.CurrentRow.Cells[0].Value.ToString();
            bunifuTextBoxNomProd.Text = bunifuDataGridViewProd.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxTypeProd.Text = bunifuDataGridViewProd.CurrentRow.Cells[2].Value.ToString();
        }

        private void EvenementDeRecherche(object sender, EventArgs e)
        {
            afficherProduit(bunifuTextBoxRecherche.Text);
        }

        private void bunifuButtonNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxNomProd.Text != "")
                {
                    string requete = "INSERT INTO produit(nom_produit, type_produit) VALUES('" + this.bunifuTextBoxNomProd.Text + "','" + this.bunifuTextBoxTypeProd.Text + "')";
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
                    afficherProduit(""); //affichage de la fonction d'affichage
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

        private void bunifuButtonMod_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {
                if (bunifuTextBoxNomProd.Text != "" && textBoxID.Text != "")
                {
                    connection.Open();
                    string requete = "UPDATE produit SET nom_produit='" + bunifuTextBoxNomProd.Text + "' , type_produit='" + bunifuTextBoxTypeProd.Text + "' WHERE id_prod='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Produit a été bien modifié");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherProduit(""); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonSup_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {
                if (bunifuTextBoxNomProd.Text != "" && textBoxID.Text != "")
                {
                    connection.Open();
                    string requete = "DELETE FROM produit WHERE id_prod='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Produit a été bien Supprimé");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherProduit(""); //affichage de la fonction d'affichage
                }
                else
                {
                    MessageBox.Show("Veillez bien remplir vos champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
