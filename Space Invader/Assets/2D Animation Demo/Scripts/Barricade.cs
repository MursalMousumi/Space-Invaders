using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    private Transform playerBase;
    public float health = 2;
    // Start is called before the first frame update
    void Start()
    {
        playerBase = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (GameObject.Find("Barricade"))
        {
            GameObject playerBarricade = GetComponent<Collider>().gameObject;
            Barricade BarriHealth = playerBase.GetComponent<Barricade>();
            BarriHealth.health -= 1;
            //Destroy(gameObject);
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}
