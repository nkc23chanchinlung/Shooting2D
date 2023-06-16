using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FireballController : MonoBehaviour
{ Vector3 dir = Vector3.zero;
    float speed;
    Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;

        player = GameObject.Find("Player").transform;
        transform.position = player.position;
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        dir = Vector3.right;
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy")==true)
        {
            
            Destroy(gameObject);
        }
    }

}
