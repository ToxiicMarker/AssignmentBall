﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Robot;
    private Vector3 offset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Robot.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Robot.transform.position + offset;
    }
}
