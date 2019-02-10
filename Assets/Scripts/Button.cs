using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
	bool isPressed = false;
	public GameObject newMap;
	public GameObject wall1;
	public GameObject wall2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			if(isPressed == false){
				print("buttonPressed");
				isPressed = true;
				newMap.SetActive(true);

				//if(wall1 != null){
					wall1.SetActive(true);
				//}
				if(wall2 != null){
					wall2.SetActive(false);
				}
			}
		}
	}
}

