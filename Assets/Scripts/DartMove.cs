using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartMove : MonoBehaviour
{
	public float speed = .05f;
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		rb.velocity = gameObject.transform.up * speed;
    }
	
	private void OnCollisionEnter2D(Collision2D other){
		print("DART IS GONE");
		if(other.gameObject.tag == "Dart"){
            Destroy(other.gameObject);
			Destroy (gameObject);
		}
	}
	
}

