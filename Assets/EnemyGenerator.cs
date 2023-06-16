using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre; //“G‚ÌƒvƒŒƒnƒu‚ğ•Û‘¶‚·‚é•Ï”
    public GameObject enemyPs;
    float deltime;//Œo‰ßŠÔŒvZ—p
    float span;//“G‚ğo‚·ŠÔŠu(•b)
    int Spspan;
    // Start is called before the first frame update
    void Start()
    {
        deltime = 0;
        span = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Spspan =Random.Range(10,0);
        
        
        
        //Œo‰ßŠÔ‚ğ‰ÁZ
        if (Spspan <3)
            
        enemySpspan();
        else
            enemyspan();
        deltime += Time.deltaTime;

    }
    void enemyspan()
    {


        if (deltime > span)
        {
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-5f, 6f);
            go.transform.position = new Vector3(10, py, 0);

            //ŠÔŒo‰ß‚ğ•Û‘¶‚µ‚Ä‚¢‚é•Ï”‚ğ‚OƒNƒŠƒA‚·‚é
            deltime = 0;

            //“G‚ğo‚·ŠÔŠu‚ğ™X‚É’Z‚­‚·‚é
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
    void enemySpspan()
    {
        if (deltime > span)
        {
            GameObject go = Instantiate(enemyPs);
            float py = Random.Range(-5f, 6f);
            go.transform.position = new Vector3(10, py, 0);

            //ŠÔŒo‰ß‚ğ•Û‘¶‚µ‚Ä‚¢‚é•Ï”‚ğ‚OƒNƒŠƒA‚·‚é
            deltime = 0;

            //“G‚ğo‚·ŠÔŠu‚ğ™X‚É’Z‚­‚·‚é
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
}
