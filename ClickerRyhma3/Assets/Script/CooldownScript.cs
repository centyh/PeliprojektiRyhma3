using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownScript : MonoBehaviour
{
    [SerializeField] private Image imageCooldown;

    [SerializeField] private Text textCooldown;

    [SerializeField] private Button abilityButton;

    [SerializeField] private Animator backgroundAnim;

    private bool isCooldown = false;

    private float cooldownTime = 30f;
    private float cooldownTimer = 0f;



    private void Start()
    {
        backgroundAnim = GetComponent<Animator>();

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
        backgroundAnim.SetTrigger("Click");
        StartCoroutine(Ability());
        Debug.Log("Auto Click Ability");
        abilityButton.enabled = false;
        UseAbility();
    }

    public void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer < 0f)
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
        Manager.manager.x += 15;
        Manager.manager.autoClickStat += 15;

        yield return new WaitForSeconds(5f);

        Manager.manager.x -= 15;
        Manager.manager.autoClickStat -= 15;
    }
}
