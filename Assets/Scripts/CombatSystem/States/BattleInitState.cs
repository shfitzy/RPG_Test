using GameEvents;
using System.Collections;
using UnityEngine;

namespace CombatSystem
{
    public class BattleInitState : State
    {
        public BattleInitState(CombatSystem combatSystem) : base(combatSystem)
        {

        }

        public override IEnumerator Enter()
        {
            GameEventManager.PostEvent(new PlayMusicEvent("BattleTheme"));

            combatSystem.Interface.DisablePlayerUI();

            yield return new WaitForSeconds(2f);

            GameEventManager.PostEvent(new StartNextActorTurnEvent());
        }
    }
}
