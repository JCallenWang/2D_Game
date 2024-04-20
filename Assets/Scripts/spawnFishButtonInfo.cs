using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFishButtonInfo : MonoBehaviour
{
    // public field
    public fishType type;
    public GameObject fishPrefab;

    public enum fishType
    {
        typeA,
        typeB,
        typeC,
        typeD,
        typeE,
        typeF,
    };

}
