using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class playercontrol : MonoBehaviour
{
    
   
    public Rigidbody2D Rgb2d;
    public float speed;
    public bool players1; 
  
    void Update()
    {
        
      
        if (players1)
        {

            Rgb2d.velocity = Vector2.up * Input.GetAxisRaw("VerticalPlayer2") * speed;
           
        }
        else {
            
            Rgb2d.velocity = Vector2.up * Input.GetAxisRaw("Vertical") * speed;
        }
    }
    
}
