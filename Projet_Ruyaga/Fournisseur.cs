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
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();

            afficherFournisseur("");
        }

        public void nettoyageForm()
        {
            bunifuTextBoxRecherche.Text = "";
            bunifuTextBoxNom.Text = "";
            bunifuTextBoxAdresse.Text = "";
            bunifuTextBoxAdresse.Text = "";
            bunifuTextBoxPhone.Text = "";
            textBoxID.Text = "";
            bunifuTextBoxRecherche.Text = "";
        }
        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }

        public void afficherFournisseur(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM fournisseur WHERE CONCAT(nom_prenom) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewFour.AllowUserToAddRows = false;
                bunifuDataGridViewFour.DataSource = dt;
                bunifuDataGridViewFour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void envent_Click_remplichageForm(object sender, EventArgs e)
        {
            textBoxID.Text = bunifuDataGridViewFour.CurrentRow.Cells[0].Value.ToString();
            bunifuTextBoxNom.Text = bunifuDataGridViewFour.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxAdresse.Text = bunifuDataGridViewFour.CurrentRow.Cells[2].Value.ToString();
            bunifuTextBoxPhone.Text = bunifuDataGridViewFour.CurrentRow.Cells[3].Value.ToString();
        }

        private void Evenement_TextChange_DeRecherche(object sender, EventArgs e)
        {
            afficherFournisseur(bunifuTextBoxRecherche.Text);
        }

        private void bunifuButtonNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxNom.Text != "")
                {
                    string requete = "INSERT INTO fournisseur(nom_prenom, adresse,phone) VALUES('" + this.bunifuTextBoxNom.Text + "','" + this.bunifuTextBoxAdresse.Text + "','" + this.bunifuTextBoxPhone.Text + "')";
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
                    afficherFournisseur(""); //affichage de la fonction d'affichage
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
                if (bunifuTextBoxNom.Text != "" && textBoxID.Text !="")
                {
                    connection.Open();
                    string requete = "UPDATE fournisseur SET nom_prenom ='" + bunifuTextBoxNom.Text + "' , adresse ='" + bunifuTextBoxAdresse.Text + "', phone ='" + bunifuTextBoxPhone.Text + "' WHERE id_fournisseur ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Fournisseur a été bien modifié");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherFournisseur(""); //affichage de la fonction d'affichage
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
                if (bunifuTextBoxNom.Text != "" && textBoxID.Text != "")
                {
                    connection.Open();
                    string requete = "DELETE FROM fournisseur WHERE id_fournisseur ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Le Fournisseur a été bien Supprimé");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherFournisseur(""); //affichage de la fonction d'affichage
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
