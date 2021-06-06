using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewEncounter", menuName = "ScriptableObjects/Encounter")]
public class Encounter : ScriptableObject
{
    public Sprite image;
    public string advisorName;
    public string text;
    public int para;
    public int çıkar;
    public int korku;
    public int asker;
    public string acceptText;
    public string declineText;
}
