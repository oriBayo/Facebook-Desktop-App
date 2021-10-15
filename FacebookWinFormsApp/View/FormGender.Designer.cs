
namespace BasicFacebookFeatures
{
    partial class FormGender
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
            this.pictureBoxGender = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGender
            // 
            this.pictureBoxGender.BackColor = System.Drawing.Color.White;
            this.pictureBoxGender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxGender.Location = new System.Drawing.Point(0, 63);
            this.pictureBoxGender.Name = "pictureBoxGender";
            this.pictureBoxGender.Size = new System.Drawing.Size(634, 484);
            this.pictureBoxGender.TabIndex = 2;
            this.pictureBoxGender.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGender);
            this.panel1.Controls.Add(this.pictureBoxGender);
            this.panel1.Location = new System.Drawing.Point(197, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 547);
            this.panel1.TabIndex = 3;
            // 
            // buttonGender
            // 
            this.buttonGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGender.Location = new System.Drawing.Point(0, 0);
            this.buttonGender.Name = "buttonGender";
            this.buttonGender.Size = new System.Drawing.Size(634, 57);
            this.buttonGender.TabIndex = 3;
            this.buttonGender.Text = "Who Am I";
            this.buttonGender.UseVisualStyleBackColor = true;
            this.buttonGender.Click += new System.EventHandler(this.buttonGender_Click);
            // 
            // FormGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 690);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "FormGender";
            this.Text = "FormGender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGender;
    }
}