using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image advisorImage;
    public Text encounterText;
    public PlayerDatas playerDatas;

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
        
    }

    void LoadNewEncounter()
    {
        // I subtracted 0.5 in order to make all posibilities the same.
        int encounterIndex = Mathf.RoundToInt(Random.Range(0, encounters.Length) - 0.5f);
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

        Save();
        LoadNewEncounter();
    }

    public void ProposalDeclined()
    {
        playerDatas.para -= currentEncounter.para;
        playerDatas.çıkar -= currentEncounter.çıkar;
        playerDatas.korku -= currentEncounter.korku;
        playerDatas.asker -= currentEncounter.asker;

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
