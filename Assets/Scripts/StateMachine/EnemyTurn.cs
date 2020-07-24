using Com.InfallibleCode.TurnBasedGame.Combat;
using System.Collections;
using UnityEngine;

namespace Combat
{
    internal class EnemyTurn : State
    {
        public EnemyTurn(BattleSystem battleSystem) : base(battleSystem)
        {

        }

        public override IEnumerator Start()
        {
            battleSystem.Interface.SetDialogText($"{battleSystem.Enemy.Name} attacks!");

            var isDead = battleSystem.Player.Damage(battleSystem.Enemy.Attack);

            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                battleSystem.SetState(new Lost(battleSystem));
            }
            else
            {
                battleSystem.SetState(new PlayerTurn(battleSystem));
            }
        }
    }
}