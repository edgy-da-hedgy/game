using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void AddScore(int amount)
    {
        score += amount;
        updateText();
    }

    void updateText()
    {
        scoreText.text = "score:" + score;
    }
}
