namespace BasicFacebookFeatures
{
    using FacebookWrapper.ObjectModel;
    using System;

    class EventProxy
    {
        private Event m_Event{ get; set; }

        public event Action<Event> eventsListenenrs;


        public EventProxy(Event i_Event) 
        {
            m_Event = i_Event;
            CheckIfHaveEventToday();
        }

        public void CheckIfHaveEventToday() 
        {
            DateTime eventStartTime = m_Event.StartTime.Value;
            DateTime timeNow = DateTime.Now;
            if (eventStartTime.Year == timeNow.Year && eventStartTime.Month == timeNow.Month && eventStartTime.Day == timeNow.Day) 
            {
                doWhenHaveEvent();
            }
        }
        private void doWhenHaveEvent() 
        {
            eventsListenenrs?.Invoke(m_Event);
        }
    }
}
