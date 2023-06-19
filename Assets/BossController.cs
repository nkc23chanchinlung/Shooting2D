using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject bullet;
    float ugo;
    //public GameObject Boss;
    float speed;
    float timer;
    float but;
    public static int Hp;
    
    Vector3 dir = Vector3.zero;
    Renderer col;
    // Start is called before the first frame update
    void Start()
    {
        Hp = 15;
        col=GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
         but += Time.deltaTime;
        Invoke("InstantiateBullet", 1f);

        speed = 0.2f;
        
        timer+=Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -5f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        if (timer >= 0.5f)
        {
            ugo = Random.Range(1, 7);
            timer = 0;
        }
        switch(ugo)
        {
            
            case 1:
                transform.position += new Vector3(speed, 0, 0);
                
                break; 
                case 2:
                transform.position += new Vector3(-speed, 0, 0);
                
                break;
                case 3:
                transform.position += new Vector3(0, speed, 0);
                break;
            case 4:
                transform.position += new Vector3(0, -speed, 0);
                break;
                case 5:
                transform.position += new Vector3(speed, speed, 0);
                break;
                case 6:
                transform.position += new Vector3(-speed, -speed, 0);
                break;


        }

    }
    private void InstantiateBullet()
    {
        
        bullet.transform.position = transform.position;
        if (but > 0.5)
        {
            
            Instantiate(bullet);
            but = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //êßå¿éûä‘ÇÇPÇOïbå∏ÇÁÇ∑
        if (collision.CompareTag("Player") == true)
        {
            GameDirector.lastTime -= 15f;
            
            Hp--;
            
        }
        else if (collision.CompareTag("Fire") == true)
        {
            Hp--;
            col.material.color = Color.red;
            Invoke("ResetColor", 0.5f);
            
            if (Hp <= 0)
            {
                
                Destroy(gameObject);
            }
        }
    }
    void ResetColor()
    {
        col.material.color = Color.white;
    }
    }
