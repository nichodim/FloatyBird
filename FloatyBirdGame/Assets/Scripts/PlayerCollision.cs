using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playermovement;
    public Animator animator;
    void Start()
    {
        animator.SetBool("isDead", false);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            playermovement.enabled = false;
            animator.SetBool("isDead", true);
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
