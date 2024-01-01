using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimCecSpect
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BilleterieEntities db = new BilleterieEntities();
        private void button1_Click(object sender, EventArgs e)

        {
            string username = textBox1.Text; 
            string password = textBox2.Text;

            var rec = db.Utilisateurs.Where(a=>a.nom==username && a.motDePasse==password).FirstOrDefault();
            if (rec != null)
            {
                MessageBox.Show("Login Success");
                
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
            /*
            string username = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                using (var contexte = new AuthContext())
                {
                    Utilisateur utilisateur = contexte.AuthentifierUtilisateur(username, password);
                    if (utilisateur != null)
                    {
                        MessageBox.Show("Authentification réussie !");
                        // Authentification réussie : effectuez des actions nécessaires
                    }
                    else
                    {
                        MessageBox.Show("Échec de l'authentification. Veuillez réessayer.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
            }*/
        }


        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
