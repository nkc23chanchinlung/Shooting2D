using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre; //“G‚ÌƒvƒŒƒnƒu‚ð•Û‘¶‚·‚é•Ï”
    float deltime;//Œo‰ßŽžŠÔŒvŽZ—p
    float span;//“G‚ðo‚·ŠÔŠu(•b)
    // Start is called before the first frame update
    void Start()
    {
        deltime = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Œo‰ßŽžŠÔ‚ð‰ÁŽZ
        deltime += Time.deltaTime;
       
        if (deltime>span)
        {
            GameObject go=Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10,py,0);

            //ŽžŠÔŒo‰ß‚ð•Û‘¶‚µ‚Ä‚¢‚é•Ï”‚ð‚OƒNƒŠƒA‚·‚é
            deltime = 0;

            //“G‚ðo‚·ŠÔŠu‚ð™X‚É’Z‚­‚·‚é
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
}
