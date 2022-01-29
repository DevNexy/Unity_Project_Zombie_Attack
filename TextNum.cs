using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextNum : MonoBehaviour
{
    public Text KillNum;
    public Text FoodNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FoodNum.text = Item_Pick.count.ToString();
        KillNum.text = BulletScript.attackNum.ToString();
    }
}
