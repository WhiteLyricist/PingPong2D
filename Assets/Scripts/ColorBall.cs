using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorBall : MonoBehaviour
{
    private static string colorGameBall = "White";
    public static string ColoraGameBall
    { get => colorGameBall; }

    public static void SetColorBall(string color) 
    {
        colorGameBall = color;
    }

}
