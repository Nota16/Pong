using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class BallController : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI scoretext2;
    public int score, score2;
    public Rigidbody2D rgb;
    public float speed;
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rgb.velocity = new Vector2(x * speed, y * speed);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Duvar")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "SagDuvar") 
        {
            
            score++; 
            scoretext.text = score.ToString();

        }
        else if (collision.gameObject.tag == "SolDuvar") 
        {
            score2++;
            scoretext2.text = score2.ToString();

        }

    }
   
    

}
