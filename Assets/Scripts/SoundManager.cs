using System;
using UnityEngine;

public class SoundManager : MonoBehaviour{
    
    public GameObject player;
    public PlayerMvt playerMvt;
    public AudioSource fallingSound , collisionSound;

    public Boolean falling ,collision;

    public void Update(){
         //PLAYING FALLING SOUND
        if((float)player.transform.position.y <= -1 && !falling && !collision){
            Debug.Log("Sound");
            Falling();
            falling = true ;
        }else if(playerMvt.enabled == false && !collision) {
            Collision();
            collision = true;
        }
    }
    public void Falling(){
       
        fallingSound.Play();
    }
    public void Collision(){
        collisionSound.Play();
    }
}
