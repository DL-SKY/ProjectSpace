using System.Collections.Generic;

namespace ProjectSpace.Events
{
    public static class EventManager
    {
        private static Dictionary<string, CustomEventWrapper> events = new Dictionary<string, CustomEventWrapper>();


        public static void AddEventListener(string _eventType, CustomEventHandler _listener)
        {
            CustomEventWrapper eWrapper = null;

            if (!events.TryGetValue(_eventType, out eWrapper))
            {
                eWrapper = new CustomEventWrapper();
                eWrapper.OnHandler += _listener;
                events.Add(_eventType, eWrapper);
            }
            else
            {
                eWrapper.OnHandler += _listener;
            }
        }

        public static void RemoveEventListener(string _eventType, CustomEventHandler _listener)
        {
            CustomEventWrapper eWrapper = null;

            if (events.TryGetValue(_eventType, out eWrapper))
            {
                eWrapper.OnHandler -= _listener;
            }
        }

        public static void DispatchEvent(CustomEvent _event)
        {
            CustomEventWrapper eWrapper = null;

            if (events.TryGetValue(_event.EventType, out eWrapper))
            {
                eWrapper.Invoke(_event);
            }
        }

        public static void DispatchEvent(string _type, object _data = null)
        {
            var customEvent = new CustomEvent(_type, _data);
            DispatchEvent(customEvent);
        }

        public static void Clear()
        {
            foreach (var _event in events)
                _event.Value.Clear();

            events.Clear();
        }
    }
}