using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petturn_ : MonoBehaviour
{
    public float timer;
    public GameObject petturn;
    public float speed = 70;
    // Start is called before the first frame update
    private void Start()
    {
    }
    void Update()
    {
        timer += Time.deltaTime;

        this.transform.position += Vector3.right * (speed * Time.deltaTime);
    }
}
