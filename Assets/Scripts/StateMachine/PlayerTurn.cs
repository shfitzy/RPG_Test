using Com.InfallibleCode.TurnBasedGame.Combat;
using System.Collections;
using UnityEngine;

namespace Combat
{
    internal class PlayerTurn : State
    {
        public PlayerTurn(BattleSystem battleSystem) : base(battleSystem)
        {

        }

        public override IEnumerator Start()
        {
            battleSystem.Interface.SetDialogText("Choose an action.");
            yield break;
        }

        public override IEnumerator Attack()
        {
            var isDead = battleSystem.Enemy.Damage(battleSystem.Player.Attack);

            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                battleSystem.SetState(new Won(battleSystem));
            }
            else
            {
                battleSystem.SetState(new EnemyTurn(battleSystem));
            }
        }

        public override IEnumerator Heal()
        {
            battleSystem.Interface.SetDialogText($"{battleSystem.Player.Name} feels renewed strength!");

            battleSystem.Player.Heal(5);

            yield return new WaitForSeconds(1f);

            battleSystem.SetState(new EnemyTurn(battleSystem));
        }
    }
}