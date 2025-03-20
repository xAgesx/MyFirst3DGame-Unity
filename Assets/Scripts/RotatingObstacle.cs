using UnityEngine;

public class RotatingObstacle : MonoBehaviour{

    public Transform rotation;
    
    void Update(){
        rotation.Rotate(0,1,0);
    }
}
