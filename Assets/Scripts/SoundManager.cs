using UnityEngine;

public class SoundManager : MonoBehaviour{
    
    public GameObject player;
    public AudioSource fallingSound;


    public void Falling(){
        fallingSound.Play();
    }
}
