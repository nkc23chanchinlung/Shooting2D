using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre; //敵のプレハブを保存する変数
    public GameObject enemyPs;
    float deltime;//経過時間計算用
    float span;//敵を出す間隔(秒)
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
        
        
        
        //経過時間を加算
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

            //時間経過を保存している変数を０クリアする
            deltime = 0;

            //敵を出す間隔を徐々に短くする
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

            //時間経過を保存している変数を０クリアする
            deltime = 0;

            //敵を出す間隔を徐々に短くする
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
}
