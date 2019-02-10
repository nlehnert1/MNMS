using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCollapse : MonoBehaviour
{
	bool isPressed = false;
	public GameObject pit;

	bool exited = false;
	public float delay = 1f;
	float timestamp;
    // Start is called before the first frame update
	/*
    void Start()
    {
        
    }
*/
    // Update is called once per frame
    void Update(){
		if(exited == true && isPressed == false){
			if(Time.time > timestamp){
				print("pit created");
				Instantiate(pit, transform.position,transform.rotation);
				exited = false;
				isPressed = true;
			}
		}
    }
	/*
	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			entered = true; 
		}
	}
	*/
	private void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			print("walkedOver");
			exited = true;
			timestamp = Time.time + delay;
		}
	}
}
