namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public partial class FormBirthday : Form
    {
        private int m_Ticks;

        public FormBirthday()
        {
            InitializeComponent();
            DateTime date = DateTime.Parse(Model.Instance.Birthday);
            DateTime today = DateTime.Today;
            TimeSpan timeLeft = today - date;
            dateTimePickerBirthday.Value = date; 
            labelDaysNumber.Text = timeLeft.TotalDays.ToString();
            labelMonthNumber.Text = ((int)(timeLeft.TotalDays / 30)).ToString();
            labelHoursNumber.Text = timeLeft.TotalHours.ToString();
            labelminutesNumber.Text = timeLeft.TotalMinutes.ToString();
            labelSecondsNumber.Text = timeLeft.TotalSeconds.ToString();
            labelYearsNunber.Text = ((int)(timeLeft.TotalDays / 365)).ToString();

            m_Ticks = int.Parse(labelSecondsNumber.Text);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (m_Ticks % 60 == 0) 
            {
                labelminutesNumber.Text = (int.Parse(labelminutesNumber.Text) + 1).ToString();                

            }
            if (m_Ticks % 3600 == 0) 
            {
                labelHoursNumber.Text = (int.Parse(labelHoursNumber.Text) + 1).ToString();
            }
            m_Ticks++;
            labelSecondsNumber.Text = m_Ticks.ToString();          
        }
    }
}
