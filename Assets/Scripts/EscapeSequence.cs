using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeSequence : MonoBehaviour
{
	public float escapeTime = 90f;
	public float timeLeft;
	bool escapeStart = false ;
	public GameObject timer;
	public GameObject runText;
	float timestamp;
	bool isTouched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(escapeStart){
			timeLeft = timestamp - Time.time;
			timer.GetComponent<UnityEngine.UI.Text>().text = timeLeft.ToString("F2");
		}
    }
	private void OnTriggerEnter2D(Collider2D other){
		//Each checkpoint can be gained once until the end is reached, upon which they are all reset
		if(other.gameObject.tag == "Player" && isTouched == false){
			timer.SetActive(true);
			runText.SetActive(true);
			timestamp = Time.time + escapeTime;
			escapeStart = true;
			isTouched = true;
		}



	}

}
