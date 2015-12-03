using UnityEngine;
using System.Collections;

public class StartMove : MonoBehaviour {

    public GameObject camera;
    public GameObject playerCapsule;

    // Use this for initialization
    void Start()
    {

        iTweenEvent.GetEvent(camera, "StartMove").Play();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //iTweenEvent.GetEvent(camera, "Move").Play();


    }

   
}
