using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject HpItem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameDirector.kyorii%500==0)   
        {
            GameObject it = Instantiate(HpItem);
            float py = Random.Range(5f, -6f);
            it.transform.position = new Vector3(py, 10, 0);
        }
    }
    
}
