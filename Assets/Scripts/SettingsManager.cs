using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public GameObject musicSlider;
    public GameObject soundSlider;
    private Slider musicSliderSlider;
    private Slider soundSliderSlider;
    // Start is called before the first frame update
    void Start()
    {
        musicSliderSlider = musicSlider.GetComponent<Slider>();
        soundSliderSlider = soundSlider.GetComponent<Slider>();
        musicSliderSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        soundSliderSlider.value = PlayerPrefs.GetFloat("SoundVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMusicVolume()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicSliderSlider.value);
    }

    public void UpdateSoundVolume()
    {
        PlayerPrefs.SetFloat("SoundVolume", soundSliderSlider.value);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
