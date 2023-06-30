//-----------------------------------------------------------------
// �Q�[����ʂ̃X�N���[���V���b�g���B�e����
// Unity�G�f�B�^�ŎB�e����ꍇ�A�𑜓x�̓Q�[���r���[�̑傫���ƂȂ�
//-----------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    // �X�N���[���V���b�g��ۑ�����t�H���_��
    string folderName = "Screenshots";

    // �X�N���[���V���b�g�쐬���t���O
    bool isCreatingScreenShot = false;

    // �t�@�C���p�X
    string path;

    void Start()
    {
        // Application.dataPath�F
        // UnityEdita�̏ꍇ��Assets�t�H���_
        // exe �̏ꍇ�́A�v���W�F�N�g��_Data�t�H���_
        path = Application.dataPath + "/" + folderName + "/";
    }

    void Update()
    {
        // XBox�R���g���[���[�@���X�e�B�b�N�������݂ŃX�N���[���V���b�g�B�e
        if(Input.GetButtonDown("Enable Debug Button 1"))
        {
            PrintScreen();
        }
    }

    // ���̃��\�b�h���Ăяo���āA�R���[�`�����X�^�[�g������
    public void PrintScreen()
    {
        StartCoroutine("PrintScreenInternal");
    }

    // �X�N���[���V���b�g�쐬�R���[�`��
    IEnumerator PrintScreenInternal()
    {
        // �X�N���[���V���b�g�쐬���ł���΃R���[�`���I��
        if (isCreatingScreenShot)
        {
            yield break;
        }

        // �X�N���[���V���b�g�쐬���t���OON
        isCreatingScreenShot = true;

        // �P�t���[���ҋ@
        yield return null;

        // �w�肳�ꂽ�p�X�̃t�H���_��������΍쐬����
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        // �t�@�C��������t�ō쐬
        string date = DateTime.Now.ToString("yy-MM-dd_HH-mm-ss");
        string fileName = path + date + ".png";

        // �X�N���[���V���b�g���쐬���郁�\�b�h
        // �����F�t�@�C���p�X�t���t�@�C����
        ScreenCapture.CaptureScreenshot(fileName);

        // �X�N���[���V���b�g�̃t�@�C�����o���オ��܂őҋ@
        yield return new WaitUntil(() => File.Exists(fileName));

        // �X�N���[���V���b�g�쐬���t���O��OFF�ɂ���
        isCreatingScreenShot = false;
    }
}