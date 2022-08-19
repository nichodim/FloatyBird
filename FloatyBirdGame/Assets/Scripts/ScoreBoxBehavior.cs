using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoxBehavior : MonoBehaviour
{
    public int score;

    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            transform.Translate(0 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        if (transform.position.x <= -16)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            FindObjectOfType<GameManager>().score++;
            FindObjectOfType<AudioManager>().Play("PointSound");
        }
    }
}
