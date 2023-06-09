using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre; //�G�̃v���n�u��ۑ�����ϐ�
    float deltime;//�o�ߎ��Ԍv�Z�p
    float span;//�G���o���Ԋu(�b)
    // Start is called before the first frame update
    void Start()
    {
        deltime = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ��Ԃ����Z
        deltime += Time.deltaTime;
       
        if (deltime>span)
        {
            GameObject go=Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10,py,0);

            //���Ԍo�߂�ۑ����Ă���ϐ����O�N���A����
            deltime = 0;

            //�G���o���Ԋu�����X�ɒZ������
            span -= (span > 0.5f) ? 0.01f : 0f;
        }
    }
}
