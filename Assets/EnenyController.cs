using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyController : MonoBehaviour
{
    Vector3 dir= Vector3.zero;//�ړ�����
    float speed = 5;//�ړ����x
    // Start is called before the first frame update
    void Start()
    {
        //����4�b
       Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����������
        dir = Vector3.left;

        //���ݒn�Ɉړ��ʂ����Z
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�������Ԃ��P�O�b���炷
        GameDirector.lastTime -= 10f;
        Destroy(gameObject);
    }
}