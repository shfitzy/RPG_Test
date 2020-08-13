using GameEvents;
using System.Collections;
using UnityEngine;

namespace CombatSystem
{
    public class PlayerTurnState : State
    {
        public PlayerTurnState(CombatSystem combatSystem) : base(combatSystem)
        {

        }

        public override IEnumerator Enter()
        {
            combatSystem.Interface.EnablePlayerUI();

            Debug.Log("Enter Player State");

            yield return 0;
        }

        public override IEnumerator Exit()
        {
            Debug.Log("Exit Player State");

            yield return 0;
        }
    }
}
