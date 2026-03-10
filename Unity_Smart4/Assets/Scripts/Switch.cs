using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int playergold;
    public int RedPotion;
    public int YellowPotion;
    public int BluePotion;
    // Start is called before the first frame update
    void Start()
    {
        string wish = "빨간 포션";

            switch (wish)
        {
            case "빨간 포션":
                playergold -= 200;
                RedPotion++;
                break;

            case "노란 포션":
                playergold -= 150;
                YellowPotion++;
                break;
            case "파란 포션":
                playergold -= 100;
                BluePotion++;
                break;
            default:
                break;
        }
        Debug.Log($"남은 골드 : {playergold} / R : {RedPotion} / Y : {YellowPotion} / B : {BluePotion}");

        // Update is called once per frame
      
    }
}
