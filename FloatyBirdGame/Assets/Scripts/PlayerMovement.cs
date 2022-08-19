using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator; 
    public float Thrust;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == false)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        animator.SetBool("Spacebar", false);
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * Thrust);
            animator.SetBool("Spacebar", true);
            if (FindObjectOfType<AudioManager>().isPlaying == false)
            {
                FindObjectOfType<AudioManager>().Play("FlySound");
            }
        }
        if (rb.position.y < -8f)
        {
            FindObjectOfType<GameManager>().GameOver(); 
        }
        
    }
}
