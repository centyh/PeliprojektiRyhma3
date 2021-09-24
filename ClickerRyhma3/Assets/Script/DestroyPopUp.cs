using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPopUp : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        Destroy(gameObject, 0.8f);
    }
}
