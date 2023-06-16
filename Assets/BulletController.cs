using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float speed;
    Transform player;
    Vector3 dir= Vector3.zero;
    //Transform EnemeySp;
    bool pos;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        player = GameObject.Find("Player").transform;
        dir = player.position - transform.position;
        Destroy(gameObject, 4f);
        //EnemeySp = GameObject.Find("EnemyPreSp").transform;
        pos= true;
        
        

        }

    // Update is called once per frame
    void Update()
    {
         
            transform.position += dir.normalized * speed * Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            GameDirector.lastTime -= 10f;
            Destroy(gameObject);
        }
    }
}
