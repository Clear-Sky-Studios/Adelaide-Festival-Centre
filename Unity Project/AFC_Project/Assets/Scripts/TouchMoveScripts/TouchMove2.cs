using UnityEngine;
using System.Collections;

public class TouchMove2 : MonoBehaviour {


    public GameObject camera;

    // Use this for initialization
    void Start()
    {

        //iTweenEvent.GetEvent(camera, "Move").Play();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //iTweenEvent.GetEvent(camera, "Move").Play();


    }

    void OnMouseDown()
    {
        iTweenEvent.GetEvent(camera, "Move2").Play();
    }
}