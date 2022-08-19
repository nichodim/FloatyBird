using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI GameOverText;
    void Start()
    {
        GameOverText.text = "  "; 
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            GameOverText.text = "Press  r  to  restart";
        }
    }
}
