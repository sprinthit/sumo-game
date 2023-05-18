using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float moveSpeed = 0.7f;
    public float moveDelay = 0.5f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            if (!PauseMenu.isPaused&&!CountDown.isPaused)
            {
                rb.position += Vector2.up * -moveSpeed * Time.deltaTime;
            }
            yield return new WaitForSeconds(moveDelay);
        }
    }

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }
}
