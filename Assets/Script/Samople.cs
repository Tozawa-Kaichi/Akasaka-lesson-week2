using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samople : MonoBehaviour
{
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World",this);
        
        var x = 10;
        var y = 20;

        // + ���Z�q�ŕ����񌋍�
        Debug.Log("x=" + x + ", y=" + y);

        // $ �L���ɂ���ԕ�����
        Debug.Log($"x={x}, y={y}");


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Hairetu()
    {
        // ���z��^�ϐ��錾
        // �v�f�^[] �ϐ���;
        //int[] iAry;

        // ���z��̐���
        // new �v�f�^[�v�f��];
        //iAry = new int[3]; // �z�񐶐��ƕϐ��ւ̕ۑ�

        // �z��v�f�ւ̃A�N�Z�X
        //iAry[0] = 10;
        //iAry[1] = 20;
        //iAry[2] = 30;

        //Debug.Log($"iAry[0]={iAry[0]}");
        //Debug.Log($"iAry[1]={iAry[1]}");
        //Debug.Log($"iAry[2]={iAry[2]}");

        // ���z�񏉊����q
        // �z����ϐ��ƕ��@�I�ɂ͓����錾�Ɠ����ɏ������ł���B
        // �z����쐬����Ɠ����ɗv�f��ݒ�ł���B
        // new �v�f�^[�v�f��] { �v�f1, �v�f2, �v�f3, ... }
        // var iAry = new int[3] { 10, 20, 30 };

        // �����l����v�f���ƌ^�𐄘_�ł���ꍇ
        // new �̌�̌^�Ɨv�f�����ȗ��\�B
        var iAry = new[] { 10, 20, 30, 40, 50 };

        // Lengh �v���p�e�B�A�z��̗v�f�����擾����
        Debug.Log($"iAry.Length={iAry.Length}");

        // for ���ɂ��z��A�N�Z�X
        for (var i = 0; i < iAry.Length; i++)
        {
            Debug.Log($"iAry[{i}]={iAry[i]}");
        }

        // foreach ���ɂ��z�񏈗�
        foreach (var e in iAry)
        {
            Debug.Log($"e={e}");
        }
    }
}
