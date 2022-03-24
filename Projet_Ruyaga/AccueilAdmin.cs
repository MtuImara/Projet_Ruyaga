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
    public partial class AccueilAdmin : Form
    {
        public AccueilAdmin(string Datas)
        {
            InitializeComponent();

            bunifuTextBoxUserName.Text = Datas;//appel du login de l'utilisateur a partir du form d'authentification


            graphAccueil();
        }

        //code mere pour faciliter le deplacement du formulaire
        //***************************************************************************************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmdw, int wmsg, int wparam, int lparam);
        //***************************************************************************************************

        private void eventDeDeplacementEnTeteFormAccueil(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //***************************************************************************************************

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l = new Login();
            l.Show();
        }

        private void buttonIconMax_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
            buttonRestore.Visible = true;
            buttonIconMax.Visible = false;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestore.Visible = false;
            buttonIconMax.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //***************************************************************************
        //fonction d'appel du form en system MVC
        private void sytemMVC(object Formhijo)
        {
            if (this.panelBody.Controls.Count > 0)
                this.panelBody.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(fh);
            this.panelBody.Tag = fh;
            fh.Show();

        }

        //***************************************************************************
        //boutons pour l'appel des forms
        private void bunifuButtonStock_Click(object sender, EventArgs e)
        {
            sytemMVC(new EntreStock(bunifuTextBoxUserName.Text));
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            sytemMVC(new SortieStock(bunifuTextBoxUserName.Text));
        }

        private void bunifuButtonReportEntreeStock_Click(object sender, EventArgs e)
        {
            sytemMVC(new FormRapport());
        }

        private void bunifuButtonAccueil_Click(object sender, EventArgs e)
        {
            sytemMVC(new Dashboard());
        }



        //***************************************************************************
        //***************************************************************************
        //Graph
/*
        public void afficherChartStock()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                chartStock.Series.Clear();
                chartStock.Series.Add("Nom du Produit");
                string personnel = "SELECT nom_produit,quantite FROM stock";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    chartStock.Series["Nom du Produit"].Points.AddXY(lire.GetString("nom_produit"), lire.GetString("quantite"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GraphSortie()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                chartSorties.Series.Clear();
                chartSorties.Series.Add("Nom du Produit");
                string personnel = "SELECT nom_produit,quantite FROM SortieStock";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    chartSorties.Series["Nom du Produit"].Points.AddXY(lire.GetString("nom_produit"), lire.GetString("quantite"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GraphEntree()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");

                chartEntrees.Series.Clear();
                chartEntrees.Series.Add("Nom du Produit");
                string personnel = "SELECT nom_produit,quantite FROM entreeStock";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    chartEntrees.Series["Nom du Produit"].Points.AddXY(lire.GetString("nom_produit"), lire.GetString("quantite"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
*/
        public void graphAccueil()
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

                this.reportViewerGraphSortie.LocalReport.DataSources.Clear();
                this.reportViewerGraphSortie.LocalReport.DataSources.Add(source);
                this.reportViewerGraphSortie.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bouton user
        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
        }
        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccueilAdmin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
