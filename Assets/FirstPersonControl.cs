using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControl : MonoBehaviour
{
    public float turnSpeed = 1.0f;
    public float speed = 1.0f;

    void Update()
    {
        float turn = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * turn);
        float forward = Input.GetAxis("Vertical");
        float strafe = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * strafe * Time.deltaTime * speed);
        
    }
}
