using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Enemy : MonoBehaviour
{
  private Animator playerAnimator;
  private static readonly int Explode = Animator.StringToHash("Explode");
  
  private AudioSource _audioSource;
  public AudioClip dieSound; 
    //private Transform enemyHolder;
    //public float speed;
    //public float fireRate = 1f;

    //-----------------------------------------------------------------------------
    // private void Start()
    // {
    //
    // }
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // todo - trigger death animation
        ActivateSound(dieSound);
        Destroy(collision.gameObject); // destroy bullet
        
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //ActivateSound(dieSound);
            if (GameObject.Find("EnemyR"))
            {
                //ActivateSound(dieSound);
                Destroy(collider.gameObject);
                Destroy(gameObject);
                playerAnimator.SetTrigger(Explode);
                Score.playerScore += 10;
            }

            if (GameObject.Find("EnemyG"))
            {
                //ActivateSound(dieSound);
                Destroy(collider.gameObject);
                Destroy(gameObject);
                playerAnimator.SetTrigger(Explode);
                Score.playerScore += 20;
            }

            if (GameObject.Find("EnemyB"))
            {
                //ActivateSound(dieSound);
                Destroy(collider.gameObject);
                Destroy(gameObject);
                playerAnimator.SetTrigger(Explode);
                Score.playerScore += 30;
            }

            if (GameObject.Find("EnemyW"))
            {
                //ActivateSound(dieSound);
                Destroy(collider.gameObject);
                Destroy(gameObject);
                playerAnimator.SetTrigger(Explode);
                Score.playerScore += 50;
            }
            //   Destroy(collider.gameObject);
            //   Destroy(gameObject);
            //   Debug.Log("enemy destroyed");
    }
    private void ActivateSound(AudioClip soundClip)
    {
        _audioSource.clip = soundClip;
        _audioSource.Play();
    }
}

//white += 50
//blue += 30
//green += 20
//red += 10
