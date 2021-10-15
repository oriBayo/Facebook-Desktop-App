namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
        }

        private void buttonAlbum_Click(object sender, EventArgs e)
        {
            fetchAlbum();
        }

        private void fetchAlbum() 
        {
            albumBindingSource.DataSource = Model.Instance.Albums;
            
        }

        private void fethPhotos() 
        {
            listBoxPhotos.DisplayMember = "Id";

            listBoxPhotos.Items.Clear();
            try
            {
                Album album = listBoxAlbum.SelectedItem as Album;
                if (album != null)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        listBoxPhotos.Invoke(new Action(()=>listBoxPhotos.Items.Add(photo)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            fethPhotos();

        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPhoto();
            fetchComment();
        }

        private void displayPhoto()
        {
            try
            {
                Photo photo = listBoxPhotos.SelectedItem as Photo;
                imageAlbumPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (photo != null) 
                {
                    imageAlbumPictureBox.Invoke(new Action(()=>imageAlbumPictureBox.Load(photo.PictureNormalURL)));
                    labelLikes.Text = photo.Comments.Count.ToString();
                    lableCreatedTime.Text = photo.CreatedTime.ToString();
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchComment() 
        {
            try
            {
                listBoxComments.Items.Clear();
                Photo photo = listBoxPhotos.SelectedItem as Photo;
                foreach (Comment comment in photo.Comments) 
                {
                    listBoxComments.Invoke(new Action(()=>listBoxComments.Items.Add(comment.Message)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Instance.CreateNewAlbum();
        }
    }
}
