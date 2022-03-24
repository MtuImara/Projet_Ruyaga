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
using Microsoft.Reporting.WinForms;

namespace Projet_Ruyaga
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            afficherChartStock();
            GraphEntreeSortie();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        public void afficherChartStock()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                chartStockEntree.Series.Clear();
                chartStockEntree.Series.Add("Nom du Produit");
                string personnel = "SELECT nom_produit,quantite FROM stock";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    chartStockEntree.Series["Nom du Produit"].Points.AddXY(lire.GetString("nom_produit"), lire.GetString("quantite"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GraphEntreeSortie()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite FROM SortieStock";
                //string requete = "SELECT nom_produit,quantite,date_sortie FROM SortieStock WHERE date_sortie BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'";


                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetGraphEntreeSortie dsV = new DataSetGraphEntreeSortie();

                md.Fill(dsV, "DataTableGraphEntreeSortie");

                ReportDataSource source = new ReportDataSource("DataSetGraphEntreeSortie", dsV.Tables[0]);

                this.reportViewerGraphEntreeSortie.LocalReport.DataSources.Clear();
                this.reportViewerGraphEntreeSortie.LocalReport.DataSources.Add(source);
                this.reportViewerGraphEntreeSortie.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonInventaire_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite FROM SortieStock WHERE date_sortie BETWEEN '" + bunifuDateEntreeDe.Text + "' AND '" + bunifuDateEntreeAu.Text + "'";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetGraphEntreeSortie dsV = new DataSetGraphEntreeSortie();

                md.Fill(dsV, "DataTableGraphEntreeSortie");

                ReportDataSource source = new ReportDataSource("DataSetGraphEntreeSortie", dsV.Tables[0]);

                this.reportViewerGraphEntreeSortie.LocalReport.DataSources.Clear();
                this.reportViewerGraphEntreeSortie.LocalReport.DataSources.Add(source);
                this.reportViewerGraphEntreeSortie.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDateEntreeDe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDateEntreeAu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
