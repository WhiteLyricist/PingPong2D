using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeAdaptationGameObject : MonoBehaviour
{

    private float height = 1920;
    private float width = 1080;

    private float proportionH;
    private float proportionW;

    private void Awake()
    {
        if (width != Screen.width || height != Screen.height) 
        {
            if (width < Screen.width)
            {
                proportionW = Screen.width / width;
            }
            else
            {
                proportionW = width / Screen.width;
            }

            if (height < Screen.height)
            {
                proportionH = Screen.height / height;
            }
            else
            {
                proportionH = height / Screen.height;
            }
        }

        transform.localScale = new Vector3(transform.localScale.x * proportionW, transform.localScale.y * proportionH, transform.localScale.z);
    }

}
