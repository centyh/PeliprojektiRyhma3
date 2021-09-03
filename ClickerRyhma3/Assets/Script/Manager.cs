using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //CLICKER
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;


    //bool hasUpgrade;
    //public int autoClicksPerSecond;     // To add amount for autoclicks per seconds
    //public int minimumClicksToUnlockUpgrade; //  How many clicks to unlock the upgrade

    //UPGRADES
    public Text autoClickText;
    public Text autoClickCost;
    public int autoClickPrice;

    public Text clickDmgText;
    public Text clickDmgCost;
    public int clickDmgPrice;

    public Text luckyHitText;
    public Text luckyHitCost;
    public int luckyHitPrice;



    private void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
    }

    //public void AddClicks()
    //{
    //    TotalClicks++;      // Add Score to the text when clicking button
    //    ClicksTotalText.text = TotalClicks.ToString("0");       // It shows the text no desimal only full numbers
    //}

    //public void AutoClickUpgrade()
    //{
    //    if (!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
    //    {
    //        TotalClicks -= minimumClicksToUnlockUpgrade;        // Subract from the score when using upgrade
    //        hasUpgrade = true;
    //    }
    //}

    private void Update()
    {
        //if (hasUpgrade)
        //{
        //    TotalClicks += autoClicksPerSecond * Time.deltaTime;

        //    ClicksTotalText.text = TotalClicks.ToString("0");   // Update the score
        //}
        //CLICKER
        scoreText.text = (int)currentScore + " ";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //UPGRADES
        autoClickCost.text = "Cost: " + autoClickPrice + " ";

        clickDmgCost.text = "Cost: " + clickDmgPrice + " ";

        luckyHitCost.text = "Cost: " + luckyHitPrice + " ";
        

    }

    public void Hit()
    {
        currentScore += hitPower;
    }

    public void AutoClickUpgrade()
    {
        if(currentScore >= autoClickPrice)
        {
            currentScore -= autoClickPrice;
            x += 1;
            autoClickPrice += 75;
        }
    }

    public void ClickDamageUpgrade()
    {
        if(currentScore >= clickDmgPrice)
        {
            currentScore -= clickDmgPrice;
            hitPower += 1;
            clickDmgPrice += 25;
        }
    }

    public void LuckyHitUpgrade()
    {

    }
}
