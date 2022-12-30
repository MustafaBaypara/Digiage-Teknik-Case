using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _startUI;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerMove.Instance.isMoving = true;
            _startUI.SetActive(false);
            this.enabled = false;
        }   
    }   
}
