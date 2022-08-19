using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI ScoreText; 
    void Update()
    {
        ScoreText.text = (FindObjectOfType<GameManager>().score.ToString()); 
    }
}
