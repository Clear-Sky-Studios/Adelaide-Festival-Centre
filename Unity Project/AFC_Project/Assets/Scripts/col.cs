using UnityEngine;
using System.Collections;

public class col : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other) {
       // print(col.gameObject.name);
        Debug.Log(this.gameObject.name + "you HIT ME!!!!!" + other.gameObject.name);
	}
}
