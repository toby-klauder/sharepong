using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shakebehavior : MonoBehaviour
{
   
    public float shakeDuration = 0f;
    public float shakeMagnitude = 0.7f;
    public float dampeningSpeed = 1.0f;
    Vector3 initalPos; 
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
       
        if (shakeDuration > 0)
        {
            print("DEBUGINSIDE");
            transform.localPosition = initalPos + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampeningSpeed;
        }
        else {
            shakeDuration = 0f;
            transform.localPosition = initalPos; 
        }
        
    }

    public void OnEnable()
    {
        initalPos = transform.localPosition; 
    }
}
