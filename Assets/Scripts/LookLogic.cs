﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookLogic : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform player;
    float rot = 0f;
    public Transform gun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rot -= mouseY;
        rot = Mathf.Clamp(rot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rot, 0f, 0f);
        /*rot = Mathf.Clamp(rot, -60f, 60f);
        gun.transform.localRotation = Quaternion.Euler(rot, 0f, 0f);
        */
        player.Rotate(Vector3.up * mouseX);

    }
}
