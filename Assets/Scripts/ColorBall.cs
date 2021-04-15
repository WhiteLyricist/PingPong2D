using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorBall : MonoBehaviour
{
    private static string colorGameBall;

    public static string ColoraGameBall
    { get => colorGameBall; }
    
    public static void ChangeColor()
    {
        colorGameBall = PlayerPrefs.GetString("Color","White");
    }

    public static void SetColorBall(string color) 
    {
        colorGameBall = color;
        PlayerPrefs.SetString("Color", color);
        PlayerPrefs.Save();
    }
}