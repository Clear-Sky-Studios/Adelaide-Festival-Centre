using UnityEngine;
using System.Collections;

public class MovingBlockScript2 : MonoBehaviour {

    public float moveSpeed = 10f;

    void Update ()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

}
