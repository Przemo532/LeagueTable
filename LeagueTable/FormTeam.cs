using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTable
{
    public partial class FormTeam : Form
    {
        public Team MyTeam { get; internal set; }

        public FormTeam()
        {
            InitializeComponent();
            MyTeam = new Team();
        }


        private void buttonSubmitTeam_Click(object sender, EventArgs e)
        {
            if(textBoxTeamName.Text.Length > 5)
            {
                MyTeam.name = textBoxTeamName.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
