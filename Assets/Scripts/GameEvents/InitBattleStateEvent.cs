using Combat;
using System.Linq;

namespace GameEvents
{
    class InitBattleStateEvent : IGameEvent
    {
        private readonly CreatureData[] playerUnits;
        private readonly CreatureData[] enemyUnits;

        public InitBattleStateEvent(CreatureData[] playerUnits, CreatureData[] enemyUnits)
        {
            this.playerUnits = playerUnits;
            this.enemyUnits = enemyUnits;
        }

        public CreatureData[] getPlayerUnits()
        {
            return playerUnits;
        }

        public CreatureData[] getEnemyUnits()
        {
            return enemyUnits;
        }
    }
}