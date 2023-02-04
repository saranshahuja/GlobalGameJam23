using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject waspEnemy;
    public float spawnArea1X = 5f;
    public float spawnArea1Y = 5f;

    public GameObject spiderEnemy;
    public float spawnArea2X = 10f;
    public float spawnArea2Y = 10f;

    public GameObject BeetleEnemy;
    public float spawnArea3X = 15f;
    public float spawnArea3Y = 15f;

    public float spawnRate = 1f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    void Spawn()
    {
        float x1 = Random.Range(-spawnArea1X, spawnArea1X);
        float y1 = Random.Range(-spawnArea1Y, spawnArea1Y);
        Vector3 spawnPos1 = new Vector3(x1, y1, 0);
        Instantiate(waspEnemy, spawnPos1, Quaternion.identity);

        float x2 = Random.Range(-spawnArea2X, spawnArea2X);
        float y2 = Random.Range(-spawnArea2Y, spawnArea2Y);
        Vector3 spawnPos2 = new Vector3(x2, y2, 0);
        Instantiate(spiderEnemy, spawnPos2, Quaternion.identity);

        float x3 = Random.Range(-spawnArea3X, spawnArea3X);
        float y3 = Random.Range(-spawnArea3Y, spawnArea3Y);
        Vector3 spawnPos3 = new Vector3(x3, y3, 0);
        Instantiate(BeetleEnemy, spawnPos3, Quaternion.identity);
    }
}
//In your main game script, use the InvokeRepeating method to call a function that will spawn the enemies at random positions.
//In the spawning function, use the Instantiate method to instantiate each type of enemy prefab at a random position within a specified area for each type of enemy
//This code should be placed in a script attached to an empty GameObject in your scene.
