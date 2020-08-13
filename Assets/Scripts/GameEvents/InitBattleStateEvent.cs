using Combat;
using System.Linq;

namespace GameEvents
{
    class InitBattleStateEvent : IGameEvent
    {
        private readonly Actor[] playerUnits;
        private readonly Actor[] enemyUnits;

        public InitBattleStateEvent(Actor[] playerUnits, Actor[] enemyUnits)
        {
            this.playerUnits = playerUnits;
            this.enemyUnits = enemyUnits;
        }

        public Actor[] getPlayerUnits()
        {
            return playerUnits;
        }

        public Actor[] getEnemyUnits()
        {
            return enemyUnits;
        }
    }
}