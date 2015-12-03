using UnityEngine;
using System.Collections;

public class CanvasShow : MonoBehaviour
{

    public Canvas menuCanvas1;

    void Start()
    {

        menuCanvas1.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            menuCanvas1.enabled = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        menuCanvas1.enabled = false;
    }

}