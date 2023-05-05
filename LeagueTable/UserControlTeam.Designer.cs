
namespace LeagueTable
{
    partial class UserControlTeam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelScoredGoals = new System.Windows.Forms.Label();
            this.labelLostGoals = new System.Windows.Forms.Label();
            this.labelLeaguePoints = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(123, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelScoredGoals
            // 
            this.labelScoredGoals.AutoSize = true;
            this.labelScoredGoals.Location = new System.Drawing.Point(302, 10);
            this.labelScoredGoals.Name = "labelScoredGoals";
            this.labelScoredGoals.Size = new System.Drawing.Size(90, 17);
            this.labelScoredGoals.TabIndex = 1;
            this.labelScoredGoals.Text = "ScoredGoals";
            // 
            // labelLostGoals
            // 
            this.labelLostGoals.AutoSize = true;
            this.labelLostGoals.Location = new System.Drawing.Point(486, 10);
            this.labelLostGoals.Name = "labelLostGoals";
            this.labelLostGoals.Size = new System.Drawing.Size(72, 17);
            this.labelLostGoals.TabIndex = 2;
            this.labelLostGoals.Text = "LostGoals";
            // 
            // labelLeaguePoints
            // 
            this.labelLeaguePoints.AutoSize = true;
            this.labelLeaguePoints.Location = new System.Drawing.Point(619, 11);
            this.labelLeaguePoints.Name = "labelLeaguePoints";
            this.labelLeaguePoints.Size = new System.Drawing.Size(95, 17);
            this.labelLeaguePoints.TabIndex = 3;
            this.labelLeaguePoints.Text = "LeaguePoints";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(19, 10);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(58, 17);
            this.labelNum.TabIndex = 4;
            this.labelNum.Text = "Number";
            // 
            // UserControlTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelLeaguePoints);
            this.Controls.Add(this.labelLostGoals);
            this.Controls.Add(this.labelScoredGoals);
            this.Controls.Add(this.labelName);
            this.Name = "UserControlTeam";
            this.Size = new System.Drawing.Size(1086, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScoredGoals;
        private System.Windows.Forms.Label labelLostGoals;
        private System.Windows.Forms.Label labelLeaguePoints;
        private System.Windows.Forms.Label labelNum;
    }
}
