using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    public TextMeshProUGUI SomeText;
    void Start()
    {
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (1 == 1)
        {
            SomeText.enabled = true;
            yield return new WaitForSecondsRealtime(1);
            SomeText.enabled = false;
            yield return new WaitForSecondsRealtime(1);
        }
    }
}
