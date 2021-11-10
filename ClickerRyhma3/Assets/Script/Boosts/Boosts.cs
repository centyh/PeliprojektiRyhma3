using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Boosts : MonoBehaviour
{
    [SerializeField] private AudioSource diamondSound;
    [SerializeField] private AudioSource scrollSound;
    [SerializeField] private AudioSource chestSound;

    public GameObject clickDmgText;
    public GameObject coinText;
    public GameObject coinsLost;
    public GameObject luckyHitText;
    public GameObject autoClickText;

    public ParticleSystem chestParticleEffect;
    public ParticleSystem diamondParticleEffect;
    public ParticleSystem diamondBadEffect;
    public ParticleSystem clickDmgParticleEffect;

    public Text coinsText;
    public Text coinsLostText;

    public float amountCoins;
    public float amountCoins2;

    public float currentDmg;
    public float currentDmgStat;
    public float normalDmg;

    public float dmgBoostTimer = 0f;
    public bool dmgBoostActive = false;
    public float addedBoostAmount;

    void Start()
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


        coinsText.text = "YOU GOT " + amountCoins + " COINS!";
        coinsLostText.text = "YOU LOST " + amountCoins2 + " COINS!";
    }

    public void BoostButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;

            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

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
                    Instantiate(clickDmgParticleEffect, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
                    scrollSound.Play();
                    Destroy(hit.collider.gameObject);
                    clickDmgText.SetActive(true);
                }

                if (hit.collider.CompareTag("CoinBoost"))
                {
                    Debug.Log("Klikattiin coin boostia");
                    CoinBoost();
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.CompareTag("RandomizedBoost"))
                {
                    RandomizedBoost();
                    diamondSound.Play();
                    Destroy(hit.collider.gameObject);
                    
                }
            }
        }
    }

    void CoinBoost()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        amountCoins = Random.Range(50, 250);

        Manager.manager.currentScore += amountCoins;
        Instantiate(chestParticleEffect, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
        chestSound.Play();
        
        StartCoroutine(Wait());
    }

    void RandomizedBoost()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        amountCoins2 = Random.Range(100, 1000);

        float randValue;
        randValue = Random.Range(1, 4);

        if(randValue == 1)
        {
            Manager.manager.currentScore -= amountCoins;
            Debug.Log("You lost: " + amountCoins);
            Instantiate(diamondBadEffect, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
            StartCoroutine(Wait3());
        }
        if(randValue == 2)
        {
            StartCoroutine(BoostTime());
            Debug.Log("Lucky Hit Increased");
            Instantiate(diamondParticleEffect, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
            StartCoroutine(Wait2());
        }
        if(randValue == 3)
        {
            StartCoroutine(BoostTime2());
            Instantiate(diamondParticleEffect, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
            Debug.Log("Auto Click started");
            StartCoroutine(Wait4());
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

    IEnumerator Wait()
    {
        coinText.SetActive(true);
        yield return new WaitForSeconds(5);
        coinText.SetActive(false);
    }

    IEnumerator Wait2()
    {
        luckyHitText.SetActive(true);
        yield return new WaitForSeconds(5);
        luckyHitText.SetActive(false);
    }

    IEnumerator Wait3()
    {
        coinsLost.SetActive(true);
        yield return new WaitForSeconds(5);
        coinsLost.SetActive(false);
    }

    IEnumerator Wait4()
    {
        autoClickText.SetActive(true);
        yield return new WaitForSeconds(5);
        autoClickText.SetActive(false);
    }

    IEnumerator BoostTime()
    {
        Manager.manager.target += .10f;
        Manager.manager.luckyHitStat += 10;

        yield return new WaitForSeconds(5);

        Manager.manager.target -= .10f;
        Manager.manager.luckyHitStat -= 10;
    }

    IEnumerator BoostTime2()
    {
        Manager.manager.x += 35;
        Manager.manager.autoClickStat += 35;

        yield return new WaitForSeconds(5);

        Manager.manager.x -= 35;
        Manager.manager.autoClickStat -= 35;
    }
}
