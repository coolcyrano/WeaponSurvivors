using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour
 {public Rigidbody rig;
    public float horizontal;
    public float vertical;
    public float speed = 20f;
    public Transform cam;

    void Update()
    {
        Vector3 inputVector = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += rig.transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector -= rig.transform.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += rig.transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector -= rig.transform.forward;
        }

        inputVector.y = 0;

        rig.AddForce(inputVector * speed);
    }
}