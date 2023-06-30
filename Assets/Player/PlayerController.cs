using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    Animator anime;
    public GameObject Fireball;
    float timer;
    static public float speed = 5;

    int power;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        anime = GetComponent<Animator>();
        power = 3;
        speed = 5;

    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKeyUp(KeyCode.C)) 
        {
            power = (power + 1) % 13;
            Debug.Log(power);
        }

        timer += Time.deltaTime;
        
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");


        transform.position += dir.normalized * speed * Time.deltaTime;
        if (dir.y == 0)
        {
            anime.Play("Player");
        }
        else if (dir.y == -1)
        {
            anime.Play("PlayerR");
        }
        else
        {
            anime.Play("PlayerL");
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;



        if (Input.GetKey(KeyCode.Z) && timer > 0.5f)
        {
            //power = (power < 0) ? 0 : power;
            //for (int i = -power; i < power + 1; i++)
            //       {

            //    //        //プレイヤーの現在地をposに保存する
            //            Vector3 ipos = transform.position;

            //    //        //プレイヤーの回転角度を取得
            //    //        Vector3 r = transform.rotation.eulerAngles + new Vector3(15f * i,0 , 0);
            //    Quaternion rot = Quaternion.identity;   
            //  rot.eulerAngles=transform.rotation.eulerAngles+new Vector3(0,0,015f*i);

            //    //        //弾を生成する際に,プレイヤーの位置と角度をセット
            //    //        Instantiate(Fireball, ipos, rot);
            //    //
                
                Instantiate(Fireball);
            timer = 0f;
            }

        }

    }


