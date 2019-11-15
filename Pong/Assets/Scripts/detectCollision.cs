using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events; 
public class detectCollision : MonoBehaviour
{
    public UnityEvent ongoal; 
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
        if (collision.gameObject.name == "Ball" || collision.gameObject.name == "Duplicate Ball")
        {
            ongoal.Invoke(); 
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
