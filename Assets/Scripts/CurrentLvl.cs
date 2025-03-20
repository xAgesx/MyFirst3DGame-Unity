using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class CurrentLvl : MonoBehaviour{

    public Text text ;
void Update(){
    text.text = "Level "+SceneManager.GetActiveScene().buildIndex.ToString();
}
   
}
