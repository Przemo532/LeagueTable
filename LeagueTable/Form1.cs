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
    public partial class Form1 : Form
    {
        DataClassesSportDataContext DatabaseDC = new DataClassesSportDataContext();
        public Form1()
        {
            InitializeComponent();

            DrawList();
        }

        private void DrawList()
        {
            int num = 1;
            flowLayoutPanelLeagueStandings.Controls.Clear();
            flowLayoutPanelLeagueStandings.Controls.Add(new UserControlTeam());
            foreach (Team T in DatabaseDC.Teams.ToList().OrderByDescending(x => x.TotalLeaguePoints)) //without .ToList(). we can sort by name but program can't translae TotalLeaguePoints into query
            {
                UserControlTeam uct = new UserControlTeam(num++, T);
                flowLayoutPanelLeagueStandings.Controls.Add(uct);
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            FormTeam ft = new FormTeam();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                DatabaseDC.Teams.InsertOnSubmit(ft.MyTeam);
                DatabaseDC.SubmitChanges();
            }
            DrawList();
        }

        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            FormMatch fm = new FormMatch(DatabaseDC.Teams.ToArray());
            if (fm.ShowDialog() == DialogResult.OK)
            {
                DatabaseDC.Matches.InsertOnSubmit(fm.MyMatch);
                DatabaseDC.SubmitChanges();
            }
            DrawList();
        }
    }

}

/*
CREATE TABLE [dbo].[Team] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Match](
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamHostId] INT NOT NULL, 
    [TeamGuestId] INT NOT NULL, 
    [GoalHost] INT NOT NULL, 
    [GoalGuest] INT NOT NULL, 
    CONSTRAINT [FK_Match_TeamHost] FOREIGN KEY ([TeamHostId]) REFERENCES [Team]([Id]), 
    CONSTRAINT [FK_Match_TeamGuest] FOREIGN KEY ([TeamGuestId]) REFERENCES [Team]([Id]), 
    CONSTRAINT [CK_Match_HostGuest] CHECK ([TeamHostId]!=[TeamGuestId])
)

 */
