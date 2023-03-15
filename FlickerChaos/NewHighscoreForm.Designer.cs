namespace FlickerChaos
{
    partial class NewHighscoreForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.levelTextLabel = new System.Windows.Forms.Label();
            this.bottomControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.difficultyTextLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.bottomControlsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.Location = new System.Drawing.Point(19, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "ChaosPlayer";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(301, 8);
            this.okButton.Margin = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 26);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextLabel, 3);
            this.nameTextLabel.Location = new System.Drawing.Point(19, 16);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(78, 16);
            this.nameTextLabel.TabIndex = 2;
            this.nameTextLabel.Text = "Enter name:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(19, 107);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(42, 16);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "-1,234";
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Location = new System.Drawing.Point(19, 82);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(43, 16);
            this.scoreTextLabel.TabIndex = 4;
            this.scoreTextLabel.Text = "Score";
            // 
            // levelTextLabel
            // 
            this.levelTextLabel.AutoSize = true;
            this.levelTextLabel.Location = new System.Drawing.Point(138, 82);
            this.levelTextLabel.Name = "levelTextLabel";
            this.levelTextLabel.Size = new System.Drawing.Size(40, 16);
            this.levelTextLabel.TabIndex = 5;
            this.levelTextLabel.Text = "Level";
            // 
            // bottomControlsPanel
            // 
            this.bottomControlsPanel.AutoSize = true;
            this.bottomControlsPanel.Controls.Add(this.okButton);
            this.bottomControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomControlsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.bottomControlsPanel.Location = new System.Drawing.Point(0, 168);
            this.bottomControlsPanel.Name = "bottomControlsPanel";
            this.bottomControlsPanel.Size = new System.Drawing.Size(392, 42);
            this.bottomControlsPanel.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.nameTextLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.levelTextLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.scoreTextLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.scoreLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.levelLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.difficultyTextLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.difficultyLabel, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 168);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(138, 107);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(18, 16);
            this.levelLabel.TabIndex = 6;
            this.levelLabel.Text = "-1";
            // 
            // difficultyTextLabel
            // 
            this.difficultyTextLabel.AutoSize = true;
            this.difficultyTextLabel.Location = new System.Drawing.Point(258, 82);
            this.difficultyTextLabel.Name = "difficultyTextLabel";
            this.difficultyTextLabel.Size = new System.Drawing.Size(56, 16);
            this.difficultyTextLabel.TabIndex = 7;
            this.difficultyTextLabel.Text = "Difficulty";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(258, 107);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(73, 16);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Impossible";
            // 
            // NewHighscoreForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 210);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bottomControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewHighscoreForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Highscore!";
            this.bottomControlsPanel.ResumeLayout(false);
            this.bottomControlsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label levelTextLabel;
        private System.Windows.Forms.FlowLayoutPanel bottomControlsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label difficultyTextLabel;
        private System.Windows.Forms.Label difficultyLabel;
    }
}