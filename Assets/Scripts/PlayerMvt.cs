
using UnityEngine;

public class PlayerMvt : MonoBehaviour{
    
    public Rigidbody rb ;
    public float speed = 1000; 
    public float sideWaysSpeed = 20f ;

    // Update is called once per frame
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
       
        //On fall GameOver 
        if(rb.position.y <= -10f){
            FindObjectOfType<GameManager>().GameOver();
        } 

    }
}
