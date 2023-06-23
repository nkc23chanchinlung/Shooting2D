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
    public static float Hp;
    Transform player;
    GameObject Boss;
    float Hphill;
    
    
    Vector3 dir = Vector3.zero;
    Renderer col;
    // Start is called before the first frame update
    void Start()
    {
        Boss = GameObject.Find("EnemyBoss");
        Hp = 0;
        col = GetComponent<Renderer>();
        player = GameObject.Find("Player").transform;
        speed = 0.15f;

        Hphill = 0.1f;



    }

    // Update is called once per frame
    void Update()
    {
        if (GameDirector.kyorii >= 500)
        {
            bossderu();
           
        }
        if (Hp >= 15)
        {
            Hphill = 0;
        }

     

        
    }

    
     void ugokgi() //bossìÆÇ´ÉpÉ^Å[Éì
    {
            if (timer >= 1f)
            {
                ugo = Random.Range(1, 8);
                timer = 0;
            }
            switch (ugo)
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
                    case 7:
                transform.position += new Vector3(speed, 0, 0);
                //    transform.position += player.position - transform.position;
                break;
            }

        }
    


    private void InstantiateBullet()//íe
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
        if (GameDirector.kyorii >= 650)
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
    }
    void ResetColor()Å@//êFÉäÉZÉbÉg
    {
        col.material.color = Color.white;
    }
    void bossderu()
    {
        
        Hp += Hphill;
        
        
        
        Hp = (Hp > 15) ? 15 : Hp;
      

            for (int i = 0; i < 5; i++)
            {
               
                transform.position += Vector3.left * speed * 0.1f;
                
            }


        if (GameDirector.kyorii >= 650)
        {


            timer += Time.deltaTime;
            but += Time.deltaTime;
            Invoke("InstantiateBullet", 1f);



            timer += Time.deltaTime;

            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -5f, 9f);
            pos.y = Mathf.Clamp(pos.y, -4f, 4f);
            transform.position = pos;
            ugokgi();
        }


    }
}
    
