using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemySpController : MonoBehaviour
{
    
    float speed;
    int Hp;

    public GameObject bullet;
    public Animator exp;
    Vector3 dir = Vector3.zero;
    
    void Start()
    {
        Hp = 2;
        speed = 5f;


        //寿命8秒
        Destroy(gameObject, 8f);
        Invoke("InstantiateBullet", 1f);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        //移動方向を決定
        dir = Vector3.left;
        dir.y=2f*Mathf.Sin(Time.time*5f);

        //現在地に移動量を加算
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //制限時間を１０秒減らす
        if (collision.CompareTag("Player") == true)
        {
            GameDirector.lastTime -= 15f;
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Fire") == true)
        {
            Hp --;
            
            if (Hp <= 0)
            {
                Destroy(gameObject);
                Instantiate(exp, transform.position, transform.rotation);
            }
        }
    }
    private void InstantiateBullet()
    {
        bullet.transform.position = transform.position;
        Instantiate(bullet);
        

    }
}
