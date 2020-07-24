using GameEvents;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Smot
{
    public class GameManager : MonoBehaviour, IGameEventListener
    {
        public static GameManager instance;

        void Awake()
        {
            if(instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(this.gameObject);

            GameEventManager.RegisterListener(this);
        }

        void OnDestroy()
        {
            GameEventManager.UnregisterListener(this);
        }

        public void eventReceived(IGameEvent e)
        {
            if(e is SceneChangeEvent){
                ChangeScene(e as SceneChangeEvent);
            }
        }

        private void ChangeScene(SceneChangeEvent e)
        {
            SceneManager.LoadScene(e.getSceneName());
        }
    }
}