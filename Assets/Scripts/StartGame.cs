using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerMove.Instance.isMoving = true;
            this.enabled = false;
        }   
    }   
}
