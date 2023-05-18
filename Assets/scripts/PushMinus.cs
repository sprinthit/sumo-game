using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushMinus : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveUp()
    {
        if (!PauseMenu.isPaused && !CountDown.isPaused)
        {
            rb.position += Vector2.up * -moveSpeed * Time.deltaTime;
        }
    }
}
