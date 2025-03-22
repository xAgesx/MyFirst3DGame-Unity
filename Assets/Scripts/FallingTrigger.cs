using Unity.VisualScripting;
using UnityEngine;

public class FallingTrigger : MonoBehaviour{
    
    public Rigidbody rb ;
    public Rigidbody player ;
    public float triggerDistance;
    
    void Start(){
        rb.useGravity = false;
    }
    void Update(){
        if(player.position.z >= rb.position.z-triggerDistance){
            rb.useGravity = true;
        }
    }
}
