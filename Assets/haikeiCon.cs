using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikeiCon : MonoBehaviour
{
    Vector3 loop;
    Vector3 dir=Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loop = transform.position;
        transform.position += new Vector3(-0.05f, 0, 0);

        if (loop.x <= -20.1f)
        {
            transform.position = new Vector3(20.1f, 0, 0);
        }
        
    }
}
