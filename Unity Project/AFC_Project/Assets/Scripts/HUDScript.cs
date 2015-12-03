using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    // player starting score
    float playerScore = 0;
	
	// Update is called once per frame
	void Update () {

        // player score is kept here 
        playerScore += Time.deltaTime;

	}

    public void IncreaseScore (int amount)
    {
        // Allows for powerups
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);
   }


    //Where score is displayed
    void OnGui()
    {
        //  Where the GUI is going to appear (upper left {co-ordinates, width, height) + Score x 100)
        GUI.Label(new Rect(10, 10, 500, 30), "Score: " + (int) (playerScore * 100));
        //GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + (int)(playerScore * 100));

  //    GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
    }
}
