using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    void Start()
    {
        int num1 = 10;
        int num2 = 3;

        Debug.Log(num1 + " + " + num2 + " = " + (num1 + num2));
        Debug.Log(num1 + " - " + num2 + " = " + (num1 - num2));
        Debug.Log(num1 + " * " + num2 + " = " + (num1 * num2));
        Debug.Log(num1 + " / " + num2 + " = " + (num1 / num2));
        Debug.Log(num1 + " % " + num2 + " = " + (num1 % num2));

        string firstName = "SeongBo";
        string lastName = "Jang";
        string myName = firstName + " " + lastName;
        Debug.Log(myName);
    }
}
