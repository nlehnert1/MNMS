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

    void Start()
    {
        player = GameObject.Find("characterMainFinal");
        visionRadius = 1000.0f;
        moveSpeed = 100.00f;
    }

    void Update()
    {
        
    }

    void CanSeePlayer()
    {

    }
}
