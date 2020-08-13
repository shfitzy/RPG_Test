using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public abstract class StateManager : MonoBehaviour
    {
        public State currentState;
        public bool forceExit;

        private void Start()
        {
            Init();
        }

        public abstract void Init();
        
        public void Tick()
        {
            if(currentState != null)
            {
                currentState.Tick(this);
            }

            forceExit = false;
        }
    }
}