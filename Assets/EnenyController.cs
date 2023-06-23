using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyController : MonoBehaviour
{
    Vector3 dir= Vector3.zero;//ˆÚ“®•ûŒü
    float speed = 5;//ˆÚ“®‘¬“x
    public Animator exp;
   
    // Start is called before the first frame update
    void Start()
    {
       
        //õ–½4•b
       Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //ˆÚ“®•ûŒü‚ğŒˆ’è
        dir = Vector3.left;

        //Œ»İ’n‚ÉˆÚ“®—Ê‚ğ‰ÁZ
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            //§ŒÀŠÔ‚ğ‚P‚O•bŒ¸‚ç‚·
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
