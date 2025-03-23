using UnityEngine;

public class WindEffect : MonoBehaviour{
    
    public Rigidbody player ;
    public float speed ;
    void Update(){
        player.AddForce(speed * Time.deltaTime,0,0);
    }
}
