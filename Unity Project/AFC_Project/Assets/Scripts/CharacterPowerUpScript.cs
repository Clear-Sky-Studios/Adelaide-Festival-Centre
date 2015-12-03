using UnityEngine;
using System.Collections;

public class CharacterPowerUpScript : MonoBehaviour
{

    HUDScript hud;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "powerup")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(10);
            Destroy(other.gameObject);
        }
    }

}
