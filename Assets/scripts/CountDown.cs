using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    
    public Text countdownDisplay;
    public static bool isPaused = true;

    private void Start()
    {
        StartCoroutine(countdownToStart());
    }

    IEnumerator countdownToStart()
    {
        countdownDisplay.text = "3";
        yield return new WaitForSeconds(1);
       
        countdownDisplay.text = "2";
        yield return new WaitForSeconds(1);
        
        countdownDisplay.text = "1";
        yield return new WaitForSeconds(1);
        
        countdownDisplay.text = "GO";
        yield return new WaitForSeconds(1);

        countdownDisplay.gameObject.SetActive(false);
        isPaused = false;

    }

}
