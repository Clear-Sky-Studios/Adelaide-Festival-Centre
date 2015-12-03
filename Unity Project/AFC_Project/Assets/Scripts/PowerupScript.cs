using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

    HUDScript hud;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "RobotPlayer")
        {
            hud = GameObject.Find("________________________________________Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(10);
            Destroy(gameObject);
        }
    }

}
