using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAnimation : MonoBehaviour
{
    public GameObject coinPrefab;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        //Vector3 mousePos = Input.mousePosition;
        //mousePos.z = 2.0f;
        //Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        //Instantiate(coinPrefab, objectPos, Quaternion.identity);
        //anim.SetTrigger("OnClick");
    }
}
