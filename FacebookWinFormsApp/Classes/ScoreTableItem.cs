namespace BasicFacebookFeatures
{
    using System;
    using System.Runtime.Serialization;

    [Serializable()]
    public class ScoreTableItem : ISerializable
    {
        private DateTime m_Date;
        private int m_Score;

        public DateTime Date { get => m_Date; set => m_Date = value; }
        public int Score { get => m_Score; set => m_Score = value; }

        public ScoreTableItem(DateTime i_Date, int i_Score)
        {
            m_Date = i_Date;
            m_Score = i_Score;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_Date", m_Date);
            info.AddValue("m_Score", m_Score);
        }

        public ScoreTableItem(SerializationInfo info, StreamingContext context)
        {
            m_Date = (DateTime)info.GetValue("m_Date", typeof(DateTime));
            m_Score = (int)info.GetValue("m_Score", typeof(int));
        }

        public ScoreTableItem()
        {
        }

        public override string ToString()
        {
            return string.Format($" Score:{m_Score}  Date:{m_Date.ToString("MM/dd/yyyy HH:mm")}");
        }
 
    }
}
