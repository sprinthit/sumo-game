using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float moveSpeed = 20f; 

    public void MoveUp()
    {
        if(!PauseMenu.isPaused&&!CountDown.isPaused)
        {
            print("timescle" + Time.timeScale);
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            

        }
    }
}
