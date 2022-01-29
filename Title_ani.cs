using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_ani : MonoBehaviour
{
   /* // Start is called before the first frame update
    public float timer;
    public GameObject title;
    public GameObject UP_onColl; public GameObject Down_onColl;

    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {
        timer += Time.deltaTime;
        title = GameObject.FindWithTag("Zombie_Attack");

        if (timer >= 0.5f)
        {
            transform.position += Vector3.up * (7 * Time.deltaTime);
            Debug.Log("UP");

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("UP_onColl"))
        {
            transform.position += Vector3.down * 7;
            Debug.Log("Down ");
        }

        if (other.gameObject.tag.Equals("Down_onColl"))
        {
            transform.position = new Vector3(10.9f, 111.9f, 0);
        }
    }
    */
}
