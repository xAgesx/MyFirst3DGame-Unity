using UnityEngine;

public class MovingTopBottom : MonoBehaviour{
    public Transform obstacle ;
    public Vector3 offset ;
    public float Top,Bottom ;
    
    void Update(){
        if(obstacle.position.y > Top || obstacle.position.y < Bottom){
            offset *= -1;
        }
        
        obstacle.position += offset * Time.deltaTime ;
    }
}
