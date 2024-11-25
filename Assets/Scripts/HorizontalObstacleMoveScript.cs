using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HorizontalObstacleMoveScript : MonoBehaviour
{
    private Vector3 _pointA; // Точка A
    private Vector3 _pointB; // Точка B
    private float _counter = 0;
    [SerializeField] private float _deflectionDistance; // Дистанция отклонения по оси Х
    [SerializeField] private float _speed = 2f; // Скорость движения 

    private float deltatime;


    private void Update()
    {
        // инициализируем точки А и Б
        if (_counter < 1)
        {
            _pointA = transform.position;
            _pointB = transform.position;
            _pointA.x = -_deflectionDistance;
            _pointB.x = _deflectionDistance;
            _counter++;
        }


        deltatime += Time.deltaTime;
        var progress = (MathF.Sin(deltatime * _speed) + 1) / 2;
        transform.position = Vector3.Lerp(_pointA, _pointB, progress);
    }
}