using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Enemy : MonoBehaviour
{
    //private Transform enemyHolder;
    //public float speed;
    //public float fireRate = 1f;
    private Transform playerBase;
    
    //-----------------------------------------------------------------------------
    private void Start()
    {
        playerBase = GetComponent<Transform>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // todo - trigger death animation
        Destroy(collision.gameObject); // destroy bullet
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (GameObject.Find("Bullet"))
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
            Debug.Log("enemy destroyed");
            
            if (GameObject.Find("EnemyR"))
            {
                Score.playerScore += 10;
                Destroy(gameObject);
            }
            if (GameObject.Find("EnemyG"))
            {
                Score.playerScore += 20;
                Destroy(gameObject);
            }
            if (GameObject.Find("EnemyB"))
            {
                Score.playerScore += 30;
                Destroy(collider.gameObject);
                Destroy(gameObject);
            }
            if (GameObject.Find("EnemyW"))
            {
                Score.playerScore += 50;
                Destroy(gameObject);
            }
            
        }
        else if (GameObject.Find("Barricade"))
        {
            GameObject playerBarricade = collider.gameObject;
            Barricade BarriHealth = playerBase.GetComponent<Barricade>();
            BarriHealth.health -= 1;
            Destroy(gameObject);
        }
        
    } 
}

//white += 50
//blue += 30
//green += 20
//red += 10
