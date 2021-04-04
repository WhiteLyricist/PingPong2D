using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveBall : MonoBehaviour
{

    public static Action<string> OnScore = delegate { };

    private float deltaX;
    private float deltaY;

    private float speed;

    private Vector3 InitialVector;

    private void Awake()
    {
        deltaX = UnityEngine.Random.Range(-1.0f, 1.0f);
        deltaY = UnityEngine.Random.Range(-1.0f, 1.0f);
        speed = 3.0f;

    }

    void Update()
    {
           InitialVector = new Vector3(transform.position.x + deltaX * speed * Time.deltaTime / Mathf.Abs(deltaX), transform.position.y + deltaY * speed * Time.deltaTime / Mathf.Abs(deltaY), -1f);
           transform.position = InitialVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            deltaX = -deltaX;
            return;
        }

        if (collision.gameObject.tag == "Racquet") 
        {
            deltaY = -deltaY;
            return;
        }

        if (collision.gameObject.tag == "TopWall") 
        {
            OnScore("Top");
            transform.position = new Vector3(0, 0, -1f);
            deltaX = UnityEngine.Random.Range(-1.0f, 1.0f);
            deltaY = UnityEngine.Random.Range(-1.0f, 1.0f);
        }

        if (collision.gameObject.tag == "BotWall") 
        {
            OnScore("Bot");
            transform.position = new Vector3(0, 0, -1f);
            deltaX = UnityEngine.Random.Range(-1.0f, 1.0f);
            deltaY = UnityEngine.Random.Range(-1.0f, 1.0f);
        }

    }

}
