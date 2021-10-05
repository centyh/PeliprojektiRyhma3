using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager manager;
    private Animator anim;

    [SerializeField] GameObject coinPrefab;

    //LUCKY HIT 
    public float target = 0.05f;
    public float luckyHitInc = 0.01f;

    //CLICKER
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;


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

    public Text clickCastleCost;
    public int clickCastlePrice;

    public Text clickFarmCost;
    public int clickFarmPrice;

    public Text clickMineCost;
    public int clickMinePrice;

    public Text clickTowerCost;
    public int clickTowerPrice;

    public Text afkLabCost;
    public int afkLabPrice;

    //AMOUNT
    public Text clickDmgStatText;
    public int clickDmgStat;

    public Text autoClickStatText;
    public int autoClickStat;
    public float autoClickPerSecond;

    public Text luckyHitText;
    public int luckyHitStat;

    //BUTTONS
    public Button clickDmgButton;
    public Button autoclickButton;
    public Button moreClickDmgButton;
    public Button clickFactoryButton;
    public Button luckyHitButton;
    public Button abilityUpgradeButton;
    public Button clickCastleButton;
    public Button clickFarmButton;
    public Button clickMineButton;
    public Button clickTowerButton;
    public Button afkLabButton;

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
        anim = GetComponent<Animator>();

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
        clickCastleButton.interactable = false;
        clickFarmButton.interactable = false;
        clickMineButton.interactable = false;
        clickTowerButton.interactable = false;
        afkLabButton.interactable = false;
    }


    void Update()
    {
        //SCORE

        //CLICKER
        scoreText.text = (int)currentScore + " ";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //UPGRADES
        autoClickCost.text = "Cost: " + autoClickPrice;

        clickDmgCost.text = "Cost: " + clickDmgPrice;

        luckyHitCost.text = "Cost: " + luckyHitPrice;
        luckyHitText.text = "Lucky Hit Chance: " + target * 100 + "%";

        clickDmgStatText.text = "Click Damage: " + clickDmgStat;

        autoClickStatText.text = "Auto Click: " + autoClickStat + "/second";

        moreClickDmgCost.text = "Cost: " + moreClickDmgPrice;

        abilityButtonCost.text = "Cost: " + abilityButtonPrice;

        clickFactoryCost.text = "Cost: " + clickFactoryPrice;

        clickCastleCost.text = "Cost: " + clickCastlePrice;

        clickFarmCost.text = "Cost: " + clickFarmPrice;

        clickMineCost.text = "Cost: " + clickMinePrice;

        clickTowerCost.text = "Cost: " + clickTowerPrice;

        afkLabCost.text = "Cost: " + afkLabPrice;

        if(currentScore > 1000)
        {
            scoreText.text = (currentScore / 1000).ToString("F1") + "k";
        }

        InteractableButtons();
    }


    public void Hit()
    {
        CoinPopUp();


        float randValue;

        randValue = Random.value;

        if (randValue < (1f - target))
        {
            currentScore += hitPower + GetComponent<Boosts>().addedBoostAmount;
        }
        else
        {
            Debug.Log("LUCKY HIT");
            currentScore += (hitPower + GetComponent<Boosts>().addedBoostAmount) * 1.5f;
            return;
        }
    }

    public void LuckyHitUpgrade()
    {
        if(currentScore >= luckyHitPrice)
        {
            target += luckyHitInc;
            currentScore -= luckyHitPrice;
            luckyHitPrice = luckyHitPrice * 2;
            Debug.Log("lucky hit chance" + target);
        }
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
            abilityUpgradeButton.interactable = false;
        }
    }

    public void ClickCastleUpgrade()
    {
        if(currentScore >= clickCastlePrice)
        {
            clickDmgStat += 15;
            autoClickStat += 15;
            hitPower += 15;
            x += 15;
            currentScore -= clickCastlePrice;
            clickCastlePrice += 10000;
        }
    }

    public void ClickFarmUpgrade()
    {
        if(currentScore >= clickFarmPrice)
        {
            clickDmgStat += 20;
            autoClickStat += 20;
            hitPower += 20;
            x += 20;
            currentScore -= clickFarmPrice;
            clickFarmPrice += 20000;
        }
    }

    public void ClickMineUpgrade()
    {
        if(currentScore >= clickMinePrice)
        {
            clickDmgStat += 30;
            autoClickStat += 30;
            hitPower += 30;
            x += 30;
            currentScore -= clickMinePrice;
            clickMinePrice += 30000;
        }
    }

    public void ClickTowerUpgrade()
    {
        if(currentScore >= clickTowerPrice)
        {
            clickDmgStat += 50;
            autoClickStat += 50;
            hitPower += 50;
            x += 50;
            currentScore -= clickTowerPrice;
            clickTowerPrice += 50000;
        }
    }

    public void AfkLabUpgrade()
    {
        if(currentScore >= afkLabPrice)
        {
            autoClickStat += 100;
            x += 100;
            currentScore -= afkLabPrice;
            afkLabPrice += 75000;
        }
    }

    public void CoinPopUp()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 2.0f;
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(coinPrefab, objectPos, Quaternion.identity);
        anim.SetTrigger("OnClick");
        
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
        //Click Castle
        if(currentScore >= clickCastlePrice)
        {
            clickCastleButton.interactable = true;
        }
        else
        {
            clickCastleButton.interactable = false;
        }
        //Click Farm
        if (currentScore >= clickFarmPrice)
        {
            clickFarmButton.interactable = true;
        }
        else
        {
            clickFarmButton.interactable = false;
        }
        //Click Mine
        if (currentScore >= clickMinePrice)
        {
            clickMineButton.interactable = true;
        }
        else
        {
            clickMineButton.interactable = false;
        }
        //Click Tower
        if (currentScore >= clickTowerPrice)
        {
            clickTowerButton.interactable = true;
        }
        else
        {
            clickTowerButton.interactable = false;
        }
        //AFK Lab
        if(currentScore >= afkLabPrice)
        {
            afkLabButton.interactable = true;
        }
        else
        {
            afkLabButton.interactable = false;
        }
    }
}
 