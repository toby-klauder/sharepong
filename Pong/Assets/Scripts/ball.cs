using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ball : MonoBehaviour
{
    public GameObject trigger;
    public AudioClip hitplayer; // start dev on sound triggers 
    public int speed = 0; 
    public int ballactivate = 0; 
    public int playerone, playertwo = 0; 
    public Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballactivate = 0;
        Vector3 centerPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f));
        rb.transform.position = centerPos;
        rb.velocity = new Vector3(0, 0, 0);
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && ballactivate == 0) 
        {
            ballactivate++; 
            rb = GetComponent<Rigidbody2D>();
            int rand1 = Random.Range(-5, 5);
            int rand2 = Random.Range(-5, 5);
            rb.velocity = new Vector3(rand1, rand2, 0);
        }

       // if (Input.GetKey(KeyCode.R)) {
         //   int rand1 = Random.Range(-5, 5);
           // int rand2 = Random.Range(-5, 5);
           // rb.velocity = new Vector3(rand1, rand2, 0);
        //}

       // if (Input.GetKey(KeyCode.O)) {
         //   speed++;
           // int rand1 = Random.Range(-5, 5);
            //int rand2 = Random.Range(-5, 5);
            //rb.velocity = new Vector3(rand1 + speed, rand2 + speed, 0);

        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerOneS" || collision.gameObject.name == "PlayerTwoS" || collision.gameObject.name == "PlayerThreeS" || collision.gameObject.name == "PlayerFourS") { 
            speed = 0; 
            Start(); 
        } 
        
       
    }




}
