
namespace BasicFacebookFeatures
{
    partial class FormEvent
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel1;
            System.Windows.Forms.Label startTimeLabel1;
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeLabel2 = new System.Windows.Forms.Label();
            this.startTimeLabel2 = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel1 = new System.Windows.Forms.Label();
            startTimeLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(480, 30);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel1
            // 
            endTimeLabel1.AutoSize = true;
            endTimeLabel1.Location = new System.Drawing.Point(690, 303);
            endTimeLabel1.Name = "endTimeLabel1";
            endTimeLabel1.Size = new System.Drawing.Size(72, 17);
            endTimeLabel1.TabIndex = 16;
            endTimeLabel1.Text = "End Time:";
            // 
            // startTimeLabel1
            // 
            startTimeLabel1.AutoSize = true;
            startTimeLabel1.Location = new System.Drawing.Point(491, 303);
            startTimeLabel1.Name = "startTimeLabel1";
            startTimeLabel1.Size = new System.Drawing.Size(77, 17);
            startTimeLabel1.TabIndex = 17;
            startTimeLabel1.Text = "Start Time:";
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFetchEvents.Location = new System.Drawing.Point(0, 0);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(384, 47);
            this.buttonFetchEvents.TabIndex = 5;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxEvents);
            this.panel1.Controls.Add(this.buttonFetchEvents);
            this.panel1.Location = new System.Drawing.Point(27, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 595);
            this.panel1.TabIndex = 6;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(0, 47);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(384, 548);
            this.listBoxEvents.TabIndex = 6;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(483, 62);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(582, 205);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // endTimeLabel2
            // 
            this.endTimeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel2.Location = new System.Drawing.Point(773, 303);
            this.endTimeLabel2.Name = "endTimeLabel2";
            this.endTimeLabel2.Size = new System.Drawing.Size(100, 23);
            this.endTimeLabel2.TabIndex = 17;
            this.endTimeLabel2.Text = "01/01/2021";
            // 
            // startTimeLabel2
            // 
            this.startTimeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel2.Location = new System.Drawing.Point(574, 303);
            this.startTimeLabel2.Name = "startTimeLabel2";
            this.startTimeLabel2.Size = new System.Drawing.Size(100, 23);
            this.startTimeLabel2.TabIndex = 18;
            this.startTimeLabel2.Text = "01/01/2021";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(962, 303);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(46, 17);
            this.labelLocation.TabIndex = 19;
            this.labelLocation.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Location:";
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1277, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(startTimeLabel1);
            this.Controls.Add(this.startTimeLabel2);
            this.Controls.Add(endTimeLabel1);
            this.Controls.Add(this.endTimeLabel2);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "FormEvent";
            this.Text = "FormFriends";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label endTimeLabel2;
        private System.Windows.Forms.Label startTimeLabel2;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label label1;
    }
}