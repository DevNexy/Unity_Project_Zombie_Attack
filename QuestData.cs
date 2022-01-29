using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestData : MonoBehaviour
{
    public GameObject QuestMenu;
    public GameObject QuestEnd;

    public Text Quest_1;
    public Text Quest_2;
    public int enemyNum;
    public int foodNum;
    private float timer;

    // Start is called before the first frame update
    public void Start()
    {
        randNum();
        timer = 0.0f;
        BulletScript.attackNum = 0;
        Item_Pick.count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2.0f && timer <= 5.0f)
        {
            questStart();
        }
        else
            QuestMenu.SetActive(false);

        if (BulletScript.attackNum >= enemyNum && Item_Pick.count >= foodNum)
        {
            questEnd();
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            QuestEnd.SetActive(false);
        }
    }
    void randNum()
    {
        enemyNum = Random.Range(15, 30);
        foodNum = Random.Range(1, 15);
    }
    void questStart()
    {

        QuestMenu.SetActive(true);

        Quest_1.text = "좀비 " + enemyNum.ToString() + "마리를 죽여라.";
        Quest_2.text = "음식 " + foodNum.ToString() + "개를 먹어라.";
    }
    void questEnd()
    {
        QuestEnd.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}