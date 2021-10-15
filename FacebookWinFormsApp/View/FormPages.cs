namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public partial class FormPages : Form
    {

        public FormPages()
        {
            InitializeComponent();          
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            fetchPages();
        }

        private void fetchPages() 
        {          
            pageBindingSource.DataSource = Model.Instance.LikedPages;
        }
    }
}
