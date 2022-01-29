using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public void OnClickGameStart()
    {
        Debug.Log("게임 시작");
        SceneManager.LoadScene(0);
    }

    public void OnClickManual()
    {
        Debug.Log("게임 매뉴얼");
        SceneManager.LoadScene(2);
    }

   public void OnClickManual_Instruction()
    {
        Debug.Log("게임 매뉴얼2");
        SceneManager.LoadScene(3);
    }

    public void OnClickManual_Out()
    {
        Debug.Log("메인");
        SceneManager.LoadScene(1);
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else

#endif
        Debug.Log("종료");
    }

}
