using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager manager;

    

    //CLICKER
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    public float luckyHitChance;


    //UPGRADES
    public Text autoClickCost;
    public int autoClickPrice;

    public Text clickDmgCost;
    public int clickDmgPrice;

    public Text luckyHitCost;
    public int luckyHitPrice;

    public Text moreClickDmgCost;
    public int moreClickDmgPrice;

    public Text clickFactoryCost;
    public int clickFactoryPrice;

    public Text abilityButtonCost;
    public int abilityButtonPrice;

    public GameObject abilityButton;

    //AMOUNT
    public Text clickDmgStatText;
    public int clickDmgStat;

    public Text autoClickStatText;
    public int autoClickStat;
    public float autoClickPerSecond;

    //BUTTONS
    public Button clickDmgButton;
    public Button autoclickButton;
    public Button moreClickDmgButton;
    public Button clickFactoryButton;
    public Button luckyHitButton;
    public Button abilityUpgradeButton;

    private void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else
        {
            Destroy(gameObject);
        }    
    }

    private void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
        clickDmgStat = 1;

        clickDmgButton.interactable = false;
        autoclickButton.interactable = false;
        moreClickDmgButton.interactable = false;
        clickFactoryButton.interactable = false;
        luckyHitButton.interactable = false;
        abilityUpgradeButton.interactable = false;
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

        abilityButtonCost.text = "Cost: " + abilityButtonPrice;

        clickFactoryCost.text = "Cost: " + clickFactoryPrice;


        InteractableButtons();
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

    public void AbilityButton()
    {
        if(currentScore >= abilityButtonPrice)
        {
            clickDmgStat += 5;
            autoClickStat += 5;
            hitPower += 5;
            x += 5;
            currentScore -= abilityButtonPrice;
            abilityButton.SetActive(true);
        }
    }






    public void InteractableButtons()
    {
        //BUTTON INTERACTABLES

        //Click Damage Button
        if (currentScore >= clickDmgPrice)
        {
            clickDmgButton.interactable = true;
        }
        else
        {
            clickDmgButton.interactable = false;
        }
        //AutoClick Button
        if (currentScore >= autoClickPrice)
        {
            autoclickButton.interactable = true;
        }
        else
        {
            autoclickButton.interactable = false;
        }
        //More Click Damage Button
        if (currentScore >= moreClickDmgPrice)
        {
            moreClickDmgButton.interactable = true;
        }
        else
        {
            moreClickDmgButton.interactable = false;
        }
        //Click Factory Button
        if (currentScore >= clickFactoryPrice)
        {
            clickFactoryButton.interactable = true;
        }
        else
        {
            clickFactoryButton.interactable = false;
        }
        //Lucky Hit Button
        if (currentScore >= luckyHitPrice)
        {
            luckyHitButton.interactable = true;
        }
        else
        {
            luckyHitButton.interactable = false;
        }
        //Ability Button
        if (currentScore >= abilityButtonPrice)
        {
            abilityUpgradeButton.interactable = true;
        }
        else
        {
            abilityUpgradeButton.interactable = false;
        }
    }
}
 