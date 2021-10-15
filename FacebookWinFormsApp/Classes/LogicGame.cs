namespace BasicFacebookFeatures
{
    using FacebookWrapper.ObjectModel;
    using System;
    using System.Collections.Generic;
    class LogicGame
    {
        private int m_TimeForRound = 5;
        private const int k_RoundsNumber = 10;
        private readonly List<Photo> r_PhotosList = new List<Photo>();
        private readonly Random r_Generator = new Random();
        private int m_RoundCounter;
        private int m_Wins;
        private int m_Pos;
        private int m_score;
       
        public int RoundCounter { get => m_RoundCounter; set => m_RoundCounter = value; }
        public int Wins { get => m_Wins; set => m_Wins = value; }
        public int Pos { get => m_Pos; set => m_Pos = value; }
        public int TimeForRound { get => m_TimeForRound; set => m_TimeForRound = value; }
        public int RoundsNumber { get => k_RoundsNumber; }
        public List<Photo> PhotosList => r_PhotosList;
        public int Score { get => m_score; set => m_score = value; }

        public void LoadRandomPhotos()
        {
            PhotosList.Clear();
            for (int i = 0; i < k_RoundsNumber; i++)
            {
                int albumSize = Model.Instance.Albums.Count;
                Album album = Model.Instance.LoggedInUser.Albums[r_Generator.Next(albumSize)];
                int photosInAlbumSize = album.Photos.Count;
                Photo photo = album.Photos[r_Generator.Next(photosInAlbumSize)];
                r_PhotosList.Add(photo);
            }
        }

        public void CheckCorrrectAswer(string i_UserAnswer)
        {
            string correctAnswer = r_PhotosList[Pos].CreatedTime.Value.Year.ToString();
            if (correctAnswer == i_UserAnswer)
            {
                Wins += 1;
            }
            else
            {
                if (Wins > 0)
                {
                    Wins -= 1;
                }
            }
            Pos += 1;
            RoundCounter -= 1;
        }


        public void RestData()
        {
            Wins = 0;        
            RoundCounter = k_RoundsNumber;
            Pos = 0;
        }

        public string GetNextlPhoto() 
        {
            return r_PhotosList[m_Pos].PictureNormalURL;
        }

        public bool IsGameOver() 
        {
            if (m_RoundCounter == 1) 
            {
                return true;
            }
            return false;
        }   
    }
}
