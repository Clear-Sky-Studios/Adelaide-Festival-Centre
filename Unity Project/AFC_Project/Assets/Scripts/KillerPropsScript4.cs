using UnityEngine;
using System.Collections;

public class KillerPropsScript4 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //   Debug.Break();
            Application.LoadLevel(1);
            return;
        }


    }
}
