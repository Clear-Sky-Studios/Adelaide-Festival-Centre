using UnityEngine;
using System.Collections;

public class GameOverScript2 : MonoBehaviour
{


    int score = 0;
    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

        GUI.Label(new Rect(Screen.width / 2 - 30, 300, 80, 30), "Score: " + score);
        if (GUI.Button(new Rect(Screen.width / 2 - 30, 350, 80, 60), "Retry"))
        {
            Application.LoadLevel(2);
        }

        GUI.Label(new Rect(Screen.width / 2 - 30, 300, 80, 30), "Score: " + score);
        if (GUI.Button(new Rect(Screen.width / 2 - 30, 200, 80, 60), "Go Home"))
        {
            Application.LoadLevel(0);
        }
    }

}