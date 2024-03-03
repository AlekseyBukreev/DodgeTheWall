using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    private Transform transformWall;
    private float moveSpeedWall = 3f;
    private CreateNewWall Cheak;
    private bool chekScore;

    void Start()
    {
        transformWall = GetComponent<Transform>();
        chekScore = true;
    }

    void Update()
    {
        if (gameObject.tag == "Wall")
        {
            gameObject.transform.Translate(new Vector2(-1, 0) * moveSpeedWall * Time.deltaTime);          
        }

        if (gameObject.transform.position.x <= -14.5f && gameObject.transform.position.y > 11f)
        {
            Destroy(gameObject);
            CreateNewWall.NeedCreateWall = true;
        }

        if (gameObject.transform.position.x <= -14.5f && gameObject.transform.position.y > 2f && gameObject.transform.position.y < 11f)
        {
            Destroy(gameObject);
        }       
    }

    private void FixedUpdate() 
    {
            if (gameObject.tag == "Wall" && gameObject.transform.position.x <= -6f && chekScore == true && gameObject.transform.position.y >= 11f)
            {
                chekScore = false;
                ScoreCounter.Score ++;
            }
    }
}
