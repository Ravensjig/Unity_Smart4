using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGatchaScript : MonoBehaviour
{
    private int Outcome;
    public string SelectedGatcha = "GatchaA";
    

    void GatchaA()
    {
        if (Outcome <= 5)
        {
            Debug.Log("You got a S rank Character : {SelectedGatcha}");
        }
        else if (Outcome <= 20)
        {
            Debug.Log("You got a A rank Character");
        }
        else if (Outcome <= 50)
        {
            Debug.Log("You got a B rank Character");
        }
        else
        {
            Debug.Log("You got a C rank Character");
        }
    }
    void GatchaB()
    {
        if (Outcome <= 5)
        {
            Debug.Log("You got a S rank Character : {SelectedGatcha}");
        }
        else if (Outcome <= 20)
        {
            Debug.Log("You got a A rank Character");
        }
        else if (Outcome <= 50)
        {
            Debug.Log("You got a B rank Character");
        }
        else
        {
            Debug.Log("You got a C rank Character");
        }
    }
    void GatchaC()
    {
        if (Outcome <= 5)
        {
            Debug.Log("You got a S rank Character : {SelectedGatcha}");
        }
        else if (Outcome <= 20)
        {
            Debug.Log("You got a A rank Character");
        }
        else if (Outcome <= 50)
        {
            Debug.Log("You got a B rank Character");
        }
        else
        {
            Debug.Log("You got a C rank Character");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        Outcome = Random.Range(1, 101);

        switch (SelectedGatcha)
        {
            case "GatchaA":
                Debug.Log("You selected GatchaA.");
                GatchaA();
                break;
            case "GatchaB":
                Debug.Log("You selected GatchaB.");
                GatchaB();
                break;
            case "GatchaC":
                Debug.Log("You selected GatchaC.");
                GatchaC();
                break;
        }
    }
}
         
        
    
