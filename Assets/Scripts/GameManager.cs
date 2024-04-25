using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // area
    public RectTransform spawnFishArea;
    public RectTransform mainGameArea;

    // currency
    public GameObject coinPanel;
    public TMP_Text coinTextBox;
    public Button[] spawnFishButton;


    // private field
    private int currCoin = 100;

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

        // coin init
        coinTextBox.text = currCoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnFish(GameObject gObject, spawnFishButtonInfo.fishType Ftype)
    {
        if (currCoin - gObject.GetComponent<FishInfo>().price >= 0)
        {
            currCoin -= gObject.GetComponent<FishInfo>().price;
            Instantiate(gObject, Vector3.zero, Quaternion.identity);
            Debug.Log($"Fish:{Ftype} has been spawned");

            coinTextBox.text = currCoin.ToString();
        }
        else
        {
            // implement price not enough behaviour
            StartCoroutine(TransitionColor(coinPanel.GetComponent<Image>().color, Color.green, 0.5f));
            Debug.Log($"current coin: {currCoin} is not enough for {gObject.GetComponent<FishInfo>().price}!");
        }

    }

    private IEnumerator TransitionColor(Color startColor, Color endColor, float duration)
    {
        float t = 0f;

        while (t < 1)
        {
            Debug.Log($"Time.deltaTime/duration: {Time.deltaTime / duration}/ t: {t}"); // run once on current frame, then run multiple times on next frames 
            t += Time.deltaTime / duration;
            coinPanel.GetComponent<Image>().color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }
    }
}
