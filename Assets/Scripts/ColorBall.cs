using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorBall : MonoBehaviour
{

    public static string GameBallColor
    { get => PlayerPrefs.GetString("GameBallColor", "White");
      set
      {
          PlayerPrefs.SetString("GameBallColor", value);
          PlayerPrefs.Save();
      }
    }
}