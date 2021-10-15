namespace BasicFacebookFeatures
{
    using System;
    using System.Threading;
    using System.Timers;
    using System.Windows.Forms;

    public partial class FormGame : Form
    {
        private readonly FacadeGame r_FacadeGame = new FacadeGame();
        private System.Timers.Timer m_timer;
        private int m_Seconds;

        public FacadeGame FacadeGame => r_FacadeGame;
        public System.Timers.Timer Timer { get => m_timer; set => m_timer = value; }
        public int Seconds { get => m_Seconds; set => m_Seconds = value; }

        public FormGame()
        {
            InitializeComponent();
            buttonStartGame.Enabled = false;
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            loadScoreTable();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            playGame();
        }

        private void playRound()
        {
            FacadeGame.IsCorrrectAswer(textBoxAnswer.Text);
            labelScore.Text = FacadeGame.GetScore().ToString();
            labelChances.Text = FacadeGame.GetRoundCounter().ToString();
            Seconds = FacadeGame.GetTimeForRound();
            loadNewPhoto();
        }

        private void FormGame_Load(object sender, EventArgs e) => loadData();
     
        private void OnTimeEvent(object sender, ElapsedEventArgs e) => playTimer();

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Stop();
            Application.DoEvents();
        }

        private void loadNewPhoto()
        {
            string photoUrl = FacadeGame.GetNextPhoto();
            pictureBoxPhoto.Invoke(new Action(() => pictureBoxPhoto.Load(photoUrl)));
        }

        private void addToScoreTable()
        {
            listBoxHighscoreTable.Items.Clear();
            listBoxHighscoreTable.BeginUpdate();
            FacadeGame.ScoreIterator();
            foreach (ScoreTableItem item in FacadeGame.ScoreTable)
            {
                listBoxHighscoreTable.Invoke(new Action(() =>
                listBoxHighscoreTable.Items.Add($" Score:{item.Score}   Date:{item.Date.ToString("MM/dd/yyyy HH:mm")}")));
            }
            listBoxHighscoreTable.EndUpdate();
        }

        private void newGame()
        {
            pictureBoxPhoto.Visible = true;
            FacadeGame.RestData();
            Seconds = FacadeGame.GetTimeForRound();
            labelTimer.Text = Seconds.ToString();
            labelChances.Text = FacadeGame.GetRoundCounter().ToString();
            labelScore.Text = FacadeGame.GetScore().ToString();
            loadNewPhoto();         
        }

        private void gameOver()
        {
            Timer.Stop();
            FacadeGame.AddEndGameScore();
            addToScoreTable();
            MessageBox.Show($"Game Over! Your Score is: {FacadeGame.GetWins()}");
            radioButtons();
            pictureBoxPhoto.Visible = false;
        }

        private void playTimer()
        {
            Invoke(new Action(() =>
            {
                Seconds -= 1;                
                if (Seconds == 0)
                {
                    playGame();
                }
                labelTimer.Text = Seconds.ToString();
            }));
        }

        private void loadData()
        {

            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += OnTimeEvent;
        }

        private void loadScoreTable()
        {
            FacadeGame.LoadScoreTable();
            foreach (ScoreTableItem item in FacadeGame.ScoreTable)
            {
                listBoxHighscoreTable.Items.Add(item);
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            radioButtons();
            Thread thread = new Thread(FacadeGame.LoadRandomPhotos);
            thread.Start();
            Thread.Sleep(5000);
            newGame();
            Timer.Start();
        }

        private void playGame() 
        {
            if (FacadeGame.IsGameOver())
            {
                gameOver();
            }
            else
            {
                playRound();
            }
        }

        private void radioButtonLevel1_CheckedChanged(object sender, EventArgs e)
        {
            buttonStartGame.Enabled = true;
            r_FacadeGame.SetTimeForRound(15);
            r_FacadeGame.ScoreStrategy = (win) => win * 1;
        }

        private void radioButtonLevel2_CheckedChanged(object sender, EventArgs e)
        {
            buttonStartGame.Enabled = true;
            r_FacadeGame.SetTimeForRound(10);
            r_FacadeGame.ScoreStrategy = (win) => win * 2;
        }

        private void radioButtonLevel3_CheckedChanged(object sender, EventArgs e)
        {
            buttonStartGame.Enabled = true;
            r_FacadeGame.SetTimeForRound(5);
            r_FacadeGame.ScoreStrategy = (win) => win * 3;
        }     

        private void radioButtons() 
        {
            radioButtonLevel1.Enabled = !radioButtonLevel1.Enabled;
            radioButtonLevel2.Enabled = !radioButtonLevel2.Enabled;
            radioButtonLevel3.Enabled = !radioButtonLevel3.Enabled;
        }
    }
}

