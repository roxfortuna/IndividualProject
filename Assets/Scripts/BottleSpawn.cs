using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawn : MonoBehaviour
{
    public GameObject pickup;

    public float spawnTime = .5f;
    public float fallSpeed = 100.0f;

    private float timer = 0;
    private int randomNumber;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>spawnTime)
        { SpawnRandom();
            timer = 0;
        }
    }
    void SpawnRandom()
    { Vector2 screenPosition = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));

    Instantiate(pickup, screenPosition, Quaternion.identity);
    }
}
