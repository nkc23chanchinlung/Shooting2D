using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemSCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag =="Player")
        {
            
            Destroy(gameObject);
            PlayerController.speed += 1;

        }
    }
}
