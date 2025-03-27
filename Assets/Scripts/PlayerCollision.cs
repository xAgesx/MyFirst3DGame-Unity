
using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
   
    public PlayerMvt mvt;
    private Collider collider ; 
    void Start(){
        collider = new Collider() ;
    }
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log(collisionInfo.collider.name + " " +collisionInfo.collider.tag);
            mvt.enabled = false;
            collider = collisionInfo.collider;
            FindObjectOfType<GameManager>().GameOver();
            
        }
    }
    public Collider getCollider(){
        return collider;
    }
  
}
