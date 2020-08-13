using GameEvents;
using UnityEngine;

namespace Smot
{
    public class BattleManager : MonoBehaviour, IGameEventListener
    {
        public static BattleManager instance;

        [SerializeField]
        public Actor[] playerUnits;

        [SerializeField]
        public Actor[] enemyUnits;

        void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(this.gameObject);

            GameEventManager.RegisterListener(this);
        }

        void OnDestroy()
        {
            GameEventManager.UnregisterListener(this);
        }

        public void eventReceived(IGameEvent e)
        {
            if (e is InitBattleStateEvent)
            {
                this.playerUnits = (e as InitBattleStateEvent).getPlayerUnits();
                this.enemyUnits = (e as InitBattleStateEvent).getEnemyUnits();
            }
        }
    }

}