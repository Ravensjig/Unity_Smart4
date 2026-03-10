using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfScript : MonoBehaviour
{
    public int playergold;
    
    public int potion;

    void Angry()
    {
        Debug.Log("He is angry.");
    }
    // Start is called before the first frame update
    void Start()
    {
        if(200 <= playergold)
        {
        playergold -= 200;
        potion += 1;
        Debug.Log("You bought a potion.");
            Debug.Log("You have" + playergold + "gold left.");
            Debug.Log("You have" + potion + "potions.");
        }
        else if (100 <= playergold)    // 만약, 나의 소지금이이 100골드 이상이면,
        {
            playergold -= 100;          // 100 골드를 지불합니다.
            potion++;               // 포션을 구매합니다.
            Debug.Log("You bought a potion.");
            Debug.Log("You have" + playergold + "gold left.");
            Debug.Log("You have" + potion + "potions.");
        }
        else                        // 아니면,
        {
            Angry();
            Debug.Log("You couldn't afford a potion.");           
            Debug.Log("You have" + playergold + "gold left.");
            Debug.Log("You have" + potion + "potions.");
        }
    }

}
