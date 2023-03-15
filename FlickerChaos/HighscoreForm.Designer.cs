namespace FlickerChaos
{
    partial class HighscoreForm
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
            this.tableHighscores = new System.Windows.Forms.TableLayoutPanel();
            this.nameHeaderLabel = new System.Windows.Forms.Label();
            this.scoreHeaderLabel = new System.Windows.Forms.Label();
            this.levelHeaderLabel = new System.Windows.Forms.Label();
            this.difficultyHeaderLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.bottomControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableHighscores.SuspendLayout();
            this.bottomControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHighscores
            // 
            this.tableHighscores.ColumnCount = 4;
            this.tableHighscores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableHighscores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableHighscores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableHighscores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableHighscores.Controls.Add(this.nameHeaderLabel, 0, 0);
            this.tableHighscores.Controls.Add(this.scoreHeaderLabel, 1, 0);
            this.tableHighscores.Controls.Add(this.levelHeaderLabel, 2, 0);
            this.tableHighscores.Controls.Add(this.difficultyHeaderLabel, 3, 0);
            this.tableHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableHighscores.Location = new System.Drawing.Point(0, 0);
            this.tableHighscores.Name = "tableHighscores";
            this.tableHighscores.Padding = new System.Windows.Forms.Padding(16);
            this.tableHighscores.RowCount = 6;
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableHighscores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableHighscores.Size = new System.Drawing.Size(421, 277);
            this.tableHighscores.TabIndex = 0;
            // 
            // nameHeaderLabel
            // 
            this.nameHeaderLabel.AutoSize = true;
            this.nameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeaderLabel.Location = new System.Drawing.Point(19, 16);
            this.nameHeaderLabel.Name = "nameHeaderLabel";
            this.nameHeaderLabel.Size = new System.Drawing.Size(48, 16);
            this.nameHeaderLabel.TabIndex = 0;
            this.nameHeaderLabel.Text = "Name";
            // 
            // scoreHeaderLabel
            // 
            this.scoreHeaderLabel.AutoSize = true;
            this.scoreHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreHeaderLabel.Location = new System.Drawing.Point(155, 16);
            this.scoreHeaderLabel.Name = "scoreHeaderLabel";
            this.scoreHeaderLabel.Size = new System.Drawing.Size(48, 16);
            this.scoreHeaderLabel.TabIndex = 1;
            this.scoreHeaderLabel.Text = "Score";
            // 
            // levelHeaderLabel
            // 
            this.levelHeaderLabel.AutoSize = true;
            this.levelHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelHeaderLabel.Location = new System.Drawing.Point(252, 16);
            this.levelHeaderLabel.Name = "levelHeaderLabel";
            this.levelHeaderLabel.Size = new System.Drawing.Size(45, 16);
            this.levelHeaderLabel.TabIndex = 2;
            this.levelHeaderLabel.Text = "Level";
            // 
            // difficultyHeaderLabel
            // 
            this.difficultyHeaderLabel.AutoSize = true;
            this.difficultyHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyHeaderLabel.Location = new System.Drawing.Point(310, 16);
            this.difficultyHeaderLabel.Name = "difficultyHeaderLabel";
            this.difficultyHeaderLabel.Size = new System.Drawing.Size(66, 16);
            this.difficultyHeaderLabel.TabIndex = 3;
            this.difficultyHeaderLabel.Text = "Difficulty";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(330, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 26);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // bottomControlsPanel
            // 
            this.bottomControlsPanel.AutoSize = true;
            this.bottomControlsPanel.Controls.Add(this.closeButton);
            this.bottomControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomControlsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.bottomControlsPanel.Location = new System.Drawing.Point(0, 235);
            this.bottomControlsPanel.Name = "bottomControlsPanel";
            this.bottomControlsPanel.Size = new System.Drawing.Size(421, 42);
            this.bottomControlsPanel.TabIndex = 2;
            // 
            // HighscoreForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(421, 277);
            this.Controls.Add(this.bottomControlsPanel);
            this.Controls.Add(this.tableHighscores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighscoreForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.tableHighscores.ResumeLayout(false);
            this.tableHighscores.PerformLayout();
            this.bottomControlsPanel.ResumeLayout(false);
            this.bottomControlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHighscores;
        private System.Windows.Forms.Label nameHeaderLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label scoreHeaderLabel;
        private System.Windows.Forms.Label levelHeaderLabel;
        private System.Windows.Forms.Label difficultyHeaderLabel;
        private System.Windows.Forms.FlowLayoutPanel bottomControlsPanel;
    }
}