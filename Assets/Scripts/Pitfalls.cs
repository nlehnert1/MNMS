using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitfalls : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("characterMainFinal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("fall");
        if(other.gameObject.tag == "Player")
        {
            //Component CPManager = other.GetComponent("checkPointManager");
            //player.transform.Translate(CPManager.GetComponent("currentCPoint").);
            player.transform.position = player.GetComponent<checkPointManager>().currentCPoint.transform.position;
        }

    }
}
