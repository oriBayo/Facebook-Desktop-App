namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            fetchStatus();
        }

        private void fetchStatus() 
        {
            postBindingSource.DataSource = Model.Instance.LoggedInUser.NewsFeed;     
        }
    
    }
}
