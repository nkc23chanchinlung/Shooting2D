using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y =Input.GetAxisRaw ("Vertical");


        transform.position+=dir.normalized*speed*Time.deltaTime;
        if (dir.y == 0)
        {
            anime.Play("Player");
        }
        else if(dir.y== -1)
        {
            anime.Play("PlayerR");
        }
        else
        {
            anime.Play("PlayerL");
        }

        Vector3 pos=transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position=pos;
    }
}
