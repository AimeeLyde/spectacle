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
    }
}
