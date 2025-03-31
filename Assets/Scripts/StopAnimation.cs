using System;
using UnityEngine;
using UnityEngine.Animations;

public class StopAnimation : MonoBehaviour{

    public GameObject animation;
    public static Boolean AnimationPlayed = false;
    void Start(){
        if(AnimationPlayed == true)
            animation.SetActive(false);
        AnimationPlayed = true;
    }

}
