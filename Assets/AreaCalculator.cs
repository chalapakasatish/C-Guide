using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCalculator : MonoBehaviour
{
    public float result;
    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
    private void Awake()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.height = 10; 
        rectangle.width = 10;
        rectangle.result = GetArea(rectangle);
        Debug.Log(rectangle.result);
    }
}
[Serializable]
public class Rectangle : Shape
{
    public float height, width;
    public override float CalculateArea()
    {
        this.result = height * width;
        return this.result;
    }
}
[Serializable]
public class Circle : Shape
{
    public float radius;
    public override float CalculateArea()
    {
        return radius * radius * Mathf.PI;
    }
}