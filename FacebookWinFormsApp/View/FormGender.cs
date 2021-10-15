namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public partial class FormGender : Form
    {
        public FormGender()
        {
            InitializeComponent();
            pictureBoxGender.SizeMode = PictureBoxSizeMode.StretchImage;

        }     

        private void buttonGender_Click(object sender, EventArgs e)
        {
            fetchGiphyGender();
        }

        private void fetchGiphyGender() 
        {
            if (Model.Instance.Gender == "male")
            {
                pictureBoxGender.Load("https://media.giphy.com/media/ApeyPO6Yi8HBs8Yfyg/giphy.gif");
            }
            else
            {
                pictureBoxGender.Load("https://media.giphy.com/media/3oKIPyRuDfitoVWPWE/giphy.gif");
            }
        }
    }
}
