using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float countdownTime = 10.0f;
    
    public GameObject[] gameObjectsToDisable;
    public MonoBehaviour[] scriptsToDisable;

    void Start()
    {
        // Disable game objects and scripts at the start of the game
        foreach (GameObject gameObject in gameObjectsToDisable)
        {
            gameObject.SetActive(false);
        }

        foreach (MonoBehaviour script in scriptsToDisable)
        {
            script.enabled = false;
        }

        // Start countdown timer coroutine
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (countdownTime > 0)
        {
            // Decrease countdown time by Time.deltaTime each frame
            countdownTime -= Time.deltaTime;

           

            // Wait for 1 second before continuing the countdown
            yield return new WaitForSeconds(1);
        }

        // Enable game objects and scripts when countdown is complete
        foreach (GameObject gameObject in gameObjectsToDisable)
        {
            gameObject.SetActive(true);
        }

        foreach (MonoBehaviour script in scriptsToDisable)
        {
            script.enabled = true;
        }
    }

}

