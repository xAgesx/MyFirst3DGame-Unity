using System;
using TMPro;
using UnityEngine;

public class SetControlsKeys : MonoBehaviour{

    string key;
    Boolean waitingForKey = false;
     public void ButtonClicked(){
        key = this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text ;
        SetKeyText("__");
        waitingForKey = true;
        
    }
    public void Update(){
       
        if (Input.anyKeyDown && waitingForKey){
                foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))){
                if (Input.GetKeyDown(key) && !IsMouseButton(key)){
                    Debug.Log($"Key pressed: {key}");
                    waitingForKey = false;
                    SetKeyText(key.ToString());
                    SetKey(key.ToString());
                    break;
                }
            }
            
            }
    }
    private Boolean IsMouseButton(KeyCode key){
        return key == KeyCode.Mouse0 ||
               key == KeyCode.Mouse1 ||
               key == KeyCode.Mouse2 ||
               key == KeyCode.Mouse3 ||
               key == KeyCode.Mouse4 ||
               key == KeyCode.Mouse5 ||
               key == KeyCode.Mouse6;
    }
    private void SetKeyText(string text){
        this.gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = text ;
    }
    private void SetKey(string key){
        switch(this.name){
            case "RightKey":    GameManager.rightKey = key;      break;
            case "LeftKey":     GameManager.leftKey = key;       break;
            case "RestartKey":  GameManager.restartKey = key;    break;
            case "PauseKey":    GameManager.pauseKey = key;      break;

        }
    }
}
