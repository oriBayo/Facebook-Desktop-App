
namespace BasicFacebookFeatures
{
    partial class FormAlbum
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label countLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxAlbum = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAlbum = new System.Windows.Forms.Button();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.labelLikes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lableCreatedTime = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            createdTimeLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(701, 132);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(105, 17);
            createdTimeLabel.TabIndex = 10;
            createdTimeLabel.Text = "Album Created:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(701, 88);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(113, 17);
            countLabel.TabIndex = 125;
            countLabel.Text = "Photos in album:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxAlbum);
            this.panel1.Controls.Add(this.buttonAlbum);
            this.panel1.Location = new System.Drawing.Point(27, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 624);
            this.panel1.TabIndex = 1;
            // 
            // listBoxAlbum
            // 
            this.listBoxAlbum.DataSource = this.albumBindingSource;
            this.listBoxAlbum.DisplayMember = "Name";
            this.listBoxAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAlbum.FormattingEnabled = true;
            this.listBoxAlbum.ItemHeight = 16;
            this.listBoxAlbum.Location = new System.Drawing.Point(0, 49);
            this.listBoxAlbum.MultiColumn = true;
            this.listBoxAlbum.Name = "listBoxAlbum";
            this.listBoxAlbum.Size = new System.Drawing.Size(388, 575);
            this.listBoxAlbum.TabIndex = 3;
            this.listBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbum_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // buttonAlbum
            // 
            this.buttonAlbum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlbum.Location = new System.Drawing.Point(0, 0);
            this.buttonAlbum.Name = "buttonAlbum";
            this.buttonAlbum.Size = new System.Drawing.Size(388, 49);
            this.buttonAlbum.TabIndex = 2;
            this.buttonAlbum.Text = "Fetch Album";
            this.buttonAlbum.UseVisualStyleBackColor = true;
            this.buttonAlbum.Click += new System.EventHandler(this.buttonAlbum_Click);
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(704, 212);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(354, 269);
            this.imageAlbumPictureBox.TabIndex = 17;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countLabel1.Location = new System.Drawing.Point(823, 88);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(100, 23);
            this.countLabel1.TabIndex = 126;
            this.countLabel1.Text = "0";
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 16;
            this.listBoxPhotos.Location = new System.Drawing.Point(439, 36);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(231, 628);
            this.listBoxPhotos.TabIndex = 127;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(788, 176);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(16, 17);
            this.labelLikes.TabIndex = 128;
            this.labelLikes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "Comments:";
            // 
            // lableCreatedTime
            // 
            this.lableCreatedTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.lableCreatedTime.Location = new System.Drawing.Point(812, 132);
            this.lableCreatedTime.Name = "lableCreatedTime";
            this.lableCreatedTime.Size = new System.Drawing.Size(100, 23);
            this.lableCreatedTime.TabIndex = 129;
            this.lableCreatedTime.Text = "0";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(707, 516);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(362, 148);
            this.listBoxComments.TabIndex = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1115, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 48);
            this.button1.TabIndex = 131;
            this.button1.Text = "Creat new album";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1470, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.lableCreatedTime);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPhotos);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countLabel1);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "FormAlbum";
            this.Text = "FormAlbum";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAlbum;
        private System.Windows.Forms.ListBox listBoxAlbum;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableCreatedTime;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Button button1;
    }
}