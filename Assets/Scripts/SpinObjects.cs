using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjects : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 45f * Time.deltaTime, 0f, Space.Self);
    }
}
