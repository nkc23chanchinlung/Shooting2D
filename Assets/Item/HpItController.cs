using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItController : MonoBehaviour
{
    Renderer col;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag=="Player")
        {
            Destroy(gameObject);
            GameDirector.lastTime += 10f;
        }
    }
}
