using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDmgBoost : Manager
{
    private float amountCoins;

    

    void Start()
    {
        
    }

    
    void Update()
    {
        ClickBoost();
        Destroy(gameObject, 4f);
    }

    void ClickBoost()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);

            if (hit2D.collider.CompareTag("ClickDmgBoost"))
            {
                hitPower += 30;
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
