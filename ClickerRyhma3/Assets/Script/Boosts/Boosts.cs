using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosts : Manager
{
    public float amountCoins;
    

    void Update()
    {
        BoostButton();
        Destroy(gameObject, 4f);
    }

    public void BoostButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);

            if (hit2D.collider.CompareTag("CoinBoost"))
            {
                amountCoins = Random.Range(50, 500);
                currentScore += amountCoins;
                Debug.Log("CoinBoost");
                Destroy(gameObject);
            }

            if (hit2D.collider.CompareTag("ClickDmgBoost"))
            {
                hitPower += 10;
                clickDmgStat += 10;
                Debug.Log("ClickDmgBoost");
                Destroy(gameObject);
            }

            else
            {
                return;
            }
        }
    }

}
