using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallback : MonoBehaviour
{
    private Action greetingAction;              //¾×¼Ç ¼±¾ð 

    void Start()
    {
        greetingAction = SayHello;              //Action ÇÔ¼ö ÇÒ´ç
        PerformGreeting(greetingAction);
    }

    void SayHello()
    {
        Debug.Log("Hello, world!");
    }

    void PerformGreeting(Action greetingFunc)
    {
        greetingFunc?.Invoke();
    }
}