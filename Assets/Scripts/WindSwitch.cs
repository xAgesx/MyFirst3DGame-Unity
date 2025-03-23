
using UnityEngine;
using UnityEngine.UIElements;

public class WindSwitch : MonoBehaviour{
    
    public Rigidbody player;
    public GameObject wind ;
    public ParticleSystem particles;
    void OnTriggerEnter(){
        var shape = particles.shape ;
        var pos = wind.transform.position.x ;
        pos= 5 ;
        shape.rotation = new Vector3(0,-90,0);
        FindObjectOfType<WindEffect>().speed = -1200 ;
    }
}
