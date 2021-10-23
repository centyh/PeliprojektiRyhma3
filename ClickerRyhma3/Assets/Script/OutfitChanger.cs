using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OutfitChanger : MonoBehaviour
{
    //Check mark when buyed
    public GameObject check;
    public GameObject check2;
    public GameObject check3;

    //Shop price text
    public Text shopText;
    public Text shopText2;
    public Text shopText3;

    //Hats buyed
    bool hatIsBuy;
    bool hat2IsBuy;
    bool hat3IsBuy;

    //Buttons
    public Button pirateHat;
    public Button pirateHat2;
    public Button pirateHat3;

    //Prices
    public int pirateHatPrice;
    public int pirateHat2Price;
    public int pirateHat3Price;

    


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
            pirateHat.interactable = true;
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
            pirateHat.interactable = true;
            headPart.sprite = options[2];
        }
    }

    public void PirateOutfit()
    {
        torsoPart.sprite = torsoSprite[0];
    }

    public void PirateOutfit2()
    {
        torsoPart.sprite = torsoSprite[1];
    }

    public void PirateOutfit3()
    {

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
