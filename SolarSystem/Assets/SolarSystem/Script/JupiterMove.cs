﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterMove : MonoBehaviour {
    public Transform Sun;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Sun.position, Vector3.up, 0.0847458f * Time.deltaTime);
        transform.Rotate(Vector3.up, 2.430517f);
    }
}
