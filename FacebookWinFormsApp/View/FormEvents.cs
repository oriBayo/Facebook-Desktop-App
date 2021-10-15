namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class FormEvent : Form
    {
        
        public FormEvent()
        {
            FacebookService.s_CollectionLimit = 100;
            InitializeComponent();       
        }

        private void buttonFetchEvent_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event ev in Model.Instance.Events) 
            {  
                EventProxy eventProxy = new EventProxy(ev);
                eventProxy.eventsListenenrs += (this.invokeAlert);
                listBoxEvents.Items.Add(ev);
                eventProxy.CheckIfHaveEventToday();
            }
        }

        private void invokeAlert(Event i_Event) 
        {
            FormAlert alert = new FormAlert();
            alert.ShowAlert(i_Event.Name);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionTextBox.Clear();
            endTimeLabel2.Text = "";
            startTimeLabel2.Text = "";
            labelLocation.Text = "";

            if (listBoxEvents.SelectedIndex == 1) 
            {
                Event currEvent = listBoxEvents.SelectedItem as Event;
                descriptionTextBox.Text = currEvent.Description;
                endTimeLabel2.Text = currEvent.EndTime.ToString();
                startTimeLabel2.Text = currEvent.StartTime.ToString();
                labelLocation.Text = currEvent.Location.ToString();
            }
        }
    }
}
