
namespace BasicFacebookFeatures
{
    partial class FormGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxHighscoreTable = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChances = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.radioButtonLevel1 = new System.Windows.Forms.RadioButton();
            this.radioButtonLevel2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLevel3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(345, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "In what year was the picture taken?";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(414, 175);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(320, 299);
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(506, 531);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(227, 22);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(944, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "TIME:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTimer.Location = new System.Drawing.Point(972, 420);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(32, 32);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "0";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelScore.Location = new System.Drawing.Point(972, 299);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(32, 32);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(927, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "SCORE:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(414, 530);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(86, 23);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxHighscoreTable);
            this.panel1.Location = new System.Drawing.Point(27, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 425);
            this.panel1.TabIndex = 11;
            // 
            // listBoxHighscoreTable
            // 
            this.listBoxHighscoreTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHighscoreTable.FormattingEnabled = true;
            this.listBoxHighscoreTable.HorizontalScrollbar = true;
            this.listBoxHighscoreTable.ItemHeight = 16;
            this.listBoxHighscoreTable.Location = new System.Drawing.Point(0, 0);
            this.listBoxHighscoreTable.Name = "listBoxHighscoreTable";
            this.listBoxHighscoreTable.Size = new System.Drawing.Size(288, 425);
            this.listBoxHighscoreTable.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(48, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Top Score Game:";
            // 
            // labelChances
            // 
            this.labelChances.AutoSize = true;
            this.labelChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChances.Location = new System.Drawing.Point(972, 169);
            this.labelChances.Name = "labelChances";
            this.labelChances.Size = new System.Drawing.Size(32, 32);
            this.labelChances.TabIndex = 13;
            this.labelChances.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(908, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "CHANCES:";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(414, 122);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(320, 47);
            this.buttonStartGame.TabIndex = 15;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // radioButtonLevel1
            // 
            this.radioButtonLevel1.AutoSize = true;
            this.radioButtonLevel1.Location = new System.Drawing.Point(790, 122);
            this.radioButtonLevel1.Name = "radioButtonLevel1";
            this.radioButtonLevel1.Size = new System.Drawing.Size(75, 21);
            this.radioButtonLevel1.TabIndex = 16;
            this.radioButtonLevel1.TabStop = true;
            this.radioButtonLevel1.Text = "Level 1";
            this.radioButtonLevel1.UseVisualStyleBackColor = true;
            this.radioButtonLevel1.CheckedChanged += new System.EventHandler(this.radioButtonLevel1_CheckedChanged);
            // 
            // radioButtonLevel2
            // 
            this.radioButtonLevel2.AutoSize = true;
            this.radioButtonLevel2.Location = new System.Drawing.Point(790, 168);
            this.radioButtonLevel2.Name = "radioButtonLevel2";
            this.radioButtonLevel2.Size = new System.Drawing.Size(75, 21);
            this.radioButtonLevel2.TabIndex = 16;
            this.radioButtonLevel2.TabStop = true;
            this.radioButtonLevel2.Text = "Level 2";
            this.radioButtonLevel2.UseVisualStyleBackColor = true;
            this.radioButtonLevel2.CheckedChanged += new System.EventHandler(this.radioButtonLevel2_CheckedChanged);
            // 
            // radioButtonLevel3
            // 
            this.radioButtonLevel3.AutoSize = true;
            this.radioButtonLevel3.Location = new System.Drawing.Point(790, 216);
            this.radioButtonLevel3.Name = "radioButtonLevel3";
            this.radioButtonLevel3.Size = new System.Drawing.Size(75, 21);
            this.radioButtonLevel3.TabIndex = 16;
            this.radioButtonLevel3.TabStop = true;
            this.radioButtonLevel3.Text = "Level 3";
            this.radioButtonLevel3.UseVisualStyleBackColor = true;
            this.radioButtonLevel3.CheckedChanged += new System.EventHandler(this.radioButtonLevel3_CheckedChanged);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 631);
            this.Controls.Add(this.radioButtonLevel3);
            this.Controls.Add(this.radioButtonLevel2);
            this.Controls.Add(this.radioButtonLevel1);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelChances);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxHighscoreTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChances;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.RadioButton radioButtonLevel1;
        private System.Windows.Forms.RadioButton radioButtonLevel2;
        private System.Windows.Forms.RadioButton radioButtonLevel3;
    }
}