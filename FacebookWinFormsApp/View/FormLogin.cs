namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper;

    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            this.StartPosition = FormStartPosition.Manual;
            FacebookService.s_CollectionLimit = 100;
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Model.Instance.LoginToFacebook();
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            fetchLoggedUser();
        }

        private void fetchLoggedUser()
        {
            Model.Instance.LoggedInUser = Model.Instance.LoginResult.LoggedInUser;
            if (!string.IsNullOrEmpty(Model.Instance.LoginResult.AccessToken))
            {
                pictureBoxLogin.Invoke(new Action(() => pictureBoxLogin.LoadAsync(Model.Instance.ProfilePicture)));
                FormMenu formMenu = new FormMenu(this);
                this.Hide();
                formMenu.Show();                
            }
        }
     
        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";           
		}
    }
}
