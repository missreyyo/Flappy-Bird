using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public float jump_interval;
    Rigidbody2D rigidbody;
    public Text score_text;
    public float score;
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>(); 
       score = 0;
    }

    
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        rigidbody.velocity = Vector2.up * jump_interval;
       score_text.text = score.ToString();
       
    }
    void OnTriggerEnter2D(Collider2D touch){
        if(touch.gameObject.tag == "Scorer"){
            score++;
        }
    }
    void OnCollisionEnter2D(Collision2D touch){
         if((touch.gameObject.tag == "Plane") || (touch.gameObject.tag == "Pipe")){
            SceneManager.LoadScene("GameOver");                
         }
    }
}
