using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    void Start()
    {
        int[] numArr = new int[3];
        numArr[0] = 1;
        numArr[1] = 3;
        numArr[2] = 5;
        for (int i = 0; i < numArr.Length; i++)
            Debug.Log("NumArr[" + i + "] = " + numArr[i]);
    }
}
