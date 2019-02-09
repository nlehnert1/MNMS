using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointManager : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject currentCPoint;
    void Start()
    {
		currentCPoint = GameObject.Find("CheckPoint0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void onTriggerEnter(Collider other){
		if(other.gameObject.tag == "CheckPoint"){
			currentCPoint = other.gameObject;
		}
	}
}
