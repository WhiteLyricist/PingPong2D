using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    private int scoreBot = 0;
    private int scoreTop = 0;

    // Start is called before the first frame update
    void Start()
    {
        MoveBall.OnScore += Score;
    }

    void Score(string side) 
    {
        if (side == "Bot") 
        {
            scoreBot += 1;
        }

        if (side == "Top") 
        {
            scoreTop += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        MoveBall.OnScore -= Score;
    }

}
