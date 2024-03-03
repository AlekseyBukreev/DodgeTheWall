using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Transform transforms;
    private float speedPlayer = 18f, verticalMove;
    
    private void Awake()
    {
        transforms = GetComponent<Transform>();
    }

    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        transforms.Translate(new Vector2(0, 1) * verticalMove * speedPlayer * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Wall")
        {
            Gameover.Game_over();
            ScoreCounter.Score = 0;
        }
    }

}
