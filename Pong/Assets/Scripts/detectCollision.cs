using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class detectCollision : MonoBehaviour
{
    public string kittenkaboodle; 
    public int score = 0; 
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            score++;
            if (score == 11) {
                SceneChange(); 
            }
            txt.text = score.ToString();

        }
    }

    public void SceneChange() {
        SceneManager.LoadScene(kittenkaboodle);
    }
}
