﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreenManager : MonoBehaviour
{
    public PlayerDatas playerDatas;
    public Text currentscoreText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
