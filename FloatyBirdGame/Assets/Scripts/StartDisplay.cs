using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartDisplay : MonoBehaviour
{
    public TextMeshProUGUI StartText;
    void Start()
    {
        StartText.text = "Press  space  to  play";
    }
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasStarted == true)
        {
            StartText.text = "  ";
        }
    }
}
