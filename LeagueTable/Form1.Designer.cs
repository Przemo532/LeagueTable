
namespace LeagueTable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddMatch = new System.Windows.Forms.Button();
            this.flowLayoutPanelLeagueStandings = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(148, 24);
            this.buttonAddTeam.TabIndex = 0;
            this.buttonAddTeam.Text = "add team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddMatch
            // 
            this.buttonAddMatch.Location = new System.Drawing.Point(175, 12);
            this.buttonAddMatch.Name = "buttonAddMatch";
            this.buttonAddMatch.Size = new System.Drawing.Size(148, 24);
            this.buttonAddMatch.TabIndex = 1;
            this.buttonAddMatch.Text = "add match";
            this.buttonAddMatch.UseVisualStyleBackColor = true;
            this.buttonAddMatch.Click += new System.EventHandler(this.buttonAddMatch_Click);
            // 
            // flowLayoutPanelLeagueStandings
            // 
            this.flowLayoutPanelLeagueStandings.Location = new System.Drawing.Point(13, 42);
            this.flowLayoutPanelLeagueStandings.Name = "flowLayoutPanelLeagueStandings";
            this.flowLayoutPanelLeagueStandings.Size = new System.Drawing.Size(778, 402);
            this.flowLayoutPanelLeagueStandings.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelLeagueStandings);
            this.Controls.Add(this.buttonAddMatch);
            this.Controls.Add(this.buttonAddTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddMatch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeagueStandings;
    }
}

