using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] LevelMusicArray;

    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        // OnLevelWasLoaded() is deprecated using SceneManager Delegate instead
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
	}

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (LevelMusicArray[scene.buildIndex]) // if there is a music
        {
            if (!audioSource.clip || !audioSource.clip.Equals(LevelMusicArray[scene.buildIndex])) // if the music is diff 
            {
                audioSource.clip = LevelMusicArray[scene.buildIndex];
                audioSource.loop = true;
                audioSource.Play();
            }
        }
    }
}
