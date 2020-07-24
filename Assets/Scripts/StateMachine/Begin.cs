using Com.InfallibleCode.TurnBasedGame.Combat;
using System.Collections;
using UnityEngine;

namespace Combat
{
    public class Begin : State
    {
        public Begin(BattleSystem battleSystem) : base(battleSystem)
        {

        }

        public override IEnumerator Start()
        {
            battleSystem.Interface.SetDialogText($"A wild {battleSystem.Enemy.Name} appeared!");

            yield return new WaitForSeconds(2f);

            battleSystem.SetState(new PlayerTurn(battleSystem));
        }
    }
}
