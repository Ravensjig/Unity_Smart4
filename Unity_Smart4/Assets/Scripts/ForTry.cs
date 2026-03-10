using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ForTry : MonoBehaviour
{
    private int Outcome;
    private int PickupRoll;
    private int RandomIndex;
    List<string> Pickuplist = new List<string>();



    public string SelectedGatcha = "Gatcha1";
    void Gatcha()
    {
        Outcome = Random.Range(1, 101);
        if (Outcome <= 5)
        {
            // print "You got a pickup"
            RollamongstPickup();
        }
        else if (Outcome <= 20)
        {
            // print "You got a A rank Character"
        }
        else if (Outcome <= 50)
        {
            // print "You got a B rank Character"
        }
        else
        {
            // print "You got a C rank Character"
        }
    }

    void RollamongstPickup()
    {
        List<string> Pickuplist = new List<string>();
        Pickuplist.Add("Diabel");
        Pickuplist.Add("Star");
        Pickuplist.Add("Spinel");
        Pickuplist.Add("Cateyes");
        Pickuplist.Add("Sinnel");

        RandomIndex = Random.Range(0, Pickuplist.Count + 1);
        Pickuplist[RandomIndex];
    }

    void GatchaTenTiems()
    {
        for (int PullTry = 1; PullTry <= 10; PullTry++) 
        {
            Gatcha();
        }
    }
    void Start()
    {
    GatchaTenTiems();
    }
    void Update()
    {
        
    }
}



    // Update is called once per frame
  
















    // Start is called before the first frame update


