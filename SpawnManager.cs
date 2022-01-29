using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public bool enableSpawn = false;
    public GameObject enemy_prefab;
    // Start is called before the first frame update
    void SpawnEnemy()
    {
        float randomX = Random.Range(-50.0f, 50.0f);
        float randomZ = Random.Range(-50.0f, 50.0f);
        transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        if (enableSpawn)
        {
            GameObject enemy = Instantiate(enemy_prefab, new Vector3(randomX, 1.1f, randomZ), transform.rotation);

        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5, 5);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
