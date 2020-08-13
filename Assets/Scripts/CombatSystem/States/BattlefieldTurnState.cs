using GameEvents;
using System.Collections;
using UnityEngine;

namespace CombatSystem
{
    public class BattlefieldTurnState : State
    {
        public BattlefieldTurnState(CombatSystem combatSystem) : base(combatSystem)
        {

        }

        public override IEnumerator Enter()
        {
            combatSystem.Interface.DisablePlayerUI();

            Debug.Log("Enter Battlefield State");
            yield return new WaitForSeconds(1f);

            GameEventManager.PostEvent(new StartNextActorTurnEvent());
        }

        public override IEnumerator Exit()
        {
            Debug.Log("Exit Battlefield State");

            yield return 0;
        }
    }
}
