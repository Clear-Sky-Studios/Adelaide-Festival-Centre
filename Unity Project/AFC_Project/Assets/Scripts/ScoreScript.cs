using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
    float playerScore = 0;
    int score = 0;
    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }

    void OnGUI()
    {


        GUI.Label(new Rect(Screen.width / 2 - 40, 100, 80, 30), "Score: " + score);

      
    }
}
