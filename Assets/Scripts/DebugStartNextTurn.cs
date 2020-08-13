using GameEvents;
using UnityEngine;

public class DebugStartNextTurn : MonoBehaviour
{
    public void StartNextTurn()
    {
        GameEventManager.PostEvent(new StartNextActorTurnEvent());
    }
}
