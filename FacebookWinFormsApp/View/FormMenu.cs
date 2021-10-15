namespace BasicFacebookFeatures
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FormMenu : Form
    {
        private LimitedEntryButtonProxy buttonGame;
        public FormLogin m_MainForm { get; set; }
        
        public FormMenu(FormLogin i_FormMain)
        {
            this.m_MainForm = i_FormMain;
            InitializeComponent();
            initiolizeButtonGame();
            customizeDesing();



            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.LoadAsync(Model.Instance.ProfilePicture);
            labelUserName.Text = $"Welcome {Model.Instance.UserName}";
            labelAlbum.Text = Model.Instance.Albums.Count().ToString();
            labelFavoriteTeams.Text = Model.Instance.FavofriteTeams.Length.ToString();
            labelEvents.Text = Model.Instance.LoggedInUser.Events.Count.ToString();
            labelVideos.Text = Model.Instance.LoggedInUser.Videos.Count.ToString();
            labelPosts.Text = Model.Instance.LoggedInUser.Posts.Count.ToString();
            labelFriends.Text = Model.Instance.LoggedInUser.Friends.Count.ToString();
        }
        private void initiolizeButtonGame() 
        {
            this.buttonGame = new LimitedEntryButtonProxy();
            this.buttonGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGame.FlatAppearance.BorderSize = 0;
            this.buttonGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGame.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGame.ForeColor = System.Drawing.Color.LightGray;
            this.buttonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGame.Location = new System.Drawing.Point(0, 128);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonGame.Size = new System.Drawing.Size(229, 48);
            this.buttonGame.TabIndex = 4;
            this.buttonGame.Text = "Game";
            this.buttonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            this.panelAboutMeSubMenu.Controls.Add(this.buttonGame);
        }

        private void customizeDesing() 
        {
            panelSocialSubMenu.Visible = false;
            panelAboutMeSubMenu.Visible = false;
        }

        private void hideSubMenu() 
        {
            if (panelAboutMeSubMenu.Visible == true) 
            {
                panelAboutMeSubMenu.Visible = false;
            }
            if (panelSocialSubMenu.Visible == true) 
            {
                panelSocialSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel panel) 
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else 
            {
                panel.Visible = false;
            }
        }

        private void buttonAboutMe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAboutMeSubMenu);
        }

        private void buttonSocial_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSocialSubMenu);
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLocation());
            hideSubMenu();         
        }

        private void buttonBirthday_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBirthday());
            hideSubMenu();
        }

        private void buttonGender_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGender());
            hideSubMenu();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEvent());
            hideSubMenu();
        }

        private void buttonFavoritesTeam_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFavoriteTeam());
            hideSubMenu();
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPages());
            hideSubMenu();
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5BestPhotos());
            hideSubMenu();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new FormStatus());
            hideSubMenu();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInfo());
            hideSubMenu();
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGame());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form i_ChildForm) 
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = i_ChildForm;
            i_ChildForm.TopLevel = false;
            i_ChildForm.FormBorderStyle = FormBorderStyle.None;
            i_ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(i_ChildForm);
            panelChildForm.Tag = i_ChildForm;
            i_ChildForm.BringToFront();
            i_ChildForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            m_MainForm.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            m_MainForm.Show();                     
        }

        private void button_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAlbum());
            hideSubMenu();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timerDate.Start();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
