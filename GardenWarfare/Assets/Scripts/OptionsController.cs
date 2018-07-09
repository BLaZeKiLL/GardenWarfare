using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour 
{

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager leveManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () 
	{
        // if run through SplashScreen
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasTerVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () 
	{
        musicManager.ChangeVolume(volumeSlider.value);
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        leveManager.LoadLevel("Start");
    }

    public void SetDeafult()
    {
        volumeSlider.value = 0.8f;
        difficultySlider.value = 2.0f;
    }
}
