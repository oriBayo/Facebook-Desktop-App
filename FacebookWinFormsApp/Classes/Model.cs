namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using FacebookWrapper.ObjectModel;
    using FacebookWrapper;
    using System.Collections;
    using System.Linq;

    public sealed class Model
    {
        private static Model s_Instance = null;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        static readonly object sr_InstanceLock = new object();
        private Dictionary<Photo, int> photoLikes = new Dictionary<Photo, int>();

        public static Model Instance 
        {
            get 
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Model();
                        }
                    }
                }

                return s_Instance;
            }
        }
        private Model()
        {
            m_LoginResult = new LoginResult();
            m_LoggedInUser = new User();
        }

        public LoginResult LoginResult { get => m_LoginResult; set => m_LoginResult = value; }

        public User LoggedInUser { get => m_LoggedInUser; set => m_LoggedInUser = value; }


        public String UserName
        {
            get { return LoggedInUser.Name; }
        }

        public String ProfilePicture
        {
            get { return m_LoggedInUser.PictureLargeURL; }
        }

        public String Location
        {
            get { return LoggedInUser.Location.Name; }
        }

        public FacebookObjectCollection<Event> Events 
        {
            get { return LoggedInUser.Events; }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get { return LoggedInUser.LikedPages; }
        }

        public String Gender
        {
            get { return LoggedInUser.Gender.ToString(); }
        }

        public String Birthday
        {
            get { return LoggedInUser.Birthday; }
        }

        public ICollection<Album> Albums
        {
            get { return LoggedInUser.Albums; }
        }

        public Page[] FavofriteTeams
        {
            get { return LoggedInUser.FavofriteTeams; }
        }

        public FacebookObjectCollection<Photo> Photos
        {
            get { return LoggedInUser.PhotosTaggedIn; }
        }

        public Dictionary<Photo, int> PhotosSortedByLikes
        {
            get
            {           
                foreach (Album album in LoggedInUser.Albums)
                {
                    countLikes(album);
                }
                photoLikes.Cast<DictionaryEntry>().OrderBy(entry => entry.Value).ToList();

                return photoLikes;
            }
        }
        public void CreateNewAlbum() 
        {
            m_LoggedInUser.CreateAlbum("2021");
        }

        public int GetAge()
        {
            DateTime birthday = DateTime.Parse(Birthday);
            int age = 0;
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;

            return age;
        }

        private void countLikes(Album album) 
        {
            foreach (Photo photo in album.Photos) 
            {
                photoLikes.Add(photo, photo.Comments.Count);
            }
        }

        public void LogOutFromFacebook()
        {
            FacebookService.LogoutWithUI();
        }

        public void LoginToFacebook()
        {
            connectClient();
        }

        private void connectClient()
        {
            LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "1897197683774572",
                    /// requested permissions:
                    "email",
                   "public_profile",
                   "user_age_range",
                   "user_birthday",
                   "user_events",
                   "user_friends",
                   "user_gender",
                   "user_hometown",
                   "user_likes",
                   "user_link",
                   "user_location",
                   "user_photos",
                   "user_posts",
                   "user_videos"
                    /// add any relevant permissions
                    );
        }
    }
}
