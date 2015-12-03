using UnityEngine;
using System.Collections;

public class KillerPropsScript3 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RobotPlayer")
        {
            //   Debug.Break();
            Application.LoadLevel(3);
          //  return;
            Debug.Log("you HIT ME!!!!!");
        }


    }
}