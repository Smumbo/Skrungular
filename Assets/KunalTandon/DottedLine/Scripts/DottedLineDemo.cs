using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DottedLineDemo : MonoBehaviour
{
    [Header("Points for line 1")]
    public Vector2 pointA;
    public Vector2 pointB;
    [Header("Points for line 2")]
    public Vector2 pointX;
    public Vector2 pointY;
    [Header("Points for line 2")]
    public Vector2 pointC;
    public Vector2 pointD;
    [Header("Points for line 2")]
    public Vector2 pointE;
    public Vector2 pointF;

    // Update is called once per frame
    void Update()
    {
        //Creating a dotted line 1
        DottedLine.DottedLine.Instance.DrawDottedLine(pointA, pointB);

        //Creating another dotted line 2
        DottedLine.DottedLine.Instance.DrawDottedLine(pointX, pointY);

        //Creating another dotted line 2
        DottedLine.DottedLine.Instance.DrawDottedLine(pointC, pointD);

        //Creating another dotted line 2
        DottedLine.DottedLine.Instance.DrawDottedLine(pointE, pointF);
    }
}
