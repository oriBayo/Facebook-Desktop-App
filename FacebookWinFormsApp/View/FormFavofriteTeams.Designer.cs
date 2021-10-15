
namespace BasicFacebookFeatures
{
    partial class FormFavoriteTeam
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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.buttonFetchFavofriteTeams = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvents.Location = new System.Drawing.Point(0, 47);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewEvents.RowTemplate.Height = 24;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1001, 577);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // buttonFetchFavofriteTeams
            // 
            this.buttonFetchFavofriteTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFetchFavofriteTeams.Location = new System.Drawing.Point(0, 0);
            this.buttonFetchFavofriteTeams.Name = "buttonFetchFavofriteTeams";
            this.buttonFetchFavofriteTeams.Size = new System.Drawing.Size(1001, 47);
            this.buttonFetchFavofriteTeams.TabIndex = 6;
            this.buttonFetchFavofriteTeams.Text = "Fetch Favofrite Teams";
            this.buttonFetchFavofriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavofriteTeams.Click += new System.EventHandler(this.buttonFetchCheckin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewEvents);
            this.panel1.Controls.Add(this.buttonFetchFavofriteTeams);
            this.panel1.Location = new System.Drawing.Point(27, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 624);
            this.panel1.TabIndex = 7;
            // 
            // FormFavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 690);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "FormFavoriteTeam";
            this.Text = "FormEvents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button buttonFetchFavofriteTeams;
        private System.Windows.Forms.Panel panel1;
    }
}