using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour{
    public void LoadNextLevel(){
        IntroScreen.introShown = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
