using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle
{
    public float speed = 100;
    public Vector3 direction;
    public void GoForward()
    {
        Debug.Log("GoForward");
    }
    public void Reverse()
    {
        Debug.Log("Reverse");
    }
    public void TurnRight()
    {
        Debug.Log("TurnRight");
    }
    public void TurnLeft()
    {
        Debug.Log("TurnLeft");
    }
}
