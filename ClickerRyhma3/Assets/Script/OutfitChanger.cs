using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OutfitChanger : MonoBehaviour
{
    //Check mark for hats when buyed
    public GameObject check;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public GameObject check5;
    public GameObject check6;
    public GameObject check7;
    public GameObject check8;
    public GameObject check9;
    public GameObject check10;
    public GameObject check11;
    public GameObject check12;


    //public GameObject check13;
    //public GameObject check14;
    //public GameObject check15;
    //public GameObject check16;
    //public GameObject check17; 

    public GameObject check18;
    public GameObject check19;
    public GameObject check20;

    //Hats price text
    public Text shopText;
    public Text shopText2;
    public Text shopText3;
    public Text shopText4;
    public Text shopText5;
    public Text shopText6;
    public Text shopText7;
    public Text shopText8;
    public Text shopText9;
    public Text shopText10;
    public Text shopText11;
    public Text shopText12;

    //public Text shopText13;
    //public Text shopText14;
    //public Text shopText15;
    //public Text shopText16;
    //public Text shopText17;

    public Text shopText18;
    public Text shopText19;
    public Text shopText20;

    //Hats buyed
    bool hatIsBuy;
    bool hat2IsBuy;
    bool hat3IsBuy;
    bool hat4IsBuy;
    bool hat5IsBuy;
    bool hat6IsBuy;
    bool hat7IsBuy;
    bool hat8IsBuy;
    bool hat9IsBuy;
    bool hat10IsBuy;
    bool hat11IsBuy;
    bool hat12IsBuy;

    //bool hat13IsBuy;
    //bool hat14IsBuy;
    //bool hat15IsBuy;
    //bool hat16IsBuy;
    //bool hat17IsBuy;

    bool outfit18IsBuy;
    bool outfit19IsBuy;
    bool outfit20IsBuy;

    //Hat Buttons
    public Button pirateHat;
    public Button pirateHat2;
    public Button pirateHat3;
    public Button pirateHat4;
    public Button pirateHat5;
    public Button pirateHat6;
    public Button pirateHat7;
    public Button pirateHat8;
    public Button pirateHat9;
    public Button pirateHat10;
    public Button pirateHat11;
    public Button pirateHat12;

    //public Button pirateHat13;
    //public Button pirateHat14;
    //public Button prateHat15;
    //public Button pirateHat16;
    //public Button pirateHat17;

    public Button pirateOutfit18;
    public Button pirateOutfit19;
    public Button pirateOutfit20;

    //Hat Prices
    public int pirateHatPrice;
    public int pirateHat2Price;
    public int pirateHat3Price;
    public int pirateHat4Price;
    public int pirateHat5Price;
    public int pirateHat6Price;
    public int pirateHat7Price;
    public int pirateHat8Price;
    public int pirateHat9Price;
    public int pirateHat10Price;
    public int pirateHat11Price;
    public int pirateHat12Price;

    //public int pirateHat13Price;
    //public int pirateHat14Price;
    //public int pirateHat15Price;
    //public int pirateHat16Price;
    //public int pirateHat17Price;

    public int pirateOutfit18Price;
    public int pirateOutfit19Price;
    public int pirateOutfit20Price;


    [Header("Head")]
    public SpriteRenderer headPart;
    public List<Sprite> options = new List<Sprite>();

    [Header("Torso")]
    public SpriteRenderer torsoPart;
    public List<Sprite> torsoSprite = new List<Sprite>();

    [Header("Arms")]
    public SpriteRenderer leftArmPart;
    public SpriteRenderer rightArmPart;
    public List<Sprite> armSprite = new List<Sprite>();

    [Header("Legs")]
    public SpriteRenderer leftLegPart;
    public SpriteRenderer rightLegPart; 
    public List<Sprite> legsSprite = new List<Sprite>();


    void Start()
    {
        
    }

    public void PirateHat()
    {
        if(Manager.manager.currentScore >= pirateHatPrice && !hatIsBuy)
        {
            headPart.sprite = options[0];
            Manager.manager.currentScore -= pirateHatPrice;
            hatIsBuy = true;
            shopText.text = null;
            check.SetActive(true);
        }
        else if(hatIsBuy == true)
        {
            pirateHat.interactable = true;
            headPart.sprite = options[0];            
        }        
    }

    public void PirateHat2()
    {
        if (Manager.manager.currentScore >= pirateHat2Price && !hat2IsBuy)
        {
            headPart.sprite = options[1];
            Manager.manager.currentScore -= pirateHat2Price;
            hat2IsBuy = true;
            shopText2.text = null;
            check2.SetActive(true);
        }
        else if (hat2IsBuy == true)
        {
            pirateHat2.interactable = true;
            headPart.sprite = options[1];
        }
    }

    public void PirateHat3()
    {
        if (Manager.manager.currentScore >= pirateHat3Price && !hat3IsBuy)
        {
            headPart.sprite = options[2];
            Manager.manager.currentScore -= pirateHat3Price;
            hat3IsBuy = true;
            shopText3.text = null;
            check3.SetActive(true);
        }
        else if (hat3IsBuy == true)
        {
            pirateHat3.interactable = true;
            headPart.sprite = options[2];
        }
    }

    public void PirateHat4()
    {
        if (Manager.manager.currentScore >= pirateHat4Price && !hat4IsBuy)
        {
            headPart.sprite = options[3];
            Manager.manager.currentScore -= pirateHat4Price;
            hat4IsBuy = true;
            shopText4.text = null;
            check4.SetActive(true);
        }
        else if (hat4IsBuy == true)
        {
            pirateHat4.interactable = true;
            headPart.sprite = options[3];
        }
    }

    public void PirateHat5()
    {
        if (Manager.manager.currentScore >= pirateHat5Price && !hat5IsBuy)
        {
            headPart.sprite = options[4];
            Manager.manager.currentScore -= pirateHat5Price;
            hat5IsBuy = true;
            shopText5.text = null;
            check5.SetActive(true);
        }
        else if (hat5IsBuy == true)
        {
            pirateHat5.interactable = true;
            headPart.sprite = options[4];
        }
    }

    public void PirateHat6()
    {
        if (Manager.manager.currentScore >= pirateHat6Price && !hat6IsBuy)
        {
            headPart.sprite = options[5];
            Manager.manager.currentScore -= pirateHat6Price;
            hat6IsBuy = true;
            shopText6.text = null;
            check6.SetActive(true);
        }
        else if (hat6IsBuy == true)
        {
            pirateHat6.interactable = true;
            headPart.sprite = options[5];
        }
    }

    public void PirateHat7()
    {
        if (Manager.manager.currentScore >= pirateHat7Price && !hat7IsBuy)
        {
            headPart.sprite = options[6];
            Manager.manager.currentScore -= pirateHat7Price;
            hat7IsBuy = true;
            shopText7.text = null;
            check7.SetActive(true);
        }
        else if (hat7IsBuy == true)
        {
            pirateHat7.interactable = true;
            headPart.sprite = options[6];
        }
    }

    public void PirateHat8()
    {
        if (Manager.manager.currentScore >= pirateHat8Price && !hat8IsBuy)
        {
            headPart.sprite = options[7];
            Manager.manager.currentScore -= pirateHat8Price;
            hat8IsBuy = true;
            shopText8.text = null;
            check8.SetActive(true);
        }
        else if (hat8IsBuy == true)
        {
            pirateHat8.interactable = true;
            headPart.sprite = options[7];
        }
    }

    public void PirateHat9()
    {
        if (Manager.manager.currentScore >= pirateHat9Price && !hat9IsBuy)
        {
            headPart.sprite = options[8];
            Manager.manager.currentScore -= pirateHat9Price;
            hat9IsBuy = true;
            shopText9.text = null;
            check9.SetActive(true);
        }
        else if (hat9IsBuy == true)
        {
            pirateHat9.interactable = true;
            headPart.sprite = options[8];
        }
    }

    public void PirateHat10()
    {
        if (Manager.manager.currentScore >= pirateHat10Price && !hat10IsBuy)
        {
            headPart.sprite = options[9];
            Manager.manager.currentScore -= pirateHat10Price;
            hat10IsBuy = true;
            shopText10.text = null;
            check10.SetActive(true);
        }
        else if (hat10IsBuy == true)
        {
            pirateHat10.interactable = true;
            headPart.sprite = options[9];
        }
    }

    public void PirateHat11()
    {
        if (Manager.manager.currentScore >= pirateHat11Price && !hat11IsBuy)
        {
            headPart.sprite = options[10];
            Manager.manager.currentScore -= pirateHat11Price;
            hat11IsBuy = true;
            shopText11.text = null;
            check11.SetActive(true);
        }
        else if (hat11IsBuy == true)
        {
            pirateHat11.interactable = true;
            headPart.sprite = options[10];
        }
    }

    public void PirateHat12()
    {
        if (Manager.manager.currentScore >= pirateHat12Price && !hat12IsBuy)
        {
            headPart.sprite = options[11];
            Manager.manager.currentScore -= pirateHat12Price;
            hat12IsBuy = true;
            shopText12.text = null;
            check12.SetActive(true);
        }
        else if (hat12IsBuy == true)
        {
            pirateHat12.interactable = true;
            headPart.sprite = options[11];
        }
    }

    public void PirateOutfit()
    {
        if (Manager.manager.currentScore >= pirateOutfit18Price && !outfit18IsBuy)
        {
            torsoPart.sprite = torsoSprite[0];
            Manager.manager.currentScore -= pirateOutfit18Price;
            outfit18IsBuy = true;
            shopText18.text = null;
            check18.SetActive(true);
        }
        else if (outfit18IsBuy == true)
        {
            pirateOutfit18.interactable = true;
            torsoPart.sprite = torsoSprite[0];
        }        
    }

    public void PirateOutfit2()
    {
        if (Manager.manager.currentScore >= pirateOutfit19Price && !outfit19IsBuy)
        {
            torsoPart.sprite = torsoSprite[1];
            Manager.manager.currentScore -= pirateOutfit19Price;
            outfit19IsBuy = true;
            shopText19.text = null;
            check19.SetActive(true);
        }
        else if (outfit19IsBuy == true)
        {
            pirateOutfit19.interactable = true;
            torsoPart.sprite = torsoSprite[1];
        }
    }

    public void PirateOutfit3()
    {
        if (Manager.manager.currentScore >= pirateOutfit20Price && !outfit20IsBuy)
        {
            torsoPart.sprite = torsoSprite[2];
            Manager.manager.currentScore -= pirateOutfit20Price;
            outfit20IsBuy = true;
            shopText20.text = null;
            check20.SetActive(true);
        }
        else if (outfit20IsBuy == true)
        {
            pirateOutfit20.interactable = true;
            torsoPart.sprite = torsoSprite[2];
        }
    }

    void Interactables()
    {
        if(Manager.manager.currentScore >= pirateHatPrice)
        {
            pirateHat.interactable = true;
        }
        else
        {
            pirateHat.interactable = false;
        }
    }
}
