using GameEvents;
using System.Collections;
using UnityEngine;

namespace CombatSystem
{
    public class EnemyTurnState : State
    {
        public EnemyTurnState(CombatSystem combatSystem) : base(combatSystem)
        {

        }

        public override IEnumerator Enter()
        {
            combatSystem.Interface.DisablePlayerUI();

            Debug.Log("Enter Enemy State");
            yield return new WaitForSeconds(1f);

            GameEventManager.PostEvent(new StartNextActorTurnEvent());
        }

        public override IEnumerator Exit()
        {
            Debug.Log("Exit Enemy State");

            yield return 0;
        }
    }
}
