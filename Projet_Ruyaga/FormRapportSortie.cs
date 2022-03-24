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
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace Projet_Ruyaga
{
    public partial class FormRapportSortie : Form
    {
        public FormRapportSortie()
        {
            InitializeComponent();

            reportGeneral();
            afficherProduitComboBox();
            afficherUserComboBox();
        }

        private void FormRapportSortie_Load(object sender, EventArgs e)
        {

        }

        public void nettoyage()
        {
            bunifuDropdownProduit.Text = "";
            bunifuDropdownUser.Text = "";
            bunifuDateEntreeDe.Text = "";
            bunifuDateEntreeAu.Text = "";
        }

        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyage();
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

        //fonction affiche Users comboBox
        public void afficherUserComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM utilisateurs";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    bunifuDropdownUser.Items.Add(lire.GetString("login"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void reportGeneral()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_sortie,destination FROM SortieStock WHERE date_sortie BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

                //multiple requette
                /*    if (bunifuDropdownProduit.Text != "")
                    {
                        requete += "AND nom_produit='" + bunifuDropdownProduit.Text + "'";
                    }
                    if (bunifuDropdownFournisseur.Text != "")
                    {
                        requete += "AND fournisseur='" + bunifuDropdownFournisseur.Text + "'";
                    }
                */

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetSortie dsV = new DataSetSortie();

                md.Fill(dsV, "DataTableSortie");

                ReportDataSource source = new ReportDataSource("DataSetSortie", dsV.Tables[0]);

                this.reportViewerSortieStock.LocalReport.DataSources.Clear();
                this.reportViewerSortieStock.LocalReport.DataSources.Add(source);
                this.reportViewerSortieStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuButtonInventaire_Click(object sender, EventArgs e)
        {
            reportGeneral();
        }

        private void bunifuButtonInventaireProduit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_sortie,destination FROM SortieStock WHERE date_sortie BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

                //multiple requette
                if (bunifuDropdownProduit.Text != "")
                {
                    requete += "AND nom_produit='" + bunifuDropdownProduit.Text + "'";
                }
                /*   if (bunifuDropdownFournisseur.Text != "")
                   {
                       requete += "AND fournisseur='" + bunifuDropdownFournisseur.Text + "'";
                   }
               */

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetSortie dsV = new DataSetSortie();

                md.Fill(dsV, "DataTableSortie");

                ReportDataSource source = new ReportDataSource("DataSetSortie", dsV.Tables[0]);

                this.reportViewerSortieStock.LocalReport.DataSources.Clear();
                this.reportViewerSortieStock.LocalReport.DataSources.Add(source);
                this.reportViewerSortieStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonInventaireUser_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_sortie,destination FROM SortieStock WHERE date_sortie BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

                //multiple requette
                if (bunifuDropdownUser.Text != "")
                {
                    requete += "AND utilisateur='" + bunifuDropdownUser.Text + "'";
                }

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetSortie dsV = new DataSetSortie();

                md.Fill(dsV, "DataTableSortie");

                ReportDataSource source = new ReportDataSource("DataSetSortie", dsV.Tables[0]);

                this.reportViewerSortieStock.LocalReport.DataSources.Clear();
                this.reportViewerSortieStock.LocalReport.DataSources.Add(source);
                this.reportViewerSortieStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
