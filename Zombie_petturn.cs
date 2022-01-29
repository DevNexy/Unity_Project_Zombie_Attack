using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_petturn : MonoBehaviour
{
    public GameObject image_0;
    public GameObject image_1;
    public float timer;



    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0)
        {
            image_1.SetActive(true);
            image_0.SetActive(false);
        }
    }
}
