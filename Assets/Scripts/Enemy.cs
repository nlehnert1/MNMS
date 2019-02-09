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
    int health;

    //Used for initialization. Finds player object, then sets vision radius, move speed, and health;
    void Start()
    {
        player = GameObject.Find("characterMainFinal");
        visionRadius = 10.0f;
        moveSpeed = 5f;
        health = 100;
    }

    //Called once per frame. Calls function to set following, then calls FollowPlayer.
    void Update()
    {
        following = CanSeePlayer();
        FollowPlayer(following);
    }

    //Calculates if enemy can "see" player based on each of their positions and the enemy's vision radius. Sets 'following' variable accordingly
    public bool CanSeePlayer()
    {
        playerPosition = player.transform.position;
        enemyPosition = this.transform.position;

        //radius = (x2 - x1)^2 + (y2 - y1)^2
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

    //Simple follow player script that will execute if following is set to true
    public void FollowPlayer (bool following)
    {
        if(following)
        {
            this.transform.Translate((player.transform.position - transform.position).normalized * moveSpeed * Time.deltaTime);
        }
    }

    public int AttackPlayer ()
    {
        //If close enough to player (OR UPON COLLISION WITH PLAYER), deals damage to player.
        //TODO: implement one or the other. Probably upon collision, because ideally player would attack and kill enemy if the enemy is only close to the player
        return 0;
    }

    //Takes an integer amount of damage passed by player, trap, whatever. Reduces health by amount. If health reaches or goes below zero, calls the Die function
    public void TakeDamage(int damage)
    {
        health = health - damage;
        if(health <= 0)
        {
            this.Die();
        }
    }

    //De-instantiates the object. Sets flags (TODO: HOW??) regarding what gets "Left Behind" for trip back through the level.
    public void Die()
    {
        //Set flags or whatever

        //Destroy instance of object
        Destroy(this.gameObject);
    }
}
