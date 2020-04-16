﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    private Rigidbody rigidbody; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.forward * speed);
        rigidbody.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
