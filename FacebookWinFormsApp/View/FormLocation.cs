namespace BasicFacebookFeatures
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class FormLocation : Form
    {
        public FormLocation()
        {
            InitializeComponent();
        }

        private void buttonGetLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string city = Model.Instance.Location;
                StringBuilder address = new StringBuilder();
                address.Append("http://maps.google.com/maps?q=");
                address.Append(city);
                webBrowserLocation.Invoke(new Action(() => webBrowserLocation.Navigate(address.ToString() + "," + "+")));
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            
        }
    }
}
