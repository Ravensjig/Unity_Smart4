using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        name = "¸ÞÅ¸¸ù";
        maxHP = 100;
        Debug.Log("Awake called");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called");
    }

    private void Start()
    {
        Debug.Log("Start called");
    }

    private void Update()
    {
        Debug.Log("Update called");
    }
    // Update is called once per frame

    private void OnDisable()
    {
        Debug.Log("OnDisable called");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy called");
    }
}