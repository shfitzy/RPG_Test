using GameEvents;
using UnityEngine;

public class DebugBattleTransition : MonoBehaviour
{
    [SerializeField]
    private CreatureData[] playerUnits;

    [SerializeField]
    private CreatureData[] enemyUnits;
    
    public void StartBattle(string sceneName)
    {
        GameEventManager.PostEvent(new InitBattleStateEvent(playerUnits, enemyUnits));
        GameEventManager.PostEvent(new SceneChangeEvent(sceneName));
    }
}
