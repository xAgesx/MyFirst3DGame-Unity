using UnityEngine;

public class MoveToSides : MonoBehaviour{

    public Transform obstacle ;
    public float position ;
    public Vector3 offset ;
    
    void start(){
        position = obstacle.position.x  ;
    }
    void Update(){
        if(obstacle.position.x > position + 5 ||obstacle.position.x < position - 5){
            offset *= -1;
        }
        
        obstacle.position += offset ;
    }
}
