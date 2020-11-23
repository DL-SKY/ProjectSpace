namespace ProjectSpace.Events
{
    public class CustomEventWrapper
    {
        public event CustomEventHandler OnHandler;

        public void Invoke(CustomEvent _event)
        {
            OnHandler?.Invoke(_event);
        }

        public void Clear()
        {
            OnHandler = null;
        }
    }
}