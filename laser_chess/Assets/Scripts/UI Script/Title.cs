using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public string sceneName = "Game Stage";
    // Start is called before the first frame update
    public void ClickStart()
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene(sceneName);
    }

    public void ClickLoad()
    {
        Debug.Log("�ε�");
    }
    public void ClickExit()
    {
        Debug.Log("���� ����");
        Application.Quit();
    }
}
