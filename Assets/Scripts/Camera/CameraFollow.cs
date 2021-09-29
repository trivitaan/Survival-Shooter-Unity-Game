﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //Mendapatkan offset antara target dan camera
        offset = transform.position - target.position;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mendapatkan posisi untuk kamera
        Vector3 targetCamPos = target.position + offset;

        //set posisi kamera dengan smoothing
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
