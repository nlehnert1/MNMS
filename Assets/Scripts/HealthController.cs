using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    const int MAX_HEALTH = 100;
    int currentHealth;
    private int numDeaths;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAX_HEALTH;
        numDeaths = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
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
        numDeaths++;
        //Destroy object(?)
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Dart")
        {
            TakeDamage(100);
        }
        
    }
}
