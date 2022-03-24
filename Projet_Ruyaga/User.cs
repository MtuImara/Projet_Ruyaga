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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();


            afficherUser("");
        }

        public void nettoyageForm()
        {
            bunifuTextBoxRecherche.Text = "";
            bunifuTextBoxNom.Text = "";
            bunifuTextBoxLogin.Text = "";
            bunifuTextBoxPrénom.Text = "";
            textBoxID.Text = "";
            bunifuTextBoxPassword.Text = "";
        }
        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }

        public void afficherUser(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM utilisateurs WHERE CONCAT(nom,prenom,login) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewUser.AllowUserToAddRows = false;
                bunifuDataGridViewUser.DataSource = dt;
                bunifuDataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void envent_Click_remplichageForm(object sender, EventArgs e)
        {
            textBoxID.Text = bunifuDataGridViewUser.CurrentRow.Cells[0].Value.ToString();
            bunifuTextBoxNom.Text = bunifuDataGridViewUser.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxPrénom.Text = bunifuDataGridViewUser.CurrentRow.Cells[2].Value.ToString();
            bunifuTextBoxLogin.Text = bunifuDataGridViewUser.CurrentRow.Cells[3].Value.ToString();
            bunifuTextBoxPassword.Text = bunifuDataGridViewUser.CurrentRow.Cells[4].Value.ToString();
        }

        private void Evenement_TextChange_DeRecherche(object sender, EventArgs e)
        {
            afficherUser(bunifuTextBoxRecherche.Text);
        }
        private void bunifuButtonNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxNom.Text != "" && bunifuTextBoxPrénom.Text != "" && bunifuTextBoxPassword.Text != "" && bunifuTextBoxLogin.Text != "")
                {
                    string requete = "INSERT INTO utilisateurs(nom,prenom,login,password) VALUES('" + this.bunifuTextBoxNom.Text + "','" + this.bunifuTextBoxPrénom.Text + "','" + this.bunifuTextBoxLogin.Text + "','" + this.bunifuTextBoxPassword.Text + "')";
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
                    afficherUser(""); //affichage de la fonction d'affichage
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

        private void bunifuButtonMod_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {
                if(bunifuTextBoxNom.Text != "" && bunifuTextBoxPrénom.Text != "" && textBoxID.Text != "" && bunifuTextBoxPassword.Text != "" && bunifuTextBoxLogin.Text != "")
                {
                    connection.Open();
                    string requete = "UPDATE utilisateurs SET nom ='" + bunifuTextBoxNom.Text + "' , prenom ='" + bunifuTextBoxPrénom.Text + "', login ='" + bunifuTextBoxLogin.Text + "', password ='" + bunifuTextBoxPassword.Text + "' WHERE id_login ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("L'Utilisateur a été bien modifié");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherUser(""); //affichage de la fonction d'affichage
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
                if (bunifuTextBoxNom.Text != "" && bunifuTextBoxPrénom.Text != "" && bunifuTextBoxPassword.Text != "" && bunifuTextBoxLogin.Text != "" && textBoxID.Text !="")
                {
                    connection.Open();
                    string requete = "DELETE FROM utilisateurs WHERE id_login ='" + textBoxID.Text + "'";

                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("L'Utilisateur a été bien supprimé");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherUser(""); //affichage de la fonction d'affichage
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
