using GameEvents;
using System.Collections.Generic;
using UnityEngine;

namespace Sound
{
    public class SoundManager : MonoBehaviour, IGameEventListener
    {
        public static SoundManager instance;

        public AudioSource musicSource;

        [SerializeField]
        private AudioClip[] musicClips;
        private Dictionary<string, AudioClip> musicClipDictionary = new Dictionary<string, AudioClip>();

        void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(this.gameObject);

            InitDictionaries();
            GameEventManager.RegisterListener(this);
        }

        void OnDestroy()
        {
            GameEventManager.UnregisterListener(this);
        }

        private void InitDictionaries()
        {
            foreach (AudioClip musicClip in musicClips) {
                musicClipDictionary.Add(musicClip.name, musicClip);
            }
        }

        public void eventReceived(IGameEvent e)
        {
            if (e is PlayMusicEvent)
            {
                PlayMusicEvent musicEvent = e as PlayMusicEvent;
                AudioClip audioClip = null;
                musicClipDictionary.TryGetValue(musicEvent.getAudioClipName(), out audioClip);

                if (audioClip != null)
                {
                    PlayMusic(audioClip, musicEvent.doesLoop());
                }
            }
        }

        public void PlayMusic(AudioClip audioClip, bool loop)
        {
            musicSource.clip = audioClip;
            musicSource.loop = loop;

            musicSource.Play();
        }
    }
}