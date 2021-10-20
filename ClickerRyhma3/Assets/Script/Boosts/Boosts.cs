using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Boosts : MonoBehaviour
{
    public GameObject clickDmgText;

    public float amountCoins;

    public float currentDmg;
    public float currentDmgStat;
    public float normalDmg;

    public float dmgBoostTimer = 0f;
    public bool dmgBoostActive = false;
    public float addedBoostAmount;

    private void Start()
    {

    }

    void Update()
    {

        if (dmgBoostTimer < 0 && dmgBoostActive == true)
        {
            DmgBoostDeActive();
            dmgBoostActive = false;
            dmgBoostTimer = 0;
        }
        dmgBoostTimer -= Time.deltaTime;
        BoostButton();
    }

    public void BoostButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            amountCoins = Random.Range(50, 250);

            RaycastHit2D hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.GetRayIntersection(ray);
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("ClickDmgBoost"))
                {
                    Debug.Log("Klikattiin spawnattua bonusta" + hit.collider.gameObject.name);
                    dmgBoostActive = true;
                    dmgBoostTimer = 5;
                    DmgBoostActive();
                    Destroy(hit.collider.gameObject);
                    clickDmgText.SetActive(true);
                }

                if (hit.collider.CompareTag("CoinBoost"))
                {
                    Debug.Log("Klikattiin coin boostia");
                    Manager.manager.currentScore += amountCoins;
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.CompareTag("RandomizedBoost"))
                {
                    RandomizedBoost();
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    void RandomizedBoost()
    {
        float randValue;
        randValue = Random.Range(1, 3);

        if(randValue == 1)
        {
            Debug.Log("Random Value on 1");
        }
        if(randValue == 2)
        {
            Debug.Log("Random Value on 2");
        }
        if(randValue == 3)
        {
            Debug.Log("Random Value on 3");
        }
    }


    void DmgBoostActive()
    {
        Debug.Log("Boosti päälle");
        addedBoostAmount += 50;
        Manager.manager.clickDmgStat += 50;
    }

    void DmgBoostDeActive()
    {
        Debug.Log("Boosti pois päältä");
        addedBoostAmount = 0;
        Manager.manager.clickDmgStat -= 50;
        clickDmgText.SetActive(false);
    }
}
