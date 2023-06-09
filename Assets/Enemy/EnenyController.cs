using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyController : MonoBehaviour
{
    Vector3 dir= Vector3.zero;//移動方向
    float speed = 5;//移動速度
    public Animator exp;
   
    // Start is called before the first frame update
    void Start()
    {
       
        //寿命4秒
       Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //移動方向を決定
        dir = Vector3.left;

        //現在地に移動量を加算
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            //制限時間を１０秒減らす
            GameDirector.lastTime -= 10f;
            Destroy(gameObject);
        }
        else if  (collision.CompareTag("Fire") == true)
            {
                
                Destroy(gameObject);
            Instantiate(exp, transform.position,transform.rotation);
            }
    }
}
