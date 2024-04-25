using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishInfo : MonoBehaviour
{
    // handle fish's behaviour

    // private field
    private GameManager gameManager;
    public int price;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        // Randomly spawn fish in spawnFishArea
        Vector3 minXY = Camera.main.ScreenToWorldPoint(new Vector3(0, gameManager.mainGameArea.rect.height, 0));

        float maxWidth = Camera.main.ScreenToWorldPoint(new Vector3(gameManager.spawnFishArea.rect.width, gameManager.spawnFishArea.rect.height, 0)).x;
        float maxHeight = Camera.main.ScreenToWorldPoint(new Vector3(0, gameManager.spawnFishArea.rect.height + gameManager.mainGameArea.rect.height, 0)).y;

        Debug.Log($"mixXY: {minXY}");
        Debug.Log($"mixXY: {maxHeight}");

        float x = Random.Range(minXY.x, maxWidth);
        float y = Random.Range(minXY.y, maxHeight);
        Vector2 spot = new Vector2(x, y);
        this.gameObject.transform.position = spot;


    }

    private void Update()
    {


    }

}
