using UnityEngine;
using System.Collections;

public class ComingSoonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

      void OnGUI()
    {
          if(GUI.Button (new Rect (Screen.width / 2 - 30, 150, 100, 100), "ComingSoon"))
{
    Application.LoadLevel(2);
}

    
    }

}
