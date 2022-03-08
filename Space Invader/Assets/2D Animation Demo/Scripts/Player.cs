using UnityEngine;
using UnityEngine.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public string left, right;
    
    [FormerlySerializedAs("bullet")] public GameObject bulletPrefab;
    [FormerlySerializedAs("shottingOffset")] public Transform shootOffsetTransform;

    private Animator playerAnimator;
    private static readonly int Shoot = Animator.StringToHash("Shoot");

    //-----------------------------------------------------------------------------
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    //-----------------------------------------------------------------------------
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // todo - trigger a "shoot" on the animator
            playerAnimator.SetTrigger(Shoot);
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);
        }
        
        if (Input.GetKey(left))
        {
            Transform transform = GetComponent<Transform>();
            transform.position += -Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(right))
        {
            Transform transform = GetComponent<Transform>();
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
