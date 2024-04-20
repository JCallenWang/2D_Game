using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public RectTransform spawnFishArea;
    public RectTransform mainGameArea;

    public Button[] spawnFishButton;
    public GameObject[] fishPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        // Bind Function to Button
        foreach(Button b in spawnFishButton)
        {
            if(b.GetComponent<spawnFishButtonInfo>() != null)
            {
                var type = b.GetComponent<spawnFishButtonInfo>().type;
                var gameObject = b.GetComponent<spawnFishButtonInfo>().fishPrefab;
                b.onClick.AddListener(delegate { SpawnFish(gameObject, type); });
            }
            else
            {
                Debug.LogWarning($"the child object{b.name} of {b.transform.parent.name} has no component of spawnFishButtonInfo");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnFish(GameObject gObject, spawnFishButtonInfo.fishType Ftype)
    {
        Instantiate(gObject, Vector3.zero, Quaternion.identity);
        Debug.Log($"Fish:{Ftype} has been spawned");
    }
}
