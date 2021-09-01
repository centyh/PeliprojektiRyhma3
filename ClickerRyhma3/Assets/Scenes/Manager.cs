using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;

    float TotalClicks;


    bool hasUpgrade;

    public int autoClicksPerSecond;     // To add amount for autoclicks per seconds
    public int minimumClicksToUnlockUpgrade; //  How many clicks to unlock the upgrade


    public void AddClicks()
    {
        TotalClicks++;      // Add Score to the text when clicking button
        ClicksTotalText.text = TotalClicks.ToString("0");       // It shows the text no desimal only full numbers
    }

    public void AutoClickUpgrade()
    {
        if (!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            TotalClicks = minimumClicksToUnlockUpgrade;        // Won't subract from the score when using upgrade
            hasUpgrade = true;
        }
    }

    private void Update()
    {
        if (hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("0");   // Update the score
        }
    }
}
