
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI ;

public class GameManager : MonoBehaviour{

    public GameObject completeLevelUI ;
    public PlayerCollision player;
    public GameObject pause ;
    public Boolean pauseOn,end;
    public GameObject score ;
    public GameObject options;
    public GameObject canvas;
    
    
    
    void CompleteLevelUI(){
        completeLevelUI.SetActive(true);    
    }
    public void Complete(){
        Debug.Log("Lvl Complete !");
        end = true ;
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
    
    public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Pause(){
        
        Debug.Log("Pause");
        pause.SetActive(true);
        Time.timeScale = 0;
        pauseOn = true;
        score.SetActive(false);
    }
    public void Resume(){
//Disable All UIs
        Debug.Log("Resume");
        pause.SetActive(false);
        options.SetActive(false);
        canvas.transform.GetChild(3).gameObject.SetActive(false);
        canvas.transform.GetChild(4).gameObject.SetActive(false);

//Reset TimeFlow + Enable Score Ui
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
    public void DisplayOptionsUI(){
        pause.SetActive(false);
        options.SetActive(true);
    }
    public void DisplayControlsUI(){
        
        canvas.transform.GetChild(2).gameObject.SetActive(false);
        canvas.transform.GetChild(3).gameObject.SetActive(true);

    }
    public void DisplayAudioUI(){
        canvas.transform.GetChild(2).gameObject.SetActive(false);
        canvas.transform.GetChild(4).gameObject.SetActive(true);

    }
    
    
}
