using UnityEngine;

namespace GameEvents
{
    public class PlayMusicEvent : IGameEvent
    {
        private string audioClipName;
        private bool loop;

        public PlayMusicEvent(string audioClipName, bool loop = true)
        {
            this.audioClipName = audioClipName;
            this.loop = loop;
        }

        public string getAudioClipName()
        {
            return audioClipName;
        }

        public bool doesLoop()
        {
            return loop;
        }
    }
}