using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushMinus : MonoBehaviour
{
    public float moveSpeed = 20f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveUp()
    {
        if (!PauseMenu.isPaused && !CountDown.isPaused)
        {
            Vector2 newPosition = rb.position + Vector2.up * -moveSpeed * Time.deltaTime;
            rb.MovePosition(newPosition);
        }
    }
}
