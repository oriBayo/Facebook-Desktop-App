namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;

    public partial class FormFavoriteTeam : Form
    {
        public FormFavoriteTeam()
        {
            InitializeComponent();
        }

        private void buttonFetchCheckin_Click(object sender, EventArgs e)
        {
            dataGridViewEvents.DataSource = Model.Instance.FavofriteTeams;
            for (int i = 1; i <= 20; i++)
            {
                dataGridViewEvents.Columns[i].Visible = false;
            }
            dataGridViewEvents.Columns[22].Visible = false;
            dataGridViewEvents.Columns[23].Visible = false;
            dataGridViewEvents.Columns[24].Visible = false;
            dataGridViewEvents.Columns[25].Visible = false;
        }
    }
}
