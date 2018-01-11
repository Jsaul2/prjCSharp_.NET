using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCentreFormation
{
    public partial class Form1 : Form
    {
        private FormationEntities ContexteDonnees;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ContexteDonnees = new FormationEntities();
        }

        private void LstThemes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {

        }

        private void CmdModifier_Click(object sender, EventArgs e)
        {

        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
