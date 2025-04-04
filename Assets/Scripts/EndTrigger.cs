using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour{
    
    void OnTriggerEnter(){
        if(FindObjectOfType<PlayerMvt>().enabled == true)
            
            FindObjectOfType<GameManager>().Complete();
    }
}
