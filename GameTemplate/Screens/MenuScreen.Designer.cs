namespace GameTemplate.Screens
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.howtoButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.exitButton.Location = new System.Drawing.Point(155, 250);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.White;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Location = new System.Drawing.Point(32, 249);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(79, 27);
            this.optionsButton.TabIndex = 9;
            this.optionsButton.Tag = "OptionsScreen";
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.White;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Location = new System.Drawing.Point(32, 220);
            this.scoresButton.Margin = new System.Windows.Forms.Padding(2);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(79, 26);
            this.scoresButton.TabIndex = 8;
            this.scoresButton.Tag = "ScoreScreen";
            this.scoresButton.Text = "High Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Gainsboro;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.playButton.Location = new System.Drawing.Point(155, 163);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 39);
            this.playButton.TabIndex = 6;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "Green to Start ";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // howtoButton
            // 
            this.howtoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.howtoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howtoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.howtoButton.Location = new System.Drawing.Point(155, 206);
            this.howtoButton.Margin = new System.Windows.Forms.Padding(2);
            this.howtoButton.Name = "howtoButton";
            this.howtoButton.Size = new System.Drawing.Size(120, 40);
            this.howtoButton.TabIndex = 7;
            this.howtoButton.Text = "How To Play";
            this.howtoButton.UseVisualStyleBackColor = false;
            this.howtoButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameTitle.BackgroundImage")));
            this.gameTitle.InitialImage = ((System.Drawing.Image)(resources.GetObject("gameTitle.InitialImage")));
            this.gameTitle.Location = new System.Drawing.Point(117, 27);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(380, 104);
            this.gameTitle.TabIndex = 12;
            this.gameTitle.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.howtoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.playButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(486, 312);
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button howtoButton;
        private System.Windows.Forms.PictureBox gameTitle;
    }
}
