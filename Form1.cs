using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AimCecSpect.Utilisateur;

namespace AimCecSpect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'billeterieDataSet.Spectacle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.spectacleTableAdapter.Fill(this.billeterieDataSet.Spectacle);
            

        }

        private void dataGridViewSpectacles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BilleterieEntities db = new BilleterieEntities();
            dataGridView1.CellContentClick += dataGridViewSpectacles_CellContentClick;

            if (e.ColumnIndex == dataGridView1.Columns["Reservation"].Index && e.RowIndex >= 0)
            {
              
                int idSpectacle = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idSpectacleDataGridViewTextBoxColumn"].Value);
                int idUtilisateur = UtilisateurConnecteManager.IDUtilisateurConnecte;
                /*MessageBox.Show($"ID du spectacle : {idSpectacle}");*/

                GestionnaireBillet gestionnairebillet = new GestionnaireBillet(db);
                gestionnairebillet.ReserverBillet(idSpectacle, idUtilisateur);
                /*MessageBox.Show($"ID du spectacle : {idSpectacle}");*/

            }

            if (e.ColumnIndex == dataGridView1.Columns["Annulation"].Index && e.RowIndex >= 0)
            {

                int idSpectacle = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idSpectacleDataGridViewTextBoxColumn"].Value);
                int idUtilisateur = UtilisateurConnecteManager.IDUtilisateurConnecte;
                /*MessageBox.Show($"ID du spectacle : {idSpectacle}");*/

                GestionnaireBillet gestionnairebillet = new GestionnaireBillet(db);
                gestionnairebillet.ReserverBillet(idSpectacle, idUtilisateur);
                /*MessageBox.Show($"ID du spectacle : {idSpectacle}");*/

            }
        }

        private void mesRéservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation tabForm = new Reservation();
            tabForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
