using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyout : MonoBehaviour
{
    public GameObject textPrefab;
    public GameObject AitextPrefab;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("P2"))
        {
            Time.timeScale = 0f;
            textPrefab.SetActive(true);
        }
        if(collision.gameObject.CompareTag("Ai"))
        {
            Time.timeScale = 0f;
            AitextPrefab.SetActive(true);
        }
    }
}
