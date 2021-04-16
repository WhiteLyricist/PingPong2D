using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAI : MonoBehaviour
{

    [SerializeField] private GameObject _ball;

    private float posBallX = 0f;
    private float posBallY = 0f;
    private float direction;

    Rigidbody2D physics;

    private void Awake()
    {
        physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_ball.transform.position.y > 0 && _ball.transform.position.y > posBallY) 
        {
            if (_ball.transform.position.x > posBallX)
            {
                direction = 3f;
            }
            else 
            {
                direction = -3f;
            }
            posBallX = _ball.transform.position.x;
            physics.velocity = new Vector2(direction, 0);
        }
        else 
        {
            physics.velocity = Vector2.zero;
        }
        posBallY = _ball.transform.position.y;
    }
}
