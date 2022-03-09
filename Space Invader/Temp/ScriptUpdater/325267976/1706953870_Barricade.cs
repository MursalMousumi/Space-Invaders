using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    public float health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else if (GameObject.Find("Barricade"))
        {
            GameObject playerBarricade = GetComponent<Collider>().gameObject;
            Barricade BarriHealth = playerBase.GetComponent<Barricade>();
            BarriHealth.health -= 1;
            Destroy(gameObject);
        }
    }
}
