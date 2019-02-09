using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    Vector2 playerPosition;
    Vector2 enemyPosition;
    float visionRadius;
    float moveSpeed;
    bool following;
    float radius;

    void Start()
    {
        player = GameObject.Find("characterMainFinal");
        visionRadius = 1000.0f;
        moveSpeed = 100.00f;
    }

    void Update()
    {
        following = CanSeePlayer();
        FollowPlayer(following);
    }

    public bool CanSeePlayer()
    {
        playerPosition = player.transform.position;
        enemyPosition = this.transform.position;

        radius = Mathf.Sqrt(Mathf.Pow(playerPosition.x - enemyPosition.x, 2) + Mathf.Pow(playerPosition.y - enemyPosition.y, 2));
        if(radius <= visionRadius)
        {
            following = true;
        }
        else
        {
            following = false;
        }
        return following;
    }

    public void FollowPlayer (bool following)
    {
        if(following)
        {
            this.transform.Translate((player.transform.position - transform.position).normalized * moveSpeed * Time.deltaTime);
        }
    }
}
