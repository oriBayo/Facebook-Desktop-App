namespace BasicFacebookFeatures
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormAlert : Form
    {
        private enumAction action;
        private int m_X, m_Y;
        public FormAlert()
        {
            InitializeComponent();
        }

        public enum enumAction 
        {
            Wait,
            Start,
            Close
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            timerAlert.Interval = 1;
            action = enumAction.Close;
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            switch (this.action) 
            {
                case enumAction.Wait:  
                    timerAlert.Interval = 10000;
                    action = enumAction.Close;
                    break;
                case enumAction.Start:
                    timerAlert.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.m_X < this.Location.X)
                    {
                        this.Left--;
                    }
                    else 
                    {
                        if (this.Opacity == 1.0) 
                        {
                            action = enumAction.Wait;
                        }
                    }
                    break;
                case enumAction.Close:
                    timerAlert.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
 
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }                
                    break;
            }
        }

        public void ShowAlert(string i_Msg) 
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string formName;

            for (int i = 1; i < 10; i++)
            {
                formName = "alert" + i.ToString();
                FormAlert formAlert = Application.OpenForms[formName] as FormAlert;
                if (formAlert == null) 
                {
                    this.Name = formName;
                    this.m_X = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.m_Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.m_X, this.m_Y);
                    break;
                }
            }
            this.m_X = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.labelMessageText.Text = i_Msg;
            this.Show();
            this.action = enumAction.Start;
            this.timerAlert.Interval = 1;
            timerAlert.Start();
            
        }
    }
}
