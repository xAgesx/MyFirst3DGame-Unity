
using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
   
    public PlayerMvt mvt;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log(collisionInfo.collider.name + " " +collisionInfo.collider.tag);
            mvt.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            
        }
        

    }
  
}
