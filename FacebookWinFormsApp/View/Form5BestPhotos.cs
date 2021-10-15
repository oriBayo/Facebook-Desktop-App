namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class Form5BestPhotos : Form
    {

        public Form5BestPhotos()
        {
            InitializeComponent(); 
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            fetchPhotos();

        }

        private void fetchPhotos()
        {
            Dictionary<Photo, int> bestPhotos = new Dictionary<Photo, int>();
            foreach (Album album in Model.Instance.Albums) 
            {
                foreach (Photo photo in album.Photos) 
                {
                    listBoxCountComments.Invoke(new Action(()=>listBoxCountComments.Items.Add(photo.Comments.Count))); 
                }
            }

            try
            {           
                pictureBox1.LoadAsync(bestPhotos.ElementAt(0).Key.PictureNormalURL);
                label1.Text = bestPhotos.ElementAt(0).Value.ToString();

                pictureBox2.LoadAsync(bestPhotos.ElementAt(1).Key.PictureNormalURL);
                label2.Text = bestPhotos.ElementAt(1).Value.ToString();

                pictureBox3.LoadAsync(bestPhotos.ElementAt(2).Key.PictureNormalURL);
                label3.Text = bestPhotos.ElementAt(2).Value.ToString();

                pictureBox4.LoadAsync(bestPhotos.ElementAt(3).Key.PictureNormalURL);
                label4.Text = bestPhotos.ElementAt(3).Value.ToString();

                pictureBox5.LoadAsync(bestPhotos.ElementAt(4).Key.PictureNormalURL);
                label5.Text = bestPhotos.ElementAt(4).Value.ToString();

            }
            catch (Exception exception)
            {
                exception.Message.ToString();
            }
        }
    }
}
