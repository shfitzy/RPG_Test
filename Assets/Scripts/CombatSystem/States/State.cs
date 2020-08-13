using System.Collections;

namespace CombatSystem
{
    public abstract class State
    {
		protected CombatSystem combatSystem;

		public State(CombatSystem combatSystem)
		{
			this.combatSystem = combatSystem;
		}

		public virtual IEnumerator Enter()
		{
			yield break;
		}

		public virtual IEnumerator Exit()
		{
			yield break;
		}
	}
}
