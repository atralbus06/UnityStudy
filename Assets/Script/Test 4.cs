using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    [SerializeField] bool isPlayGuitar;
    [SerializeField] int age;

    void Start()
    {
        if (isPlayGuitar)
            Debug.Log("��Ÿ ���� �� ����~");
        else
            Debug.Log("��Ÿ ���� ���ϴ� ��...");

        if (age == 20)
            Debug.Log("���б� ���Ի��̱���!");
        else if (age >= 21)
            Debug.Log("���б� ���Ի��� �ƴϱ���!");
        else
            Debug.Log("� ģ��");
    }
}
