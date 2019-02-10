using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayPoint : MonoBehaviour
{
	public bool isTouched = false; 
	public GameObject[] checkPoints;
	public GameObject idolGone;
	public GameObject exitPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D other){
		//Each checkpoint can be gained once until the end is reached, upon which they are all reset
		if(other.gameObject.tag == "Player"){
			if(isTouched == false){
                checkPoints = GameObject.FindGameObjectsWithTag("CheckPoint");
                
                idolGone.SetActive(true);
				exitPath.SetActive(true);
				
				isTouched = true;
                foreach (GameObject checkP in checkPoints)
                {
                    checkP.GetComponent<checkPointTrack>().goingBack = true;
                    checkP.GetComponent<checkPointTrack>().hasTouched = false;
                }

            }
            


        }
	}
}
