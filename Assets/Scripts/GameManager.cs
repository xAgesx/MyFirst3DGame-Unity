
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public GameObject completeLevelUI ;
    public PlayerCollision player;
    public GameObject pause ;
    public Boolean pauseOn;
    public GameObject score ;
    
    void CompleteLevelUI(){
        completeLevelUI.SetActive(true);    
    }
    public void Complete(){
        Debug.Log("Lvl Complete !");
        CompleteLevelUI();
        player.mvt.enabled = false;

    }
    public void GameOver(){
        Debug.Log("Game Over !");
        Invoke("Restart",1f);
        
    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

    public void Pause(){
        
        Debug.Log("Pause");
        pause.SetActive(true);
        Time.timeScale = 0;
        pauseOn = true;
        score.SetActive(false);
    }
    public void Resume(){
        
        Debug.Log("Resume");
        pause.SetActive(false);
        Time.timeScale = 1;
        pauseOn = false ;
        score.SetActive(true);


    }

    public void Update(){
        if(Input.GetKeyDown("p")){
            if(!pauseOn){
                Pause();
            }else{
                Resume();
            }
        }
    }
    
    
}
