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
        int[] iAry;

        // ���z��̐���
        // new �v�f�^[�v�f��];
        iAry = new int[3]; // �z�񐶐��ƕϐ��ւ̕ۑ�

        // �z��v�f�ւ̃A�N�Z�X
        iAry[0] = 10;
        iAry[1] = 20;
        iAry[2] = 30;

        Debug.Log($"iAry[0]={iAry[0]}");
        Debug.Log($"iAry[1]={iAry[1]}");
        Debug.Log($"iAry[2]={iAry[2]}");
    }
}
