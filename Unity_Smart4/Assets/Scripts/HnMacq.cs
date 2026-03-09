using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int level;
    public int unilevel = level;
}

public class Monster
{
    private int level;

    public void SetLevel(int playerlevel)
    {
        level = playerlevel;
    }
}

public class Game
{
    Player player;
    Monster monster;

        public void Test()
    {
        monster .SetLevel(player.unilevel);

    }
}
