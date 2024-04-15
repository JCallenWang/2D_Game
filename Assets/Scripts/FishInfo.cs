using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishInfo : MonoBehaviour
{
    public string fishName;
    public enum fishType
    {
        typeA,
        typeB,
        typeC,
    };

    public fishType type;


    private void Update()
    {
        Vector3 newTarget;
    }
}
