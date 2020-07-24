using Com.InfallibleCode.TurnBasedGame.Combat;
using System.Collections;

namespace Combat
{
    internal class Lost : State
    {
        public Lost(BattleSystem battleSystem) : base(battleSystem)
        {

        }

        public override IEnumerator Start()
        {
            battleSystem.Interface.SetDialogText("You were defeated.");
            yield break;
        }
    }
}