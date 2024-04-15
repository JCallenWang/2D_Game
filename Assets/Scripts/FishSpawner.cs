using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishs;


    // Start is called before the first frame update
    void Start()
    {
        FishInfo fishInfo = new FishInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFishButtonClicked(FishInfo.fishType type)
    {
        switch (type)
        {
            case FishInfo.fishType.typeA:
                {
                    Instantiate(fishs[0]);
                    return;
                }
            case FishInfo.fishType.typeB:
                {
                    
                    return;
                }
            case FishInfo.fishType.typeC:
                {
                    return;
                }
        }
    }
}
