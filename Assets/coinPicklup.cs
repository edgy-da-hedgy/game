using UnityEngine;

public class coinPicklup : MonoBehaviour
{
    public int score = 1;
    private scoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindFirstObjectByType<scoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.AddScore(score);
        Destroy(gameObject);
    }

}

