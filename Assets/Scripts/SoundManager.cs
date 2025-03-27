using System;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour{
    
    public GameObject player;
    public PlayerMvt playerMvt;
    public AudioSource fallingSound , collisionSound;
    public Boolean playingSound;

    public void Update(){
        if(player.GetComponent<PlayerCollision>().getCollider() != null){
            
            if(player.GetComponent<PlayerCollision>().getCollider().tag == "Obstacle" && playingSound == false){
                //PLAY COLLISION SOUND
                Collision();
                playingSound = true;
            } 
            
            
        }
        else{
            if(FindAnyObjectByType<GameManager>().end == true && playingSound == false){ 
                //PLAY LEVEL END SOUND
                Debug.Log("WINNNN");
                playingSound = true;
            }
            else if((float)player.transform.position.y <= -1 && playingSound == false){
            //PLAYING FALLING SOUND
            Debug.Log("Sound");
            playingSound = true ;
            Falling();
            }
        }
    }
    public void Falling(){
       
        fallingSound.Play();
    }
    public void Collision(){
        collisionSound.Play();
    }
}
