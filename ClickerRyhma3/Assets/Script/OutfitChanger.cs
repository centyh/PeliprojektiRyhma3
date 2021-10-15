using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OutfitChanger : MonoBehaviour
{
    bool hatIsBuy;
    bool hat2IsBuy;

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
        //pirateHat.interactable = false;
    }

    public void PirateHat()
    {
        if(Manager.manager.currentScore >= pirateHatPrice && !hatIsBuy)
        {
            headPart.sprite = options[0];
            Manager.manager.currentScore -= pirateHatPrice;
            hatIsBuy = true;
        }
        
    }

    public void PirateHat2()
    {
        if (Manager.manager.currentScore >= pirateHat2Price && !hat2IsBuy)
        {
            headPart.sprite = options[1];
            Manager.manager.currentScore -= pirateHat2Price;
            hat2IsBuy = true;
        }
    }

    public void PirateHat3()
    {
        headPart.sprite = options[2];
    }

    public void PirateOutfit()
    {
        torsoPart.sprite = torsoSprite[0];
    }

    public void PirateOutfit2()
    {

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
