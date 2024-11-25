using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RotatingObstacleMoveScript : MonoBehaviour
{
   [SerializeField] private Vector3 _directionsOfRotation;
    private void Update()
    {
        transform.Rotate(_directionsOfRotation * Time.deltaTime, Space.Self);
    }
}
