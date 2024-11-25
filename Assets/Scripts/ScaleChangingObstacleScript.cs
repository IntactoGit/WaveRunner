using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScaleChangingObstacleScript : MonoBehaviour
{
    [SerializeField] private Vector3 _startState;
    [SerializeField] private Vector3 _endState;
    [SerializeField] private float _speed;
    private float deltatime;


    private void Update()
    {
        deltatime += Time.deltaTime;
        var progress = (MathF.Sin(deltatime * _speed) + 1) / 2;
        transform.localScale = Vector3.Lerp(_startState, _endState, progress);
    }
}