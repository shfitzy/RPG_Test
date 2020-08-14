using GameEvents;
using UnityEngine;

namespace CombatSystem
{
    public class CombatSystem : MonoBehaviour, IGameEventListener
    {
        [SerializeField] private CombatUI combatUI;
        public CombatUI Interface => combatUI;

        private State currentState;

        void Start()
        {
            GameEventManager.RegisterListener(this);

            SetState(new BattleInitState(this));
        }

        void OnDestroy()
        {
            GameEventManager.UnregisterListener(this);
        }

        public void SetState(State state)
        {
            if(currentState != null)
            {
                StartCoroutine(currentState.Exit());
            }

            currentState = state;

            StartCoroutine(currentState.Enter());
        }

        public void eventReceived(IGameEvent e)
        {
            if (e is StartNextActorTurnEvent)
            {
                StartNextActorTurn();
            }
        }

        private void StartNextActorTurn()
        {
            float rnd = Random.value;

            if(rnd < 0.3f)
            {
                SetState(new EnemyTurnState(this));
            }
            else if(rnd < 0.6f)
            {
                SetState(new BattlefieldTurnState(this));
            }
            else
            {
                SetState(new PlayerTurnState(this));
            }
        }
    }
}