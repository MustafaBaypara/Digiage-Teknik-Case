using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwerve : MonoBehaviour
{
    [SerializeField] private float _swerveSpeed = 0.5f;
    [SerializeField] private float _maxSwerveAmount = 1f;
    private float _lastFingerPosX;
    private float _moveFactorX;
    private void Update()
    {
        float swerveAmount = Time.deltaTime * _swerveSpeed * _moveFactorX;
        swerveAmount = Mathf.Clamp(value: swerveAmount, min: -_maxSwerveAmount, max: _maxSwerveAmount);
        transform.Translate(swerveAmount, 0, 0);
        SwerveSystem();
    }
    private void SwerveSystem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            _moveFactorX = Input.mousePosition.x - _lastFingerPosX;
            _lastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactorX = 0f;
        }
    }
}
