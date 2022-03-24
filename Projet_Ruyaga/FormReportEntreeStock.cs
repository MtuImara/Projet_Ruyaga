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
    public partial class FormReportEntreeStock : Form
    {
        public FormReportEntreeStock()
        {
            InitializeComponent();

            afficherFournisseurComboBox();
            afficherProduitComboBox();
            reportGeneral();//appel
        }

        //fonction de nettoyage
        public void nettoyage()
        {
            bunifuDropdownProduit.Text = "";
            bunifuDropdownFournisseur.Text = "";
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

        public void reportGeneral()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_entree,origine,fournisseur,observation FROM entreeStock WHERE date_entree BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

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


                DataSetEntreeStock dsV = new DataSetEntreeStock();

                md.Fill(dsV, "DataTableEntreeStock");

                ReportDataSource source = new ReportDataSource("DataSetEntree", dsV.Tables[0]);

                this.reportViewerEntreeStock.LocalReport.DataSources.Clear();
                this.reportViewerEntreeStock.LocalReport.DataSources.Add(source);
                this.reportViewerEntreeStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonInventaire_Click(object sender, EventArgs e)
        {
            reportGeneral();//appel
        }

        private void bunifuButtonInventaireProduit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_entree,origine,fournisseur,observation FROM entreeStock WHERE date_entree BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

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


                DataSetEntreeStock dsV = new DataSetEntreeStock();

                md.Fill(dsV, "DataTableEntreeStock");

                ReportDataSource source = new ReportDataSource("DataSetEntree", dsV.Tables[0]);

                this.reportViewerEntreeStock.LocalReport.DataSources.Clear();
                this.reportViewerEntreeStock.LocalReport.DataSources.Add(source);
                this.reportViewerEntreeStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonInventaireFournisseur_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite,date_entree,origine,fournisseur,observation FROM entreeStock WHERE date_entree BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'  ";

                //multiple requette
                   if (bunifuDropdownFournisseur.Text != "")
                   {
                       requete += "AND fournisseur='" + bunifuDropdownFournisseur.Text + "'";
                   }

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetEntreeStock dsV = new DataSetEntreeStock();

                md.Fill(dsV, "DataTableEntreeStock");

                ReportDataSource source = new ReportDataSource("DataSetEntree", dsV.Tables[0]);

                this.reportViewerEntreeStock.LocalReport.DataSources.Clear();
                this.reportViewerEntreeStock.LocalReport.DataSources.Add(source);
                this.reportViewerEntreeStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
