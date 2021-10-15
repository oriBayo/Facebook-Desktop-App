
namespace BasicFacebookFeatures
{
    partial class FormLocation
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
            this.components = new System.ComponentModel.Container();
            this.webBrowserLocation = new System.Windows.Forms.WebBrowser();
            this.buttonGetLocation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserLocation
            // 
            this.webBrowserLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserLocation.Location = new System.Drawing.Point(0, 53);
            this.webBrowserLocation.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserLocation.Name = "webBrowserLocation";
            this.webBrowserLocation.Size = new System.Drawing.Size(1087, 1002);
            this.webBrowserLocation.TabIndex = 1;
            // 
            // buttonGetLocation
            // 
            this.buttonGetLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGetLocation.Location = new System.Drawing.Point(0, 0);
            this.buttonGetLocation.Name = "buttonGetLocation";
            this.buttonGetLocation.Size = new System.Drawing.Size(1087, 53);
            this.buttonGetLocation.TabIndex = 2;
            this.buttonGetLocation.Text = "Get Location";
            this.buttonGetLocation.UseVisualStyleBackColor = true;
            this.buttonGetLocation.Click += new System.EventHandler(this.buttonGetLocation_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowserLocation);
            this.panel1.Controls.Add(this.buttonGetLocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 1055);
            this.panel1.TabIndex = 3;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Location);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 1055);
            this.panel2.TabIndex = 6;
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1087, 1055);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "FormLocation";
            this.Text = "FormLocation";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowserLocation;
        private System.Windows.Forms.Button buttonGetLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Panel panel2;
    }
}