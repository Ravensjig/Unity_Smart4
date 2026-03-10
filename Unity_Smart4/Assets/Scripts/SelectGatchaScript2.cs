using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGatchaScript2 : MonoBehaviour
{
    private int Outcome;
    public string SelectedGatcha = "GatchaA";

    void Gatcha()
    {
        if (Outcome <= 5)
        {
            switch (SelectedGatcha)
            {
                case "GatchaA":
                    Debug.Log("You got a S rank Character : GatchaA");
                    break;
                case "GatchaB":
                    Debug.Log("You got a S rank Character : GatchaB");
                    break;
                case "GatchaC":
                    Debug.Log("You got a S rank Character : GatchaC");
                    break;
                default:
                    Debug.Log("Invalid Gatcha selected.");
                    break;
            }
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
        Debug.Log($"You selected {SelectedGatcha}.");
        Gatcha();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
