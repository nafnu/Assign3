using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("background");
    }

    public void OnButton()
    {
        Debug.Log("Button was pressed");
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Button PLAY was pressed");
    }

    public void OnEXITButton()
    {
        Application.Quit();
        Debug.Log("Button EXIT was pressed");
    }
}

