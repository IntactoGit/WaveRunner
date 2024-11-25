using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class VerticalObstacleMoveScript : MonoBehaviour
{
    private Vector3 _pointB; // Точка B
    private float _counter = 0;
    
   [SerializeField] private float _resistanceSpeed = 1f; // Скорость движения 

    private float deltatime;


    private void Update()
    {
        // инициализируем точку Б
        if (_counter < 1)
        {
            _pointB = transform.position;
            _pointB.y -= 15;
            _counter++;
        }


        deltatime += Time.deltaTime;
        transform.localPosition += Vector3.down / (_resistanceSpeed / deltatime);

    }
}
