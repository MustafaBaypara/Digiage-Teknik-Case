using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GateManager : MonoBehaviour
{
    [SerializeField] private TextMeshPro _gateNo;
    [SerializeField] private int _randomNumber;
    [SerializeField] bool _multiply;
    void Start()
    {
        if (_multiply)
        {
            _randomNumber = Random.Range(1, 3);
            _gateNo.text = "X" + _randomNumber;
        }
        else
        {
            _randomNumber = Random.Range(10, 100);
            if (_randomNumber % 2 != 0)
                _randomNumber += 1;
            _gateNo.text = _randomNumber.ToString();
        }
    }
}
