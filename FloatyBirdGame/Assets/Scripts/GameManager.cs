using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public bool gameHasStarted = false; 
    public int score;
    public float restartDelay = 1f;

    void Start()
    {
        score = 0;
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<AudioManager>().Play("DeathSound");
        }
    }

    void Update()
    {
        if (gameHasStarted == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                gameHasStarted = true; 
            }
        }

        if (gameHasEnded == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                Restart();
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
