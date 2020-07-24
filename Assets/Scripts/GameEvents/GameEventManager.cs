using System;
using System.Collections.Generic;
using System.Linq;

namespace GameEvents
{
    public class GameEventManager
    {
        static List<WeakReference> listeners = new List<WeakReference>();

        public static void RegisterListener(IGameEventListener listener)
        {
            listeners.Add(new WeakReference(listener));
        }

        public static void UnregisterListener(IGameEventListener listener)
        {
            listeners.RemoveAll(x => x.Target == listener);
        }

        public static void PostEvent(IGameEvent e)
        {
            var aliveList = (from el in listeners where el.IsAlive select el);

            listeners = aliveList.ToList();

            foreach(WeakReference weakRef in listeners)
            {
                (weakRef.Target as IGameEventListener).eventReceived(e);
            }
        }
    }
}