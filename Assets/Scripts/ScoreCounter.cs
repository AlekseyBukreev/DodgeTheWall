using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private static int score = 0;
    public static int Score { get{return score;} set {score = value;}}
    private int oldScore;
    
    void Start()
    {
        oldScore = score;
    }

    void Update()
    {
        if (oldScore < score)
        {
            oldScore = score;
            scoreText.text = $"Score: {score}";
        }
    }
}
