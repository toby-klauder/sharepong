﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3.75)
        {
            Vector3 position = this.transform.position;
            position.y += (float) 0.1; 
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.5)
        {
            Vector3 position = this.transform.position;
            position.y -= (float) 0.1; 
            this.transform.position = position;
        }
    }
}
