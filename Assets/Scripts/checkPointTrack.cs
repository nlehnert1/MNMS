using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkPointTrack : MonoBehaviour
{
    // Start is called before the first frame update
	public bool hasTouched = false;
	public bool goingBack = false;
	public GameObject mCamera; 
    void Start()
    {
		mCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D other){
		//Each checkpoint can be gained once until the end is reached, upon which they are all reset
		if(other.gameObject.tag == "Player"){
			if(hasTouched == false){
				other.gameObject.GetComponent<checkPointManager>().currentCPoint = gameObject;
				other.gameObject.GetComponent<checkPointManager>().checkPointCounter++;
				hasTouched = true;
				if(goingBack == false){
					//move camera forward
					mCamera.transform.position += new Vector3(0f,10f,0f);
				} else {
					mCamera.transform.position -= new Vector3(0f,10f,0f);
				}
			}

		}
	}
	private void OnTriggerStay2D(Collider2D other){
        if (goingBack && other.gameObject.GetComponent<checkPointManager>().currentCPoint == GameObject.Find("CheckPoint0"))
        {
            SceneManager.LoadScene("EndScene1-victory");
        }
		if(other.gameObject.tag == "Player"){
			if(goingBack == false){
				//move camera forward
				other.gameObject.transform.position += new Vector3(0f,.1f,0f);
			} else {
				other.gameObject.transform.position -= new Vector3(0f,.1f,0f);
			}
		}
	}
}
