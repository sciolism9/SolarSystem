using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour {
    public Transform Sun;
    public float speed = 5f;
    void Start()
    {
    }

    void Update()
    {
        //transform.RotateAround(Sun.position, Vector3.up, speed * Time.deltaTime);
        transform.Rotate(Vector3.up, 0.01f);
    }
}
