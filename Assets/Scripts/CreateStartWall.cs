using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateStartWall : MonoBehaviour
{
    private ValueForWall StartValue;

    private  int viewUpWall, viewDownWall;

    void Awake() 
    {
        StartValue = GetComponent<ValueForWall>();
    }

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            viewDownWall = Random.Range(0, StartValue.Length());
            viewUpWall = StartValue.Length() - viewDownWall - 1;

            Instantiate(StartValue.ValueObject(viewDownWall), new Vector3(StartValue.CalculatePositionX(i),StartValue.CalculatePositionYDown(viewDownWall),StartValue.DistanceForCamera), Quaternion.Euler(0,0,0));
            Instantiate(StartValue.ValueObject(viewUpWall), new Vector3(StartValue.CalculatePositionX(i), StartValue.CalculatePositionYUp(viewUpWall),StartValue.DistanceForCamera), Quaternion.Euler(0,0,0));

        }
        
    }

}
