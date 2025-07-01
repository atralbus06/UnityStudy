using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 20;
    float height = 172f;
    string myName = "장성보";
    bool canPlayGuitar = false;

    void Start()
    {
        Debug.Log("저의 이름은 " + myName + "입니다.");
        Debug.Log("저의 나이는 " + age + "입니다.");
        Debug.Log("저의 키는 " + height + "입니다.");
        Debug.Log("저의 기타 연주 여부는 " + canPlayGuitar + "입니다.");
    }
}
