using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text Kyori;//������\������UI-Text�I�u�W�F�N�g
    int kyorii;
    public static float lastTime; //�c�莞�Ԃ�ۑ�����ϐ�

    public Image Timegauge;

    // Start is called before the first frame update
    void Start()
    {
        kyorii = 0;

        lastTime = 100f;//�c�莞��100�b
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;

        //�c�莞�Ԃ��O�ɂȂ����烊���[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }
       
        kyorii++;
        Kyori.text = "����"+kyorii.ToString("D6")+"M";
        Timegauge.fillAmount = lastTime/100f;
    }
}