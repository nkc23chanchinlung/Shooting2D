using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCon : MonoBehaviour
{
    AudioSource audioS;
    AudioClip audioC;
    

     AudioClip seC;
     Vector3 seP;
    // Start is called before the first frame update
    void Start()
    {
        seC = Resources.Load<AudioClip>("Audio/SE/Boom");
        seP=GameObject.Find("Main Camera").transform.position;   
        
        audioS=GetComponent<AudioSource>();
        audioS.clip = seC;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) 
        {
        AudioSource.PlayClipAtPoint(seC, seP);
        }
    }
}
