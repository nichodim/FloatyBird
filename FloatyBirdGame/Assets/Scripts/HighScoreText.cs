using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText1;
    void Start()
    {
        HighScoreText1.text = "High  score";
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == true)
        {
            HighScoreText1.text = "  ";
        }
    }
}
