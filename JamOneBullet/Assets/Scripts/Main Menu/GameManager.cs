using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private int score;


    private void OnEnable()
    {
        Bullet.OnScore += ScoreCounter;
    }
    private void OnDisable()
    {
        Bullet.OnScore -= ScoreCounter;
    }
    private void ScoreCounter()
    {
        score++;
        scoreText.text = score.ToString();
    }


}//Class
