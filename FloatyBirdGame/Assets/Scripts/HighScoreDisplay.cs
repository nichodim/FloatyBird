using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText2;
    void Start()
    {
        HighScoreText2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == true)
        {
            HighScoreText2.text = "  ";
        }
        if (FindObjectOfType<GameManager>().score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", FindObjectOfType<GameManager>().score);
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore"); 
    }
}
