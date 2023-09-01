using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject foodPrefab;
    public Vector2 xRange;
    public Vector2 yRange;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < 50; i++) 
        {
            SpawnFood();
        }
    }

    public void SpawnFood()
    {
        Vector3 spawnPosition = new Vector3(x: Random.Range(xRange.x, xRange.y), y: Random.Range(yRange.x, yRange.y), z: 1);
        GameObject _food = Instantiate(foodPrefab, spawnPosition, Quaternion.identity);
        _food.GetComponent<SpriteRenderer>().color = Random.ColorHSV(hueMin: 0f, hueMax: 1f, saturationMin: 0.9f, saturationMax: 1f, valueMin: 0.9f, valueMax: 1f);
    }
}
