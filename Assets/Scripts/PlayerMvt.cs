
using System;
using UnityEngine;

public class PlayerMvt : MonoBehaviour{
    
    public Rigidbody rb ;
    public float speed; 
    public float sideWaysSpeed ;
    void FixedUpdate(){
        
        //Forward 
        rb.AddForce(0,0,speed * Time.deltaTime);
        
        //Sides
        if(Input.GetKey("d")){
            rb.AddForce(sideWaysSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideWaysSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
       
        //On fall GameOver and Manual reset
        if(rb.position.y <= -10f || Input.GetKey("r")){
            FindObjectOfType<GameManager>().GameOver();
        } 


       
    }
}
