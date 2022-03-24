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
    public partial class FormRapportStockTotal : Form
    {
        public FormRapportStockTotal()
        {
            InitializeComponent();
            afficherProduitComboBox();
            //reportGeneral();
            reportTotal();
        }

        public void nettoyage()
        {
            bunifuDropdownProduit.Text = "";
            bunifuTextBoxDe.Text = "";
            bunifuTextBoxA.Text = "";
        }
        private void bunifuButtonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyage();
        }
        private void FormRapportStockTotal_Load(object sender, EventArgs e)
        {

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

        public void reportTotal()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite FROM stock";



                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetStockTotal dsV = new DataSetStockTotal();

                md.Fill(dsV, "DataTableStockTotal");

                ReportDataSource source = new ReportDataSource("DataSetStockTotal", dsV.Tables[0]);

                this.reportViewerStock.LocalReport.DataSources.Clear();
                this.reportViewerStock.LocalReport.DataSources.Add(source);
                this.reportViewerStock.RefreshReport();
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

                string requete = "SELECT nom_produit,quantite FROM stock WHERE quantite BETWEEN '" + bunifuTextBoxDe.Text + "' AND '" + bunifuTextBoxA.Text + "'  ";

                

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetStockTotal dsV = new DataSetStockTotal();

                md.Fill(dsV, "DataTableStockTotal");

                ReportDataSource source = new ReportDataSource("DataSetStockTotal", dsV.Tables[0]);

                this.reportViewerStock.LocalReport.DataSources.Clear();
                this.reportViewerStock.LocalReport.DataSources.Add(source);
                this.reportViewerStock.RefreshReport();
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

        
        private void bunifuButtonInventaireParProduit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite FROM stock WHERE nom_produit='"+ bunifuDropdownProduit.Text +"'  ";

                
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetStockTotal dsV = new DataSetStockTotal();

                md.Fill(dsV, "DataTableStockTotal");

                ReportDataSource source = new ReportDataSource("DataSetStockTotal", dsV.Tables[0]);

                this.reportViewerStock.LocalReport.DataSources.Clear();
                this.reportViewerStock.LocalReport.DataSources.Add(source);
                this.reportViewerStock.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
