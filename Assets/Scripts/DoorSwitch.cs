using UnityEngine;

public class DoorSwitch : MonoBehaviour{

    public MeshRenderer doorSwitch ;
    public GameObject door ;
    public float delay;
     void OnTriggerEnter(){
        Debug.Log("Switch triggered");
        doorSwitch.enabled = false;
        Invoke("HideDoor",delay);

    }
    void HideDoor(){
        door.GetComponent<MeshRenderer>().enabled = false ;
        door.GetComponent<Collider>().enabled = false ;
    }
}
