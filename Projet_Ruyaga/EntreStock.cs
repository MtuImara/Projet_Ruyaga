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
    public partial class EntreStock : Form
    {
        public EntreStock(String Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas;//appel du login de l'utilisateur a partir du form d'authentification

            afficherEntreeStock("");
            afficherProduitComboBox();
            afficherFournisseurComboBox();
            
        }

        public void nettoyageForm()
        {
            bunifuTextBoxRecherche.Text = "";
            bunifuTextBoxQuantite.Text = "";
            bunifuTextBoxOrigine.Text = "";
            bunifuDropdownProduit.Text = "";
            bunifuDropdownFournisseur.Text = "";
            textBoxID.Text = "";
            richTextBoxObservation.Text = "";
            bunifuDateEntree.Text = "";
            textBoxQteMod.Text = "";
        }

        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyageForm();
        }

        //Ajout nouveau produit
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.Show();
        }

        //Ajout nouveau fournisseur
        private void bunifuButtonFournisseur_Click(object sender, EventArgs e)
        {
            Fournisseur f = new Fournisseur();
            f.Show();
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

        //fonction affiche Fournisseur comboBox
        public void afficherFournisseurComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM fournisseur";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    bunifuDropdownFournisseur.Items.Add(lire.GetString("nom_prenom"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void afficherEntreeStock(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT * FROM entreeStock WHERE CONCAT(nom_produit,fournisseur) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                bunifuDataGridViewEntree.AllowUserToAddRows = false;
                bunifuDataGridViewEntree.DataSource = dt;
                bunifuDataGridViewEntree.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void envent_Click_remplichageForm(object sender, EventArgs e)
        {
            textBoxID.Text = bunifuDataGridViewEntree.CurrentRow.Cells[0].Value.ToString();
            bunifuDropdownProduit.Text = bunifuDataGridViewEntree.CurrentRow.Cells[1].Value.ToString();
            bunifuTextBoxQuantite.Text = bunifuDataGridViewEntree.CurrentRow.Cells[2].Value.ToString();
            bunifuDateEntree.Text = bunifuDataGridViewEntree.CurrentRow.Cells[3].Value.ToString();
            bunifuTextBoxOrigine.Text = bunifuDataGridViewEntree.CurrentRow.Cells[4].Value.ToString();
            bunifuDropdownFournisseur.Text = bunifuDataGridViewEntree.CurrentRow.Cells[5].Value.ToString();
            richTextBoxObservation.Text = bunifuDataGridViewEntree.CurrentRow.Cells[6].Value.ToString();
            textBoxQteMod.Text = bunifuDataGridViewEntree.CurrentRow.Cells[2].Value.ToString();
        }

        private void Evenement_TextChange_DeRecherche(object sender, EventArgs e)
        {
            afficherEntreeStock(bunifuTextBoxRecherche.Text);
        }

        public void add_new_stock()
        {
            
           // double Qte = 0, Qte_courante = 0; //au cas ou la qte=0
            bool prod_exist = false;
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {
                MySqlConnection con = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string personnel = "SELECT nom_produit FROM stock WHERE nom_produit='"+bunifuDropdownProduit.Text+"'";

                con.Open();
                MySqlCommand perso = new MySqlCommand(personnel, con);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    prod_exist = true;
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(prod_exist)
            {
                connection.Open();
                string requeteMod = "UPDATE stock SET quantite = quantite + '" + bunifuTextBoxQuantite.Text + "' WHERE nom_produit ='" + bunifuDropdownProduit.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requeteMod, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                string requeteAj = "INSERT INTO stock(nom_produit,quantite) VALUES('" + this.bunifuDropdownProduit.Text + "','" + this.bunifuTextBoxQuantite.Text + "')";
                MySqlCommand inserer = new MySqlCommand(requeteAj, connection);
                MySqlDataReader lireA;

                connection.Open();
                lireA = inserer.ExecuteReader();

                while (lireA.Read())
                {
                    connection.Close();
                }
            }
        }

 

        private void bunifuButtonNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                if (bunifuTextBoxQuantite.Text != "" && bunifuDropdownProduit.Text != "")
                {
                    add_new_stock();

                    string requete = "INSERT INTO entreeStock(nom_produit,quantite,date_entree,origine,fournisseur,observation,utilisateur) VALUES('" + this.bunifuDropdownProduit.Text + "','" + this.bunifuTextBoxQuantite.Text + "','" + this.bunifuDateEntree.Text + "','"+this.bunifuTextBoxOrigine.Text + "','" + this.bunifuDropdownFournisseur.Text + "','" + this.richTextBoxObservation.Text + "','"+ this.textBoxUser.Text +"')";
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
                    afficherEntreeStock(""); //affichage de la fonction d'affichage
                
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

        //mis a jour du stock avant modification
        public void updateStockAvantModification()
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET quantite = quantite - '" + textBoxQteMod.Text + "' WHERE nom_produit  ='" + bunifuDropdownProduit.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                // MessageBox.Show("Bien modifié");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //mis a jour du stock apre modification
        public void updateStockApresModification()
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE stock SET quantite = quantite + '" + bunifuTextBoxQuantite.Text + "' WHERE nom_produit  ='" + bunifuDropdownProduit.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                // MessageBox.Show("Bien modifié");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bouton de modification
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");
            
            try
            {
                if (bunifuTextBoxQuantite.Text != "" && bunifuDropdownProduit.Text != "" && textBoxID.Text != "")
                {
                    updateStockAvantModification();//mise a jour du stock avant modification

                    updateStockApresModification();//mise a jour du stock

                    connection.Open();
                    string requete = "UPDATE entreeStock SET nom_produit ='" + bunifuDropdownProduit.Text + "' , quantite ='" + bunifuTextBoxQuantite.Text + "', date_entree ='" + bunifuDateEntree.Text + "', origine='" + bunifuTextBoxOrigine.Text + "',fournisseur='"+ bunifuDropdownFournisseur .Text+ "',observation='"+ richTextBoxObservation.Text+ "' WHERE id_entree ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Bien modifié");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherEntreeStock(""); //affichage de la fonction d'affichage
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
                if (bunifuTextBoxQuantite.Text != "" && bunifuDropdownProduit.Text != "" && textBoxID.Text != "")
                {
                    updateStockAvantModification();//mise a jour du stock avant Suppression

                    connection.Open();
                    string requete = "DELETE FROM entreeStock WHERE id_entree ='" + textBoxID.Text + "'";
                    MySqlCommand modifier = new MySqlCommand(requete, connection);

                    modifier.Connection = connection;
                    modifier.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Bien Supprimé");

                    nettoyageForm(); // fonction de nettoyage du formulaire
                    afficherEntreeStock(""); //affichage de la fonction d'affichage
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


        //**********************************************************************************************
        //**********************************************************************************************
        //fonctins keyPress de verification des champs
        private void eventKeypressChiffreSeulementQuantite(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && bunifuTextBoxQuantite.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }
    }
}
