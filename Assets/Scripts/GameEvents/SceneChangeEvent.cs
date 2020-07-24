namespace GameEvents
{
    public class SceneChangeEvent : IGameEvent
    {
        private readonly string sceneName;

        public SceneChangeEvent(string sceneName)
        {
            this.sceneName = sceneName;
        }

        public string getSceneName()
        {
            return sceneName;
        }
    }
}