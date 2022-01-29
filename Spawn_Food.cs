using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Food : MonoBehaviour
{
    public bool foodSpawn = false;
    public GameObject[] food_prefab;
    public float timer;
    // Start is called before the first frame update
    void SpawnFood()
    {
        int foodIndex = Random.Range(0, food_prefab.Length);
        float randomX = Random.Range(-50.0f, 50.0f);
        float randomZ = Random.Range(-50.0f, 50.0f);
        transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        if (foodSpawn)
        {
            GameObject food = Instantiate(food_prefab[foodIndex], new Vector3(randomX, 1.1f, randomZ), transform.rotation);
        }

        Debug.Log("삭제");
    }

    void Start()
    {
        InvokeRepeating("SpawnFood", 5, 5);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
