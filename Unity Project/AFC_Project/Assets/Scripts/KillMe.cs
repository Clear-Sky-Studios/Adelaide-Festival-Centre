﻿using UnityEngine;
using System.Collections;

public class KillMe : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider col) {
	if(col.tag == "RobotPlayer") {
			Score.score ++;
		}
	}
}
