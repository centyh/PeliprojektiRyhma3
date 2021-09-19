using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosts : MonoBehaviour
{
    public float amountCoins;

    private float dmgTimer;
    

    private void Start()
    {
        
    }

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
                amountCoins = Random.Range(50, 250);
                Manager.manager.currentScore += amountCoins;
                Debug.Log("CoinBoost");
                Destroy(gameObject);
            }

            if (hit2D.collider.CompareTag("ClickDmgBoost"))
            {
                Debug.Log("ClickDmgBoost");
                Manager.manager.hitPower += 10;
                Manager.manager.clickDmgStat += 10;
                Destroy(gameObject);
                
            }

            else
            {
                return;
            }
        }
    }




}
