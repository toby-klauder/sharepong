using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakebehavior : MonoBehaviour
{
    private Transform transform;
    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.7f;
    private float dampeningSpeed = 1.0f;
    Vector3 initalPos; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initalPos + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampeningSpeed;
        }
        else {
            shakeDuration = 0f;
            transform.localPosition = initalPos; 
        }
        
    }

    void Awake()
    {
        if (transform == null) {
            transform = GetComponent(typeof(Transform)) as Transform; 
        }   
    }
    void OnEnable()
    {
        initalPos = transform.localPosition; 
    }
}
