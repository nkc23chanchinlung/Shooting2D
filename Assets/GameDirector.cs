using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text Kyori;//距離を表示するUI-Textオブジェクト
    public static int kyorii;
    public static float lastTime; //残り時間を保存する変数

    public Image Timegauge;

    // Start is called before the first frame update
    void Start()
    {
        kyorii = 0;

        lastTime = 100f;//残り時間100秒
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;

        //残り時間が０になったらリロード
        if(lastTime < 0)
        {
            SceneManager.LoadScene(0);
        }
       
        kyorii++;
        Kyori.text = "時間:"+kyorii.ToString("D6");
        Timegauge.fillAmount = lastTime/100f;

        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene(0);
        }
    }
}
