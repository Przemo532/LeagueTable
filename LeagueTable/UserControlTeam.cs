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
    public partial class UserControlTeam : UserControl
    {
        public UserControlTeam()
        {
            InitializeComponent();
            labelNum.Text = "Number";
            labelName.Text = "Team name";
            labelScoredGoals.Text = "Scored Goals";
            labelLostGoals.Text = "Lost Goals";
            labelLeaguePoints.Text = "Points";
        }
        public UserControlTeam(int num, Team t)
        {
            InitializeComponent();
            labelNum.Text = num.ToString();
            labelName.Text = t.name;
            labelScoredGoals.Text = t.ScoredGoalTotalCount.ToString();
            labelLostGoals.Text = t.LostGoalTotalCount.ToString();
            labelLeaguePoints.Text = t.TotalLeaguePoints.ToString();
        }
    }
}
