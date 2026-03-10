using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GatchaScript : MonoBehaviour
{
    private int Outcome;
    private int HalfCeiling = 0;
    void Gatcha()
    {
        if (Outcome <= 5)
        {
            HalfCeiling++;
            Debug.Log("You got a S rank item.");
        }
        else if (Outcome <= 20)
        {
            Debug.Log("You got a A rank item.");
        }
        else if (Outcome <= 50)
        {
            Debug.Log("You got an B rank item.");
        }
        else
        {
            Debug.Log("You got a C rank item.");
        }
       
    }
    void Start()
    {
        Outcome = Random.Range(1, 101);
        Gatcha();

    }
}