using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("Player Spawning")]

    public GameObject player;
    public GameObject cam;

    [Header("Food settings")]
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

    public void SpawnPlayer()
    {
        Vector3 spawnPosition = new Vector3(x: Random.Range(xRange.x, xRange.y), y: Random.Range(yRange.x, yRange.y), z: 1);
        GameObject _Player = PhotonNetwork.Instantiate(player.name, spawnPosition, Quaternion.identity);

        cam.SetActive(true);

        cam.GetComponent<CameraFollow>().target = _Player.transform;

       // _Player.GetComponent<SizeManager>().enabled = true;
       // _Player.GetComponent<Movemnet>().enabled = true;
    }
}
