using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectablePrefab;
    public float spawnInterval = 5f;
    public float xMin = -10f;
    public float xMax = 10f;
    public float yMin = -10f;
    public float yMax = 10f;

    void Start()
    {
        InvokeRepeating("SpawnCollectable", 0f, spawnInterval);
    }

    void SpawnCollectable()
    {
        Vector2 spawnPos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(collectablePrefab, spawnPos, Quaternion.identity);
    }
}

