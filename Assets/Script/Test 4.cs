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
            Debug.Log("기타 연주 중 띵띵띵~");
        else
            Debug.Log("기타 연주 안하는 중...");

        if (age == 20)
            Debug.Log("대학교 신입생이군요!");
        else if (age >= 21)
            Debug.Log("대학교 신입생이 아니군요!");
        else
            Debug.Log("어린 친구");
    }
}
