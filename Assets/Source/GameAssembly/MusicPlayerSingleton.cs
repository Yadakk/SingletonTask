using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonTask.GameAssembly
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicPlayerSingleton : MonoBehaviour
    {
        [SerializeField]
        private AudioClip musicClip;

        private AudioSource audioSource;

        public static MusicPlayerSingleton Instance { get; private set; }

        private void Awake()
        {
            CreateSingleton();
            Init();
        }

        private void CreateSingleton()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Init()
        {
            audioSource = GetComponent<AudioSource>();
            InvokeRepeating(nameof(Play), 0f, musicClip.length);
        }

        private void Play()
        {
            audioSource.clip = musicClip;
            audioSource.Play();
        }
    }
}
