namespace BasicFacebookFeatures
{
    using FacebookWrapper.ObjectModel;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    public class FacadeGame
    {
        private readonly LogicGame r_LogicGame;
        private List<ScoreTableItem> m_ScoreTable;
        public Func<int, int> ScoreStrategy { get; set; }

        public List<ScoreTableItem> ScoreTable { get => m_ScoreTable; set => m_ScoreTable = value; }

        public FacadeGame()
        {
            r_LogicGame = new LogicGame();
            m_ScoreTable = new List<ScoreTableItem>();
        }

        public int GetRoundsNumber() => r_LogicGame.RoundsNumber;

        public int GetTimeForRound() => r_LogicGame.TimeForRound;
 
        public string GetNextPhoto() => r_LogicGame.GetNextlPhoto();

        public void RestData() => r_LogicGame.RestData();

        public void IsCorrrectAswer(string i_UserAnswer) => r_LogicGame.CheckCorrrectAswer(i_UserAnswer);
  
        public int GetWins() => r_LogicGame.Wins;


        public int GetRoundCounter() => r_LogicGame.RoundCounter;

        public List<Photo> GetRandomPhotos() => r_LogicGame.PhotosList;

        public int GetScore()
        {
            r_LogicGame.Score = ScoreStrategy.Invoke(r_LogicGame.Wins);
            return r_LogicGame.Score;
        }

        public void SetTimeForRound(int i_Seconds) 
        {
            r_LogicGame.TimeForRound = i_Seconds;
        }


        public void AddEndGameScore()
        {
            ScoreTableItem item = new ScoreTableItem(DateTime.Now, r_LogicGame.Score);
            ScoreTable.Add(item);
        }

        public void ScoreIterator()
        {
            var projectScore = from score in ScoreTable 
                               where score.Score != 0 
                               orderby score.Score 
                               select new { score.Date, score.Score };

            m_ScoreTable.Clear();
            const int k_NumOfScors = 10;
            int count = 0;

            foreach (var score in projectScore) 
            {
                if (count < k_NumOfScors)
                {
                    ScoreTableItem item = new ScoreTableItem() { Date = score.Date, Score = score.Score };
                    m_ScoreTable.Add(item);
                    count++;
                }
                else 
                {
                    break;
                }
            }
        }

        public bool IsGameOver() 
        {
            if (r_LogicGame.IsGameOver()) 
            {
                saveToFile("ScoreTable.xml");
                return true;
            }
            return false; ;
        }


        public void LoadRandomPhotos() 
        {
            r_LogicGame.LoadRandomPhotos();
        }

        private object loadFromFile(string i_FileName)
        {
            object obj = null;

            if (File.Exists(i_FileName))
            {
                using (FileStream stream = new FileStream(i_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ScoreTableItem>));
                    obj = (List<ScoreTableItem>)serializer.Deserialize(stream);
                }
            }
            return obj;
        }

        private void saveToFile(string i_FileName)
        {
            ScoreIterator();
            using (FileStream stream = new FileStream(i_FileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<ScoreTableItem>));
                xml.Serialize(stream, m_ScoreTable);
            }
        }

        public void LoadScoreTable()
        {
            List<ScoreTableItem> data = (List<ScoreTableItem>)loadFromFile("ScoreTable.xml");
            m_ScoreTable = data.ToList();
        }


    }
}
