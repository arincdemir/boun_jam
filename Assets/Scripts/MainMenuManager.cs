using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Text highScoreText;
    public Text lastScoreText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HighScore", Mathf.Max(PlayerPrefs.GetInt("HighScore"), PlayerPrefs.GetInt("LastScore")));
        highScoreText.text = highScoreText.text + " " +PlayerPrefs.GetInt("HighScore");
        lastScoreText.text = lastScoreText.text + " " + PlayerPrefs.GetInt("LastScore");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
 
    public void NewGame()
    {
        PlayerPrefs.SetString("PlayType", "Yeni");
        SceneManager.LoadScene("Game");
    }

    public void ContinueGame()
    {
        PlayerPrefs.SetString("PlayType", "Devam");
        SceneManager.LoadScene("Game");
    }
}
