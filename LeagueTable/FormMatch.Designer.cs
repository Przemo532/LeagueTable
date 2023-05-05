
namespace LeagueTable
{
    partial class FormMatch
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
            this.listBoxHost = new System.Windows.Forms.ListBox();
            this.listBoxGuest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGuest = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSubmitMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHost
            // 
            this.listBoxHost.FormattingEnabled = true;
            this.listBoxHost.ItemHeight = 16;
            this.listBoxHost.Location = new System.Drawing.Point(12, 35);
            this.listBoxHost.Name = "listBoxHost";
            this.listBoxHost.Size = new System.Drawing.Size(184, 116);
            this.listBoxHost.TabIndex = 0;
            // 
            // listBoxGuest
            // 
            this.listBoxGuest.FormattingEnabled = true;
            this.listBoxGuest.ItemHeight = 16;
            this.listBoxGuest.Location = new System.Drawing.Point(229, 35);
            this.listBoxGuest.Name = "listBoxGuest";
            this.listBoxGuest.Size = new System.Drawing.Size(184, 116);
            this.listBoxGuest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guest Team";
            // 
            // numericUpDownHost
            // 
            this.numericUpDownHost.Location = new System.Drawing.Point(12, 175);
            this.numericUpDownHost.Name = "numericUpDownHost";
            this.numericUpDownHost.Size = new System.Drawing.Size(184, 22);
            this.numericUpDownHost.TabIndex = 4;
            // 
            // numericUpDownGuest
            // 
            this.numericUpDownGuest.Location = new System.Drawing.Point(229, 175);
            this.numericUpDownGuest.Name = "numericUpDownGuest";
            this.numericUpDownGuest.Size = new System.Drawing.Size(184, 22);
            this.numericUpDownGuest.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Host Team Goals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Guest Team Goals";
            // 
            // buttonSubmitMatch
            // 
            this.buttonSubmitMatch.Location = new System.Drawing.Point(12, 203);
            this.buttonSubmitMatch.Name = "buttonSubmitMatch";
            this.buttonSubmitMatch.Size = new System.Drawing.Size(401, 26);
            this.buttonSubmitMatch.TabIndex = 8;
            this.buttonSubmitMatch.Text = "Submit Match";
            this.buttonSubmitMatch.UseVisualStyleBackColor = true;
            this.buttonSubmitMatch.Click += new System.EventHandler(this.buttonSubmitMatch_Click);
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 240);
            this.Controls.Add(this.buttonSubmitMatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownGuest);
            this.Controls.Add(this.numericUpDownHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGuest);
            this.Controls.Add(this.listBoxHost);
            this.Name = "FormMatch";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHost;
        private System.Windows.Forms.ListBox listBoxGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHost;
        private System.Windows.Forms.NumericUpDown numericUpDownGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSubmitMatch;
    }
}