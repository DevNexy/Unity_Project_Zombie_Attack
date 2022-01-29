using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pick : MonoBehaviour
{
    public static int count = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("플레이어와 닿았습니다.");
            Destroy(this.gameObject);
            count++;
            Debug.Log("아이템을 주웠습니다." + count);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
