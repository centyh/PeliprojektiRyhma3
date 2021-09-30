using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>();

    public int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= options.Count)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption];
    }

    public void PirateHat()
    {
        bodyPart.sprite = options[0];
    }

    public void PirateHat2()
    {
        bodyPart.sprite = options[1];
    }
}
