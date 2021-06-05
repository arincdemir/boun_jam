using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public float waitUntilMainMenu;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoToMainMenu", waitUntilMainMenu);
    }

    void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
