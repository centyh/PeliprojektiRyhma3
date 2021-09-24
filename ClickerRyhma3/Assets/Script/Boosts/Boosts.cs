using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosts : MonoBehaviour
{
    public float amountCoins;

    public float currentDmg;
    public float currentDmgStat;
    public float normalDmg;

    private float dmgBoostTimer = 5f;
    public bool dmgBoostActive = false;
    

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
                StartCoroutine(DmgBoostCoroutine());
                
                new WaitForSeconds(5);
                Debug.Log("Dmg boost loppui");

                Destroy(gameObject);
            }
            else
            {
                return;
            }
        }
    }

    void DmgBoostActive()
    {
        
    }

    IEnumerator DmgBoostCoroutine()
    {
        Manager.manager.hitPower += 50;
        Manager.manager.clickDmgStat += 50;
        Debug.Log("DMG BOOST AKTIIVINEN");

        yield return new WaitForSeconds(dmgBoostTimer);

    }


}
