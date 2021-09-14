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

    public float luckyHitChance;


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

    public Text moreClickDmgText;
    public Text moreClickDmgCost;
    public int moreClickDmgPrice;

    public Text clickFactoryText;
    public Text clickFactoryCost;
    public int clickFactoryPrice;


    //AMOUNT
    public Text clickDmgStatText;
    public int clickDmgStat;

    public Text autoClickStatText;
    public int autoClickStat;
    public float autoClickPerSecond;




    private void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
        clickDmgStat = 1;
        
    }


    void Update()
    {
        //CLICKER
        scoreText.text = (int)currentScore + " ";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //UPGRADES
        autoClickCost.text = "Cost: " + autoClickPrice + " ";

        clickDmgCost.text = "Cost: " + clickDmgPrice + " ";

        luckyHitCost.text = "Cost: " + luckyHitPrice + " ";

        clickDmgStatText.text = "Click Damage: " + clickDmgStat;

        autoClickStatText.text = "Auto Click: " + autoClickStat + "/second";

        moreClickDmgCost.text = "Cost: " + moreClickDmgPrice;


    }

    public void Hit()
    {
        currentScore += hitPower;
        LuckyHit();
    }

    public void AutoClickUpgrade()
    {
        if(currentScore >= autoClickPrice)
        {
            autoClickStat += 1;
            currentScore -= autoClickPrice;
            x += 1;
            autoClickPrice += 75;
        }
    }

    public void ClickDamageUpgrade()
    {
        if(currentScore >= clickDmgPrice)
        {
            clickDmgStat += 1;
            currentScore -= clickDmgPrice;
            hitPower += 1;
            clickDmgPrice += 25;
        }
    }

    public void MoreClickDamage()
    {
        if(currentScore >= moreClickDmgPrice)
        {
            clickDmgStat += 3;
            hitPower += 3;
            currentScore -= moreClickDmgPrice;
            moreClickDmgPrice += 250;
        }
    }

    public void ClickFactoryUpgrade()
    {
        if(currentScore >= clickFactoryPrice)
        {
            clickDmgStat += 5;
            autoClickStat += 5;
            hitPower += 5;
            x += 5;
            currentScore -= clickFactoryPrice;
            clickFactoryPrice += 2500;
        }
    }

    public void LuckyHit()
    {
        if(Random.value <= .10f)
        {
            luckyHitChance = hitPower * 5;
            Debug.Log("LUCKY CLICK");
            return;
        }
    }

}
 