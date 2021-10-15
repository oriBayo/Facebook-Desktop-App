namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public class LimitedEntryButtonProxy : Button
    {
        private int m_CurrentAge { get; set; }

        public LimitedEntryButtonProxy()
        {
            m_CurrentAge = Model.Instance.GetAge();
        }

        public void SetLimitedEntry(int i_AgeOfEntry)
        {
            if (m_CurrentAge < i_AgeOfEntry)
            {
                this.Enabled = false;
            }
        }

    }
}
