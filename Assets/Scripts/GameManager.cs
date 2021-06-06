using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Image advisorImage;
    public Text encounterText;
    public Text acceptText;
    public Text declineText;
    public PlayerDatas playerDatas;
    public Text paraTexti;
    public Text çıkarTexti;
    public Text korkuTexti;
    public Text askerTexti;
    public float newEncounterDelay = 1;


    public Encounter[] encounters;
    Encounter currentEncounter;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("PlayType") == "Devam")
        {
            playerDatas = SaveLoadTool.Load();
        }
        PlayerPrefs.SetInt("LastScore", 0);
        LoadNewEncounter();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateIndicators();
        if(playerDatas.para <= 0) { SceneManager.LoadScene("ParaEnd"); }
        else if (playerDatas.çıkar <= 0) { SceneManager.LoadScene("ÇıkarEnd"); }
        else if (playerDatas.korku <= 0) { SceneManager.LoadScene("KorkuEnd"); }
        else if (playerDatas.asker <= 0) { SceneManager.LoadScene("AskerEnd"); }

        SaveLoadTool.Save(playerDatas);
    }

    void UpdateIndicators()
    {
        paraTexti.text = "PARA" + "\n" + playerDatas.para;
        çıkarTexti.text = "ÇKAR" + "\n" + playerDatas.çıkar;
        korkuTexti.text = "KORKU" + "\n" + playerDatas.korku;
        askerTexti.text = "ASKER" + "\n" + playerDatas.asker;
    }

    void LoadNewEncounter()
    {
        PlayerPrefs.SetInt("LastScore", PlayerPrefs.GetInt("LastScore") + 1);
        int encounterIndex = Mathf.RoundToInt(Random.Range(-0.5f, encounters.Length - 0.5f));
        currentEncounter = encounters[encounterIndex];
        advisorImage.sprite = currentEncounter.image;
        encounterText.text = currentEncounter.advisorName+ " \n"+ currentEncounter.text;
        acceptText.text = currentEncounter.acceptText;
        declineText.text = currentEncounter.declineText;
    }

    public void ProposalAccepted()
    {
        playerDatas.para += currentEncounter.para;
        playerDatas.çıkar += currentEncounter.çıkar;
        playerDatas.korku += currentEncounter.korku;
        playerDatas.asker += currentEncounter.asker;

        Invoke("LoadNewEncounter", newEncounterDelay);
    }

    public void ProposalDeclined()
    {
        playerDatas.para -= currentEncounter.para;
        playerDatas.çıkar -= currentEncounter.çıkar;
        playerDatas.korku -= currentEncounter.korku;
        playerDatas.asker -= currentEncounter.asker;

        Invoke("LoadNewEncounter", newEncounterDelay);
    }

}
