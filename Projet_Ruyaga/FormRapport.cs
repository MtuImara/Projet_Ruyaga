using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices; //bibliotheque pour faciliter le deplacement du formulaire

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Projet_Ruyaga
{
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            InitializeComponent();

            graphAccueilReport();
        }

        //***************************************************************************
        //fonction d'appel du form en system MVC
        private void sytemMVC(object Formhijo)
        {
            if (this.bunifuPanelRapportBody.Controls.Count > 0)
                this.bunifuPanelRapportBody.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.bunifuPanelRapportBody.Controls.Add(fh);
            this.bunifuPanelRapportBody.Tag = fh;
            fh.Show();

        }

        //***************************************************************************


        private void bunifuButtonRapportEntree_Click(object sender, EventArgs e)
        {
            sytemMVC(new FormReportEntreeStock());
        }

        private void bunifuButtonReportStock_Click(object sender, EventArgs e)
        {
            sytemMVC(new FormRapportStockTotal());
        }

        private void bunifuButtonRapportSortie_Click(object sender, EventArgs e)
        {
            sytemMVC(new FormRapportSortie());
        }

        public void graphAccueilReport()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                string requete = "SELECT nom_produit,quantite FROM Stock";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetStockTotal dsV = new DataSetStockTotal();

                md.Fill(dsV, "DataTableStockTotal");

                ReportDataSource source = new ReportDataSource("DataSetGraphStock", dsV.Tables[0]);

                this.reportViewerGraphStock1.LocalReport.DataSources.Clear();
                this.reportViewerGraphStock1.LocalReport.DataSources.Add(source);
                this.reportViewerGraphStock1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
