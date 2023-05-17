using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float moveSpeed = 0.7f;
    public float moveDelay = 0.5f; // Delay between each move in seconds

    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            if (!PauseMenu.isPaused)
            {
                transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
            }
            yield return new WaitForSeconds(moveDelay);
        }
    }

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }
}
