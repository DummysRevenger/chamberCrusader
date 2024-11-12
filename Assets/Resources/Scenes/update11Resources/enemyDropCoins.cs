using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDropCoins : MonoBehaviour
{

    private hpStore healthScript;

    private GameObject coin;
    private GameObject smallNote;
    private GameObject bigNote;
    private GameObject bar;

    private int randomNumber;

    private bool dropExtraCash = false;




    // Start is called before the first frame update
    void Start()
    {

        string bigBankPath = "Scenes/update11Resources/newprefabs/cash/bigBankNote";
        string goldBarPath = "Scenes/update11Resources/newprefabs/cash/goldBar";
        string smallBankPath = "Scenes/update11Resources/newprefabs/cash/smallBankNote";
        string goldCoinPath = "Scenes/update11Resources/newprefabs/cash/goldCoin";


        // find the candies
        bigNote = Resources.Load(bigBankPath) as GameObject;
        bar = Resources.Load(goldBarPath) as GameObject;
        smallNote = Resources.Load(smallBankPath) as GameObject;
        coin = Resources.Load(goldCoinPath) as GameObject;
      


        healthScript = GetComponent<hpStore>();   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("dagger"))
        {
            dropExtraCash = true;

            GetComponent<SpriteRenderer>().color = new Color(255f/255f, 215f/255f, 0f/255f);
        }
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);


        if (healthScript.health <= 0)
        {

            if (gameObject.name.Contains("anubis") || gameObject.name.Contains("paladin") || gameObject.name.Contains("strongZombie"))
            {

                if (selectCharacter.characterSelected == "envy")
                {
                    if (!dropExtraCash && !envyStealAttackAbility.S.extraCash)
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                    else
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                }
                else
                {
                    if (!dropExtraCash)
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                    else
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                }
            }
            else if (!gameObject.name.Contains("Boss") && !gameObject.name.Contains("Pyramid"))
            {
                if (selectCharacter.characterSelected == "envy")
                {
                    if (!dropExtraCash && !envyStealAttackAbility.S.extraCash)
                    {
                        randomNumber = Random.Range(0, 100);

                        if (randomNumber > 20 && randomNumber < 70)
                        {
                            Instantiate(coin, transform.position, desiredRotation);
                        }
                        else if (randomNumber < 90)
                        {
                            Instantiate(smallNote, transform.position, desiredRotation);
                        }
                        else if (randomNumber < 99)
                        {
                            Instantiate(bigNote, transform.position, desiredRotation);
                        }
                        else if (randomNumber == 99)
                        {
                            Instantiate(bar, transform.position, desiredRotation);
                        }
                    }
                    else
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                }
                else
                {
                    if (!dropExtraCash)
                    {
                        randomNumber = Random.Range(0, 100);

                        if (randomNumber > 20 && randomNumber < 70)
                        {
                            Instantiate(coin, transform.position, desiredRotation);
                        }
                        else if (randomNumber < 90)
                        {
                            Instantiate(smallNote, transform.position, desiredRotation);
                        }
                        else if (randomNumber < 99)
                        {
                            Instantiate(bigNote, transform.position, desiredRotation);
                        }
                        else if (randomNumber == 99)
                        {
                            Instantiate(bar, transform.position, desiredRotation);
                        }
                    }
                    else
                    {
                        Instantiate(bigNote, transform.position, desiredRotation);
                        Instantiate(bigNote, transform.position, desiredRotation);
                    }
                }
            }
            else
            {
                Instantiate(bar, transform.position, desiredRotation);
                Instantiate(bigNote, transform.position, desiredRotation);
                Instantiate(bigNote, transform.position, desiredRotation);
                Instantiate(bigNote, transform.position, desiredRotation);
                Instantiate(bigNote, transform.position, desiredRotation);
                Instantiate(bigNote, transform.position, desiredRotation);

            }
            

            this.enabled = false;

        }
    }
}
