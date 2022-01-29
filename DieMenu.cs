using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
    public GameObject dieMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHp.Hp == 0.0f)
        {

            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            dieMenu.SetActive(true);

        }
        else
        {
            Time.timeScale = 1f;
            /*Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;*/
            dieMenu.SetActive(false);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        PlayerHp.Hp = 100.0f;
        BulletScript.attackNum = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        dieMenu.SetActive(false);
    }
    public void GameExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else

#endif
        Debug.Log("종료");
    }
}
