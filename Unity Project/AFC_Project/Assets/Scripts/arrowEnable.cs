using UnityEngine;
using System.Collections;

public class arrowEnable : MonoBehaviour {

	public GameObject arrow;
	public GameObject arrow1;

	// Use this for initialization
	void Start () {

		arrow.SetActive (false);
		arrow1.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		
		{
			arrow.SetActive(true);
			arrow1.SetActive(true);
		
		}



	}
}
