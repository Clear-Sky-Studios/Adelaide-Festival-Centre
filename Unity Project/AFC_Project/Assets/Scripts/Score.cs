using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public static float score;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
	}
	
	
	void Update ()
	{

        // player score is kept here 
        score += Time.deltaTime * 4;

		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + Mathf.Floor(score).ToString();
	}

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)score);
    }


}