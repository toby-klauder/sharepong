using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour
{
    public Shakebehavior sb;
    public GameObject trigger;
    public GameObject ball; 
    public AudioClip hitplayer; // start dev on sound triggers 
    public float speed = 5; 
    public int ballactivate = 0; 
    public int playerone, playertwo = 0; 
    public Rigidbody2D rb;
    public Color[] colorlist = new Color[5];
    public int colorcount = 0; 
    // Start is called before the first frame update
    void Start()
    {
        colorlist[0] = Color.red;
        colorlist[1] = Color.green;
        colorlist[2] = Color.magenta;
        colorlist[3] = Color.yellow;
        colorlist[4] = Color.grey; 
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
            int rand1 = Random.Range(1, 5);
            int rand2 = Random.Range(1, 5);
            rb.velocity = new Vector2(rand1, rand2).normalized * speed;
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
            Start(); 
        }
        if (collision.gameObject.name == "PlayerOne" || collision.gameObject.name == "PlayerTwo") {
            speed += 1;
            sb.shakeDuration = 0.5f;
            var ballrenderer = ball.GetComponent<Renderer>();
            if (colorcount == 5) {
                colorcount = 0; 
            }
            ballrenderer.material.SetColor("_Color", colorlist[colorcount]);
            colorcount++; 
            
            
        }
       
    }




}
