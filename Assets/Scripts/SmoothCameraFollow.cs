using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private float _smoothSpeed = 0.125f;
    private void FixedUpdate()
    {
        Vector3 desiredPosition = _target.position + _cameraOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed * Time.deltaTime);
    }
}
