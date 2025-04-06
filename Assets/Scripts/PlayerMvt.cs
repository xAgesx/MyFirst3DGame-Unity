
using System;
using UnityEngine;

public class PlayerMvt : MonoBehaviour{
    
    public Rigidbody rb ;
    public float speed; 
    public float sideWaysSpeed ;
    GameManager gameManager;
    public void Start(){
         gameManager = FindAnyObjectByType<GameManager>() ;
    }
    void FixedUpdate(){
        
        //Forward 
        rb.AddForce(0,0,speed * Time.deltaTime);
        
        //Sides
        if(Input.GetKey(GameManager.rightKey.ToLower())){
            rb.AddForce(sideWaysSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey(GameManager.leftKey.ToLower())){
            rb.AddForce(-sideWaysSpeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
       
        //On fall GameOver and Manual reset
        if(rb.position.y <= -10f || Input.GetKey(GameManager.restartKey.ToLower())){
            FindObjectOfType<GameManager>().GameOver();
        } 


       
    }
}
