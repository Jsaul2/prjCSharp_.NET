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
    public partial class FrmDetailThemeFormation : Form
    {
        public FrmDetailThemeFormation()
        {
            InitializeComponent();
        }
        public FrmDetailThemeFormation(Theme aTheme)
            : this()
        {
            TxtLibeller.Text = aTheme.Libelle;
        }

        private void CmdValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CmdAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtLibelle_Click(object sender, EventArgs e)
        {

        }

        private void TxtLibeller_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
