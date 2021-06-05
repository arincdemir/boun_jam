using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public int settingsBuildIndex;
    public int gameBuildIndex;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HighScore", Mathf.Max(PlayerPrefs.GetInt("HighScore"), PlayerPrefs.GetInt("LastScore")));
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
        SceneManager.LoadScene("Game");
    }
}
