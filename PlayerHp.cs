using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHp : MonoBehaviour
{
    public static float Hp = 100.0f;
    public Slider HpBar;
    public Image bloodScreen;
    public float timer;
    void Start()
    {
        bloodScreen.enabled = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        HpBar.value = (float) Hp / (float) 100.0f;
        
        Debug.Log(timer);

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            timer = 0.0f;
            if (timer == 0.0)
            {
                bloodScreen.enabled = true;
                Debug.Log(timer);
            }

            Hp -= 10.0f; 
            Debug.Log("Attack");
        }
        else
            bloodScreen.enabled = false;
        if(other.gameObject.tag == "HealingZone")
        {
            Hp = 100.0f;
            Debug.Log("Healing");
        }
    }
    public void GameExit()
    {
        Application.Quit();
    }


}
