using System.Collections.Generic;

namespace FSM
{
    public class State
    {
        public List<StateAction> actions = new List<StateAction>();

        public void Tick(StateManager stateManager)
        {
            if(stateManager.forceExit)
            {
                return;
            }

            for (int i = 0; i < actions.Count; i++)
            {
                actions[i].Execute(stateManager);
            }
        }
    }
}