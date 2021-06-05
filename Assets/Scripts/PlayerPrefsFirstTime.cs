using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsFirstTime : MonoBehaviour
{
    public float defaultMusicVolume;
    public float defaultSoundVolume;
    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", defaultMusicVolume);
        }
        if (!PlayerPrefs.HasKey("SoundVolume"))
        {
            PlayerPrefs.SetFloat("SoundVolume", defaultSoundVolume);
        }
        if (!PlayerPrefs.HasKey("LastScore"))
        {
            PlayerPrefs.SetInt("LastScore", 0);
        }
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }

    }

    
}
