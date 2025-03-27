using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScreen : MonoBehaviour {
    public Text introText;
    public String content;
    public static Boolean introShown ;
    public GameObject introPanel;
    public Text lvl ;

    void Start() {
        if(introShown == false){
        content = content.Replace("\\n", "\n");
        ShowIntro(content);
        introShown = true;
        }else{
            CloseIntro();
        }
    }

    public void ShowIntro(string message) {
        introText.text = message;
        lvl.text = "Lvl"+SceneManager.GetActiveScene().buildIndex ;
        introPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseIntro() {
        introPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
