using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
        if (transform.position.x <= -16)
        {
            Destroy(gameObject);
        }
    }
}
