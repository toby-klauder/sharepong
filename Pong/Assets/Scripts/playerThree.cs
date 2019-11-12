using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.K) && transform.position.x < 5)
        {
            Vector3 position = this.transform.position;
            position.x += (float)0.1;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.J) && transform.position.x > -5)
        {
            Vector3 position = this.transform.position;
            position.x -= (float)0.1;
            this.transform.position = position;
        }
    }
}
