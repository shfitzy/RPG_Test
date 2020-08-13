using GameEvents;
using UnityEngine;

public class DebugBattleTransition : MonoBehaviour
{
    [SerializeField]
    private Actor[] playerUnits;

    [SerializeField]
    private Actor[] enemyUnits;
    
    public void StartBattle(string sceneName)
    {
        GameEventManager.PostEvent(new InitBattleStateEvent(playerUnits, enemyUnits));
        GameEventManager.PostEvent(new SceneChangeEvent(sceneName));
    }
}
