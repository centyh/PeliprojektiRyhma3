using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown2 : MonoBehaviour
{
    [SerializeField] private Image imageCooldown;

    [SerializeField] private Text textCooldown;

    [SerializeField] private Button abilityButton;

    private bool isCooldown = false;

    private float cooldownTime = 45f;
    private float cooldownTimer = 0f;



    private void Start()
    {


        textCooldown.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0f;
    }


    public void Update()
    {
        if (isCooldown)
        {
            ApplyCooldown();
        }
    }

    public void Testi()
    {
        StartCoroutine(Ability());
        Debug.Log("Auto Click Ability Kaksi");
        abilityButton.enabled = false;
        UseAbility();
    }

    public void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer < 0f)
        {
            abilityButton.enabled = true;
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

        }
        else
        {
            isCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;
        }
    }


    IEnumerator Ability()
    {
        Manager.manager.hitPower += 50;
        Manager.manager.clickDmgStat += 50;

        yield return new WaitForSeconds(5f);

        Manager.manager.hitPower -= 50;
        Manager.manager.clickDmgStat -= 50;
    }
}
