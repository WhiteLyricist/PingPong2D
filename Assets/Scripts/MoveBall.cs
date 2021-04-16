using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveBall : MonoBehaviour
{

    public static Action<string> OnScore = delegate { };

    private float deltaX;
    private float deltaY;

    private float startSpeed;

    private float speed;
    private const float maxSpeed = 5f;
    private const float minSpeed = 2.5f;

    private const float minScale = 0.5f;
    private const float maxScale = 1.1f;

    private const float direction = 1.0f;

    private Vector3 InitialVector;

    private void Start()
    {
        speed = UnityEngine.Random.Range(minSpeed, maxSpeed);
        var scale = UnityEngine.Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(scale, scale, scale);
        Color colorBall;
        ColorUtility.TryParseHtmlString(ColorBall.GameBallColor, out colorBall);
        GetComponent<SpriteRenderer>().color = colorBall;
        startSpeed = speed;
        deltaX = UnityEngine.Random.Range(-direction, direction);
        deltaY = UnityEngine.Random.Range(-direction, direction);
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
            speed+=0.25f;;
            return;
        }

        if (collision.gameObject.tag == "TopWall") 
        {
            OnScore("Top");
            speed = startSpeed;
            transform.position = new Vector3(0, 0, -1f);
            deltaX = UnityEngine.Random.Range(-direction, direction);
            deltaY = UnityEngine.Random.Range(-direction, direction);
        }

        if (collision.gameObject.tag == "BotWall") 
        {
            OnScore("Bot");
            speed = startSpeed;
            transform.position = new Vector3(0, 0, -1f);
            deltaX = UnityEngine.Random.Range(-direction, direction);
            deltaY = UnityEngine.Random.Range(-direction, direction);
        }

    }
}
