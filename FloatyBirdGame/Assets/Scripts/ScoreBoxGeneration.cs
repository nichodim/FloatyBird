using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoxGeneration : MonoBehaviour
{
    int i;
    public GameObject[] scoreBox;
    public Vector3 SPLocationSB; 
    void Start()
    {
        i = 100;
        SPLocationSB = new Vector3(18, 0, 0);
    }

    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == true)
        {
            i++;
            if ((i % 100) == 0)
            {
                Instantiate(scoreBox[0], SPLocationSB, Quaternion.identity);
            }
        }
    }
}
