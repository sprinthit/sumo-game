using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float moveSpeed = 20f;

    private void Update()
    {
        if(!PauseMenu.isPaused)
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

        }
    }
}
