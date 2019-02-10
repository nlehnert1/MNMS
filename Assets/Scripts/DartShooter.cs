using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartShooter : MonoBehaviour
{
	public double timeBetweenShots;
	public GameObject darts;
	double timeStamp = 0;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		if(timeStamp < Time.time){
			//fires the darts
			timeStamp = Time.time + timeBetweenShots;
			Instantiate(darts, transform.position,transform.rotation, transform);
		}
    }
}
