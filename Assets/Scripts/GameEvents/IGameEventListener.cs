namespace GameEvents
{
    public interface IGameEventListener
    {
        void eventReceived(IGameEvent e);
    }
}