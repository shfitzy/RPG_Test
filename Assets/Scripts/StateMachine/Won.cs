using Com.InfallibleCode.TurnBasedGame.Combat;
using System.Collections;

namespace Combat
{
    internal class Won : State
    {
        public Won(BattleSystem battleSystem) : base(battleSystem)
        {

        }

        public override IEnumerator Start()
        {
            battleSystem.Interface.SetDialogText("You won the battle!");
            yield break;
        }
    }
}