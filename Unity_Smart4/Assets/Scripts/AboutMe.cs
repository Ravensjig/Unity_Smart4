using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMe : MonoBehaviour
{
    private string name = "CGL";
    private int age = 25;
    private float height = 1.68f;

    private void Start()
    {
        SelfIntroduction();
        SelfIntroduction(name, age);
    }
    public void SelfIntroduction()
    {
        Debug.Log("Hello, I'm " + name + ", I'm " + age + " years old and my height is " + height + " meters.");
        Debug.Log($"Hello, I'm {name}, I'm {age} years old and my height is {height} meters.");
    }
    public void SelfIntroduction(string name, int age)
    {
        Debug.Log($"Hello, I'm {name}, I'm {age} years old.");
        Debug.Log($"Hello, I'm {name}, I'm {age} years old.");)
    }
}
