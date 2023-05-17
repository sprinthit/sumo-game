using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerout : MonoBehaviour
{
    public GameObject textPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("P1"))
        {
            Time.timeScale = 0f;
            textPrefab.SetActive(true);
        }
    }
}
