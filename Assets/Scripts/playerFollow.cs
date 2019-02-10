using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
	public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("characterMainFinal");
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = player.transform.position + new Vector3(0f,.5f,1f);
    }
}
