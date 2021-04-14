using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorBall : MonoBehaviour
{
    private static string colorGameBall = "White";
    public static string ColoraGameBall
    { get => colorGameBall; }

    private void Start()
    {
        colorGameBall = PlayerPrefs.GetString("Color");
    }

    public static void SetColorBall(string color) 
    {
        colorGameBall = color;
        PlayerPrefs.SetString("Color", color);
        PlayerPrefs.Save();
    }

}
