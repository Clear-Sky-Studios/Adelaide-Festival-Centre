using UnityEngine;
using System.Collections;

public class LoadLevelScript : MonoBehaviour {

    private GameObject ButtonDown;

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
    //    if (Input.GetMouseButton(0))
    //        Debug.Log("Pressed left click.");
    //    Application.LoadLevel(1);
    }

    void OnMouseDown()
    {
        Application.LoadLevel(1);
    }
}
