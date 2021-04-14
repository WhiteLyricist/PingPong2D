using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveRacquets : MonoBehaviour
{

   /// [SerializeField] private GameObject _top;
    [SerializeField] private GameObject _bot;

    private Vector3 touch;
    private float touchX = 0f;

    private float direction;

    void FixedUpdate()
    {
        if(Input.touchCount > 0) 
        {
            Touch tab = Input.GetTouch(0);
            if (tab.phase == TouchPhase.Moved)
            {
                touch = tab.position;
                touch = Camera.main.ScreenToWorldPoint(touch);
                direction = 3f * Mathf.Abs(touch.x) / touch.x;
                if (touch.x > touchX)
                {
                    direction = 7f;
                }
                else 
                {
                    direction = -7f;
                }
                touchX = touch.x;
             //   _top.GetComponent<Rigidbody2D>().velocity = new Vector2(direction, 0);
                _bot.GetComponent<Rigidbody2D>().velocity = new Vector2(direction, 0);
            } 
            else
            {
            //    _top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                _bot.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }

        }
    }


}
