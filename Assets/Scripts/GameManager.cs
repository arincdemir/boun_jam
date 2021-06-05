using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Image advisorImage;
    public Text encounterText;
    public PlayerDatas playerDatas;
    public Text paraTexti;
    public Text çıkarTexti;
    public Text korkuTexti;
    public Text askerTexti;
    public Text gunTexti;

    public Encounter[] encounters;
    Encounter currentEncounter;

    // Start is called before the first frame update
    void Start()
    {
        LoadNewEncounter();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateIndicators();
        if(playerDatas.para <= 0 || playerDatas.korku <= 0 || playerDatas.çıkar <= 0 || playerDatas.asker <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void UpdateIndicators()
    {
        paraTexti.text = "PARA" + "\n" + playerDatas.para;
        çıkarTexti.text = "ÇIKAR" + "\n" + playerDatas.çıkar;
        korkuTexti.text = "KORKU" + "\n" + playerDatas.korku;
        askerTexti.text = "ASKER" + "\n" + playerDatas.asker;
        gunTexti.text = "GÜN" + "\n" + playerDatas.day;
    }

    void LoadNewEncounter()
    {
        int encounterIndex = Mathf.RoundToInt(Random.Range(-0.5f, encounters.Length - 0.5f));
        currentEncounter = encounters[encounterIndex];
        advisorImage.sprite = currentEncounter.image;
        encounterText.text = currentEncounter.text;
    }

    public void ProposalAccepted()
    {
        playerDatas.para += currentEncounter.para;
        playerDatas.çıkar += currentEncounter.çıkar;
        playerDatas.korku += currentEncounter.korku;
        playerDatas.asker += currentEncounter.asker;

        playerDatas.day += 1;

        Save();
        LoadNewEncounter();
    }

    public void ProposalDeclined()
    {
        playerDatas.para -= currentEncounter.para;
        playerDatas.çıkar -= currentEncounter.çıkar;
        playerDatas.korku -= currentEncounter.korku;
        playerDatas.asker -= currentEncounter.asker;

        playerDatas.day += 1;

        Save();
        LoadNewEncounter();
    }

    void Save()
    {

    }

    private void Load()
    {
        
    }
}
