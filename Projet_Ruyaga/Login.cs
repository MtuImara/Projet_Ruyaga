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


namespace Projet_Ruyaga
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //code mere pour faciliter le deplacement du formulaire
        //***************************************************************************************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmdw, int wmsg, int wparam, int lparam);
        //***************************************************************************************************

        private void eventDeDeplacementFormLogin(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //***************************************************************************************************

        private void bunifuButtonQuitter_Click(object sender, EventArgs e)
        {
            DialogResult quitter;
            quitter = MessageBox.Show("Voulez-vous fermer cette Application?", "Alert!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuButtonLogin_Click(object sender, EventArgs e)
        {
            
             try
             {
                 if (bunifuTextBoxUserName.Text != "" && bunifuTextBoxpassword.Text != "")
                 {

                    MySqlConnection con = new MySqlConnection("database=ruyaga; server=localhost; user id=root; pwd=");


                    string query = "SELECT * FROM utilisateurs WHERE login='" + bunifuTextBoxUserName.Text.Trim() + "' AND password='" + bunifuTextBoxpassword.Text.Trim() + "'";

                     DataTable dt = new DataTable();
                     MySqlDataAdapter md = new MySqlDataAdapter(query, con);
                     md.Fill(dt);



                     if (dt.Rows.Count == 1)
                     {
                        AccueilAdmin a = new AccueilAdmin(bunifuTextBoxUserName.Text);
                        a.Show();

                        this.Hide();

                        bunifuTextBoxUserName.Text = "";
                        bunifuTextBoxpassword.Text = "";
                     }
                     else
                     {
                        //MessageBox.Show("Vos données ne sont pas Correctes!! Veillez Réessayer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                        donneesIncorrectes.Visible = true;
                        remplirForm.Visible = false;
                        connexionBD.Visible = false;
                    }

                 }
                 else
                 {
                    remplirForm.Visible = true;
                    donneesIncorrectes.Visible = false;
                    connexionBD.Visible = false;
                    // MessageBox.Show("Veillez bien remplir votre formulaire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             }

             catch (Exception)
             {
                //MessageBox.Show("Pas de connexion!!! Veillez Vérifier si la Base de Données est alumée", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connexionBD.Visible = true;
                donneesIncorrectes.Visible = false;
                remplirForm.Visible = false;
            }      
                      
        }

        
    }
}
