namespace ProjectSpace.Events
{
    public delegate void CustomEventHandler(CustomEvent _event);


    public class CustomEvent
    {
        public string EventType
        {
            get;
            private set;
        }

        public object EventData
        {
            get;
            private set;
        }

        public CustomEvent(string _type, object _data = null)
        {
            EventType = _type;
            EventData = _data;
        }
    }
}