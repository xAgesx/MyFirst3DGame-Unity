using System;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour{
    
    public GameObject player;
    public PlayerMvt playerMvt;
    public AudioSource fallingSound , collisionSound , levelCompleteSound ,wooshSound;
    public Boolean playingSound;
    public Canvas canvas ;
    Vector3 vector;
    public void Start(){
        //THIS IS THE VECTOR I AM USING TO TRIGGER THE WOOSH SOUND WHEN THE POPUPSIDE PANNEL SLIDES
        vector = new Vector3(500,0,0);
    }
    public void Update(){

        if(canvas.transform.GetChild(1).gameObject.transform.position.x <= vector.x && !playingSound){
            Woosh();
            Debug.Log("woosh");
            playingSound = true;
            
        }
        if(player.GetComponent<PlayerCollision>().getCollider() != null){
            
            if(player.GetComponent<PlayerCollision>().getCollider().tag == "Obstacle" && !playingSound){
                //PLAY COLLISION SOUND
                Collision();
                playingSound = true;
            } 
            
            
        }
        else{
            if(FindAnyObjectByType<GameManager>().end == true && !playingSound){ 
                //PLAY LEVEL END SOUND
                Debug.Log("WINNNN");
                playingSound = true;
                LevelComplete();
            }
            else if((float)player.transform.position.y <= -1 && !playingSound){
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
    public void LevelComplete(){
        levelCompleteSound.Play();
    }
    public void Woosh(){
        wooshSound.Play();
    }
}
