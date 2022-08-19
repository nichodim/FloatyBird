using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGeneration : MonoBehaviour
{
    public GameObject[] objects;
    public Vector3 SPLocationObs;
    int i; 
    void Start()
    {
        i = 100; 
    }

    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == true)
        {
            i++;
            if ((i % 100) == 0)
            {
                int rand = Random.Range(0, objects.Length);
                SPLocationObs = new Vector3(18, Random.Range(-5, 5), 0);
                Instantiate(objects[rand], SPLocationObs, Quaternion.identity);
            }
        }
    }

} 