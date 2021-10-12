using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{

    public float currentScore;
    public int upgrades;


    public PlayerData (PlayerData player)
    {
        currentScore = player.currentScore;
        upgrades = player.upgrades;
    }
}
