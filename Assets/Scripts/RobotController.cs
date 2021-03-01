using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RobotController : MonoBehaviour{
    public float forwardSpeed =25f, strafeSpeed = 7.5f, diveSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeDiveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        activeDiveSpeed = Input.GetAxisRaw("Dive") * diveSpeed;

        transform.position += (transform.forward * activeForwardSpeed * Time.deltaTime) + (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeDiveSpeed * Time.deltaTime);

    }
}
