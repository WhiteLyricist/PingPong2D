using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public void Exit()
    {
        Application.Quit();
    }

    public void LoadScene() 
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void SetColor(string colorBall) 
    {
        ColorBall.GameBallColor=colorBall ;
    }

}
