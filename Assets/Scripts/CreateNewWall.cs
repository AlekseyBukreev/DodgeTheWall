using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWall : MonoBehaviour
{
    private ValueForWall NewWall;
    private  int viewUpWall, viewDownWall;
    private float xPositionNewWall = 33.5f;
    private static bool needCreateWall = false;
    public static bool NeedCreateWall { get {return needCreateWall;} set {needCreateWall = value;}}

    void Awake()
    {
        NewWall = GetComponent<ValueForWall>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (needCreateWall == true)
        {
            viewDownWall = Random.Range(0, NewWall.Length());
            viewUpWall = NewWall.Length() - viewDownWall - 1;

            Instantiate(NewWall.ValueObject(viewDownWall), new Vector3(xPositionNewWall, NewWall.CalculatePositionYDown(viewDownWall),NewWall.DistanceForCamera), Quaternion.Euler(0,0,0));
            Instantiate(NewWall.ValueObject(viewUpWall), new Vector3(xPositionNewWall, NewWall.CalculatePositionYUp(viewUpWall),NewWall.DistanceForCamera), Quaternion.Euler(0,0,0));

            needCreateWall = false;
        }
    }

    public void UpFlag()
    {
        needCreateWall = true;
    }

}
