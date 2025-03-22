
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public GameObject completeLevelUI ;
    public PlayerCollision player;

    
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

    
    
}
