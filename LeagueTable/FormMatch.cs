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
    public partial class FormMatch : Form
    {
        public Match MyMatch { get; internal set; }
        public FormMatch(Team [] teams)
        {
            InitializeComponent();
            MyMatch = new Match();

            listBoxHost.Items.AddRange(teams);
            listBoxGuest.Items.AddRange(teams);
        }

        private void buttonSubmitMatch_Click(object sender, EventArgs e)
        {
            MyMatch.TeamHost = listBoxHost.SelectedItem as Team;
            MyMatch.TeamGuest = listBoxGuest.SelectedItem as Team;

            MyMatch.GoalHost = (int)numericUpDownHost.Value;
            MyMatch.GoalGuest = (int)numericUpDownGuest.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
