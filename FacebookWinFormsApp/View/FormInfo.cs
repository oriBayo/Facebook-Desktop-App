namespace BasicFacebookFeatures
{
    using FacebookWrapper.ObjectModel;
    using System;
    using System.Windows.Forms;

    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();      
        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            navigateToWebInfo();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            fetchPages();
        }

        private void fetchPages() 
        {
            try
            {
                foreach (Page page in Model.Instance.FavofriteTeams)
                {
                    listBoxInfo.Invoke(new Action(()=>listBoxInfo.Items.Add(page.Name)));
                }
                foreach (Page page in Model.Instance
                    .LikedPages)
                {
                    listBoxInfo.Invoke(new Action(()=>listBoxInfo.Items.Add(page.Name)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigateToWebInfo() 
        {
            if (listBoxInfo.SelectedItems.Count == 1)
            {
                String selectedPage = listBoxInfo.SelectedItem.ToString();
                webBrowser.Invoke(new Action(()=> webBrowser.Navigate($"https://he.wikipedia.org/wiki/{selectedPage}")));
            }
        }
    }
}
