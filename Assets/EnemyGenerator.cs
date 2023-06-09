using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre; //敵のプレハブを保存する変数
    float deltime;//経過時間計算用
    float span;//敵を出す間隔(秒)
    // Start is called before the first frame update
    void Start()
    {
        deltime = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間を加算
        deltime += Time.deltaTime;
       
        if (deltime>span)
        {
            GameObject go=Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10,py,0);

            //時間経過を保存している変数を０クリアする
            deltime = 0;

            //敵を出す間隔を徐々に短くする
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
}
