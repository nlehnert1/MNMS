using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    const int MAX_HEALTH = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        //if player gets hit
        if(false) //condition
        {

        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Do things

        //Destroy object(?)
        Destroy(this.gameObject);
    }
}
