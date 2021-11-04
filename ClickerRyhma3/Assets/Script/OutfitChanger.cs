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
    public GameObject check13;
    public GameObject check14;
    public GameObject check15;
    public GameObject check16;
    public GameObject check17;


    //Check mark for outfits when buyed

    public GameObject check18;
    public GameObject check19;
    public GameObject check20;
    public GameObject check21;
    public GameObject check22;
    public GameObject check23;
    public GameObject check24;
    public GameObject check25;
    public GameObject check26;
    public GameObject check27;
    public GameObject check28;
    public GameObject check29;
    public GameObject check34;
    public GameObject check35;
    public GameObject check36;
    public GameObject check37;
    public GameObject check38;


    //Check mark for pets when buyed

    public GameObject check30;
    public GameObject check31;
    public GameObject check32;
    public GameObject check33;

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
    public Text shopText13;
    public Text shopText14;
    public Text shopText15;
    public Text shopText16;
    public Text shopText17;


    //Outfit price text

    public Text shopText18;
    public Text shopText19;
    public Text shopText20;
    public Text shopText21;
    public Text shopText22;
    public Text shopText23;
    public Text shopText24;
    public Text shopText25;
    public Text shopText26;
    public Text shopText27;
    public Text shopText28;
    public Text shopText29;
    public Text shopText34;
    public Text shopText35;
    public Text shopText36;
    public Text shopText37;
    public Text shopText38;


    //Pets price text

    public Text shopText30;
    public Text shopText31;
    public Text shopText32;
    public Text shopText33;

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
    bool hat13IsBuy;
    bool hat14IsBuy;
    bool hat15IsBuy;
    bool hat16IsBuy;
    bool hat17IsBuy;


    //Outfit buyed

    bool outfit18IsBuy;
    bool outfit19IsBuy;
    bool outfit20IsBuy;
    bool outfit21IsBuy;
    bool outfit22IsBuy;
    bool outfit23IsBuy;
    bool outfit24IsBuy;
    bool outfit25IsBuy;
    bool outfit26IsBuy;
    bool outfit27IsBuy;
    bool outfit28IsBuy;
    bool outfit29IsBuy;
    bool outfit34IsBuy;
    bool outfit35IsBuy;
    bool outfit36IsBuy;
    bool outfit37IsBuy;
    bool outfit38IsBuy;


    //Pets buyed

    bool pet30IsBuy;
    bool pet31IsBuy;
    bool pet32IsBuy;
    bool pet33IsBuy;

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
    public Button pirateHat13;
    public Button pirateHat14;
    public Button pirateHat15;
    public Button pirateHat16;
    public Button pirateHat17;


    //Outfit Buttons

    public Button pirateOutfit18;
    public Button pirateOutfit19;
    public Button pirateOutfit20;
    public Button pirateOutfit21;
    public Button pirateOutfit22;
    public Button pirateOutfit23;
    public Button pirateOutfit24;
    public Button pirateOutfit25;
    public Button pirateOutfit26;
    public Button pirateOutfit27;
    public Button pirateOutfit28;
    public Button pirateOutfit29;
    public Button pirateOutfit34;
    public Button pirateOutfit35;
    public Button pirateOutfit36;
    public Button pirateOutfit37;
    public Button pirateOutfit38;


    //Pets Buttons

    public Button pet30;
    public Button pet31;
    public Button pet32;
    public Button pet33;

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
    public int pirateHat13Price;
    public int pirateHat14Price;
    public int pirateHat15Price;
    public int pirateHat16Price;
    public int pirateHat17Price;


    //Outfit Prices

    public int pirateOutfit18Price;
    public int pirateOutfit19Price;
    public int pirateOutfit20Price;
    public int pirateOutfit21Price;
    public int pirateOutfit22Price;
    public int pirateOutfit23Price;
    public int pirateOutfit24Price;
    public int pirateOutfit25Price;
    public int pirateOutfit26Price;
    public int pirateOutfit27Price;
    public int pirateOutfit28Price;
    public int pirateOutfit29Price;
    public int pirateOutfit34Price;
    public int pirateOutfit35Price;
    public int pirateOutfit36Price;
    public int pirateOutfit37Price;
    public int pirateOutfit38Price;


    //Pet Prices

    public int pet30Price;
    public int pet31Price;
    public int pet32Price;
    public int pet33Price;


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

    [Header("Pets")]
    public SpriteRenderer petPart;
    public List<Sprite> petSprite = new List<Sprite>();


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

    public void PirateHat13()
    {
        if (Manager.manager.currentScore >= pirateHat13Price && !hat13IsBuy)
        {
            headPart.sprite = options[12];
            Manager.manager.currentScore -= pirateHat13Price;
            hat13IsBuy = true;
            shopText13.text = null;
            check13.SetActive(true);
        }
        else if (hat13IsBuy == true)
        {
            pirateHat13.interactable = true;
            headPart.sprite = options[12];
        }
    }

    public void PirateHat14()
    {
        if (Manager.manager.currentScore >= pirateHat14Price && !hat14IsBuy)
        {
            headPart.sprite = options[13];
            Manager.manager.currentScore -= pirateHat14Price;
            hat14IsBuy = true;
            shopText14.text = null;
            check14.SetActive(true);
        }
        else if (hat14IsBuy == true)
        {
            pirateHat14.interactable = true;
            headPart.sprite = options[13];
        }
    }

    public void PirateHat15()
    {
        if (Manager.manager.currentScore >= pirateHat15Price && !hat15IsBuy)
        {
            headPart.sprite = options[14];
            Manager.manager.currentScore -= pirateHat15Price;
            hat15IsBuy = true;
            shopText15.text = null;
            check15.SetActive(true);
        }
        else if (hat15IsBuy == true)
        {
            pirateHat15.interactable = true;
            headPart.sprite = options[14];
        }
    }

    public void PirateHat16()
    {
        if (Manager.manager.currentScore >= pirateHat16Price && !hat16IsBuy)
        {
            headPart.sprite = options[15];
            Manager.manager.currentScore -= pirateHat16Price;
            hat16IsBuy = true;
            shopText16.text = null;
            check16.SetActive(true);
        }
        else if (hat16IsBuy == true)
        {
            pirateHat16.interactable = true;
            headPart.sprite = options[15];
        }
    }

    public void PirateHat17()
    {
        if (Manager.manager.currentScore >= pirateHat17Price && !hat17IsBuy)
        {
            headPart.sprite = options[16];
            Manager.manager.currentScore -= pirateHat17Price;
            hat17IsBuy = true;
            shopText17.text = null;
            check17.SetActive(true);
        }
        else if (hat17IsBuy == true)
        {
            pirateHat17.interactable = true;
            headPart.sprite = options[16];
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

    public void PirateOutfit4()
    {
        if (Manager.manager.currentScore >= pirateOutfit21Price && !outfit21IsBuy)
        {
            torsoPart.sprite = torsoSprite[3];
            Manager.manager.currentScore -= pirateOutfit21Price;
            outfit21IsBuy = true;
            shopText21.text = null;
            check21.SetActive(true);
        }
        else if (outfit21IsBuy == true)
        {
            pirateOutfit21.interactable = true;
            torsoPart.sprite = torsoSprite[3];
        }
    }

    public void PirateOutfit5()
    {
        if (Manager.manager.currentScore >= pirateOutfit22Price && !outfit22IsBuy)
        {
            torsoPart.sprite = torsoSprite[4];
            Manager.manager.currentScore -= pirateOutfit22Price;
            outfit22IsBuy = true;
            shopText22.text = null;
            check22.SetActive(true);
        }
        else if (outfit22IsBuy == true)
        {
            pirateOutfit22.interactable = true;
            torsoPart.sprite = torsoSprite[4];
        }
    }

    public void PirateOutfit6()
    {
        if (Manager.manager.currentScore >= pirateOutfit23Price && !outfit23IsBuy)
        {
            torsoPart.sprite = torsoSprite[5];
            Manager.manager.currentScore -= pirateOutfit23Price;
            outfit23IsBuy = true;
            shopText23.text = null;
            check23.SetActive(true);
        }
        else if (outfit23IsBuy == true)
        {
            pirateOutfit23.interactable = true;
            torsoPart.sprite = torsoSprite[5];
        }
    }

    public void PirateOutfit7()
    {
        if (Manager.manager.currentScore >= pirateOutfit24Price && !outfit24IsBuy)
        {
            torsoPart.sprite = torsoSprite[6];
            Manager.manager.currentScore -= pirateOutfit24Price;
            outfit24IsBuy = true;
            shopText24.text = null;
            check24.SetActive(true);
        }
        else if (outfit24IsBuy == true)
        {
            pirateOutfit24.interactable = true;
            torsoPart.sprite = torsoSprite[6];
        }
    }

    public void PirateOutfit8()
    {
        if (Manager.manager.currentScore >= pirateOutfit25Price && !outfit25IsBuy)
        {
            torsoPart.sprite = torsoSprite[7];
            Manager.manager.currentScore -= pirateOutfit25Price;
            outfit25IsBuy = true;
            shopText25.text = null;
            check25.SetActive(true);
        }
        else if (outfit25IsBuy == true)
        {
            pirateOutfit25.interactable = true;
            torsoPart.sprite = torsoSprite[7];
        }
    }

    public void PirateOutfit9()
    {
        if (Manager.manager.currentScore >= pirateOutfit26Price && !outfit26IsBuy)
        {
            torsoPart.sprite = torsoSprite[8];
            Manager.manager.currentScore -= pirateOutfit26Price;
            outfit26IsBuy = true;
            shopText26.text = null;
            check26.SetActive(true);
        }
        else if (outfit26IsBuy == true)
        {
            pirateOutfit26.interactable = true;
            torsoPart.sprite = torsoSprite[8];
        }
    }

    public void PirateOutfit10()
    {
        if (Manager.manager.currentScore >= pirateOutfit27Price && !outfit27IsBuy)
        {
            torsoPart.sprite = torsoSprite[9];
            Manager.manager.currentScore -= pirateOutfit27Price;
            outfit27IsBuy = true;
            shopText27.text = null;
            check27.SetActive(true);
        }
        else if (outfit27IsBuy == true)
        {
            pirateOutfit27.interactable = true;
            torsoPart.sprite = torsoSprite[9];
        }
    }

    public void PirateOutfit11()
    {
        if (Manager.manager.currentScore >= pirateOutfit28Price && !outfit28IsBuy)
        {
            torsoPart.sprite = torsoSprite[10];
            Manager.manager.currentScore -= pirateOutfit28Price;
            outfit28IsBuy = true;
            shopText28.text = null;
            check28.SetActive(true);
        }
        else if (outfit28IsBuy == true)
        {
            pirateOutfit28.interactable = true;
            torsoPart.sprite = torsoSprite[10];
        }
    }
    
    public void PirateOutfit12()
    {
        if (Manager.manager.currentScore >= pirateOutfit29Price && !outfit29IsBuy)
        {
            torsoPart.sprite = torsoSprite[11];
            Manager.manager.currentScore -= pirateOutfit29Price;
            outfit29IsBuy = true;
            shopText29.text = null;
            check29.SetActive(true);
        }
        else if (outfit29IsBuy == true)
        {
            pirateOutfit29.interactable = true;
            torsoPart.sprite = torsoSprite[11];
        }
    }

    public void PirateOutfit13()
    {
        if (Manager.manager.currentScore >= pirateOutfit34Price && !outfit34IsBuy)
        {
            torsoPart.sprite = torsoSprite[12];
            Manager.manager.currentScore -= pirateOutfit34Price;
            outfit34IsBuy = true;
            shopText34.text = null;
            check34.SetActive(true);
        }
        else if (outfit34IsBuy == true)
        {
            pirateOutfit34.interactable = true;
            torsoPart.sprite = torsoSprite[12];
        }
    }

    public void PirateOutfit14()
    {
        if (Manager.manager.currentScore >= pirateOutfit35Price && !outfit35IsBuy)
        {
            torsoPart.sprite = torsoSprite[13];
            Manager.manager.currentScore -= pirateOutfit35Price;
            outfit35IsBuy = true;
            shopText35.text = null;
            check35.SetActive(true);
        }
        else if (outfit35IsBuy == true)
        {
            pirateOutfit35.interactable = true;
            torsoPart.sprite = torsoSprite[13];
        }
    }

    public void PirateOutfit15()
    {
        if (Manager.manager.currentScore >= pirateOutfit36Price && !outfit36IsBuy)
        {
            torsoPart.sprite = torsoSprite[14];
            Manager.manager.currentScore -= pirateOutfit36Price;
            outfit36IsBuy = true;
            shopText36.text = null;
            check36.SetActive(true);
        }
        else if (outfit36IsBuy == true)
        {
            pirateOutfit36.interactable = true;
            torsoPart.sprite = torsoSprite[14];
        }
    }

    public void PirateOutfit16()
    {
        if (Manager.manager.currentScore >= pirateOutfit37Price && !outfit37IsBuy)
        {
            torsoPart.sprite = torsoSprite[15];
            Manager.manager.currentScore -= pirateOutfit37Price;
            outfit37IsBuy = true;
            shopText37.text = null;
            check37.SetActive(true);
        }
        else if (outfit37IsBuy == true)
        {
            pirateOutfit37.interactable = true;
            torsoPart.sprite = torsoSprite[15];
        }
    }

    public void PirateOutfit17()
    {
        if (Manager.manager.currentScore >= pirateOutfit38Price && !outfit38IsBuy)
        {
            torsoPart.sprite = torsoSprite[16];
            Manager.manager.currentScore -= pirateOutfit38Price;
            outfit38IsBuy = true;
            shopText38.text = null;
            check38.SetActive(true);
        }
        else if (outfit38IsBuy == true)
        {
            pirateOutfit38.interactable = true;
            torsoPart.sprite = torsoSprite[16];
        }
    }

    public void Pet30()
    {
        if (Manager.manager.currentScore >= pet30Price && !pet30IsBuy)
        {
            petPart.sprite = petSprite[0];
            Manager.manager.currentScore -= pet30Price;
            pet30IsBuy = true;
            shopText30.text = null;
            check30.SetActive(true);
        }
        else if (pet30IsBuy == true)
        {
            pet30.interactable = true;
            petPart.sprite = petSprite[0];
        }        
    }

    public void Pet31()
    {
        if (Manager.manager.currentScore >= pet31Price && !pet31IsBuy)
        {
            petPart.sprite = petSprite[1];
            Manager.manager.currentScore -= pet31Price;
            pet31IsBuy = true;
            shopText31.text = null;
            check31.SetActive(true);
        }
        else if (pet31IsBuy == true)
        {
            pet31.interactable = true;
            petPart.sprite = petSprite[1];
        }
    }     
    
    public void Pet32()
    {
        if (Manager.manager.currentScore >= pet32Price && !pet32IsBuy)
        {
            petPart.sprite = petSprite[2];
            Manager.manager.currentScore -= pet32Price;
            pet32IsBuy = true;
            shopText32.text = null;
            check32.SetActive(true);
        }
        else if (pet32IsBuy == true)
        {
            pet32.interactable = true;
            petPart.sprite = petSprite[2];
        }
    }

    public void Pet33()
    {
        if (Manager.manager.currentScore >= pet33Price && !pet33IsBuy)
        {
            petPart.sprite = petSprite[3];
            Manager.manager.currentScore -= pet33Price;
            pet33IsBuy = true;
            shopText33.text = null;
            check33.SetActive(true);
        }
        else if (pet33IsBuy == true)
        {
            pet33.interactable = true;
            petPart.sprite = petSprite[3];
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
