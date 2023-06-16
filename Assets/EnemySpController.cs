using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemySpController : MonoBehaviour
{
    float speed;
    int Hp;

    public GameObject bullet;
    Vector3 dir = Vector3.zero;
    
    void Start()
    {
        Hp = 2;
        speed = 5f;


        //����8�b
        Destroy(gameObject, 8f);
        Invoke("InstantiateBullet", 1f);
       
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����������
        dir = Vector3.left;
        dir.y=2f*Mathf.Sin(Time.time*5f);

        //���ݒn�Ɉړ��ʂ����Z
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�������Ԃ��P�O�b���炷
        if (collision.CompareTag("Player") == true)
        {
            GameDirector.lastTime -= 15f;
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Fire") == true)
        {
            Hp --;
            Debug.Log(Hp);
            if (Hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    private void InstantiateBullet()
    {
        bullet.transform.position = transform.position;
        Instantiate(bullet);
        

    }
}
