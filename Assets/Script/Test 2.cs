using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 20;
    float height = 172f;
    string myName = "�强��";
    bool canPlayGuitar = false;

    void Start()
    {
        Debug.Log("���� �̸��� " + myName + "�Դϴ�.");
        Debug.Log("���� ���̴� " + age + "�Դϴ�.");
        Debug.Log("���� Ű�� " + height + "�Դϴ�.");
        Debug.Log("���� ��Ÿ ���� ���δ� " + canPlayGuitar + "�Դϴ�.");
    }
}
