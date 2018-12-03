using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public void OnStartButton()
    {
        Application.LoadLevel("GameScene1");
    }
    public void OnChartsButton()
    {
        Application.LoadLevel("ChartsScene");
    }
    public void OnQuitButton()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
