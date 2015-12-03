using UnityEngine;
using System.Collections;

public class GUITextScript : MonoBehaviour {

    public GUIText scoreText;
    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore ()
    {
        scoreText.text = "Score:" + score;
    }
}
