using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownScript : MonoBehaviour
{
    [SerializeField] private Image imageCooldown;

    [SerializeField] private Text textCooldown;

    private bool isCooldown = false;
    private float cooldownTime = 10f;
    private float cooldownTimer = 0f;


    private void Start()
    {
        textCooldown.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0f;
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseAbility();
        }
        if (isCooldown)
        {
            ApplyCooldown();
        }

    }

    public void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer < 0f)
        {
            isCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0f;
        }
        else
        {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;
        }
    }


    public void UseAbility()
    {
        if (isCooldown)
        {
            //clicked spell while in use
        }
        else
        {
            isCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;
            
        }
    }
}
