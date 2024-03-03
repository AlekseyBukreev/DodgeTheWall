using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueForWall : MonoBehaviour
{   
    [SerializeField]
    private GameObject[] gameObjects = new GameObject[8];

    private float yUp = 16.25f, yDown = 2f, heightPixel = 1.28f, level = 0.25f;
    private float stepX = 8f, startWallX = 3f; 
    private float distanceForCamera = 3f;

    public float YUp { get {return yUp;} private set {}}
    public float YDown { get {return yDown;} private set {}}
    public float HeightPixel { get {return heightPixel;} private set {}}
    public float Level { get {return level;} private set {}}
    public float StepX { get {return stepX;} private set {}}
    public float StartWallX { get {return startWallX;} private set {}}
    public float DistanceForCamera { get {return distanceForCamera;} private set {}}

    public GameObject ValueObject(int number)
    {
        return gameObjects[number];
    }

    public int Length()
    {
        return gameObjects.Length;
    }

    public float Koef(int number)
    {
        float displacement = (HeightPixel * (number + 1 - Level) / 2);
        return displacement;
    }

    public float CalculatePositionX(int Value)
    {
        return StartWallX + StepX * (Value + 1);
    }
        public float CalculatePositionYDown(int number)
    {
        return YDown + Koef(number);
    }
        public float CalculatePositionYUp(int number)
    {
        return YUp - Koef(number);
    }

}
