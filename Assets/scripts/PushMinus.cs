using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushMinus : MonoBehaviour
{
    public float movespeed = 20f;

    public void MoveUp()
    { 
        if(!PauseMenu.isPaused)
        {
            transform.position += Vector3.up * -movespeed * Time.deltaTime;

        }
    }
}
