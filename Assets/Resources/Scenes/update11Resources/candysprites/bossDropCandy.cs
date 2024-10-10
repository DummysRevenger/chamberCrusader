using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossDropCandy : MonoBehaviour
{

    private GameObject gummyBear;
    private GameObject peanutCup;
    private GameObject lollipop;
    private GameObject bonBon;
    private GameObject candyCorn;
    private GameObject candyCane;
    private GameObject liquorice;


    // Start is called before the first frame update
    void Start()
    {
        // find the candies
        gummyBear = GameObject.Find("gummyBear");
        candyCorn = GameObject.Find("candyCorn");
        candyCane = GameObject.Find("candyCane");
        lollipop = GameObject.Find("lollipop");
        bonBon = GameObject.Find("bonBon");
        peanutCup = GameObject.Find("peanutCup");
        liquorice = GameObject.Find("liquorice");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("sword") || collision.gameObject.CompareTag("boom") || collision.gameObject.name.Contains("thrown"))
        {  // drop candy on hit
            if (selectCharacter.characterSelected == "bunny")
            {
                System.Random random = new System.Random();

                int randomNum = Random.Range(0, 100);


                if (randomNum >= 39) // don't drop liquorice
                {
                    if (randomNum <= 59)
                    {
                        Instantiate(lollipop, transform.position, transform.rotation);
                    }
                    else
                    {
                        if (randomNum <= 79)
                        {
                            Instantiate(bonBon, transform.position, transform.rotation);
                        }
                        else
                        {
                            if (randomNum <= 84)
                            {
                                Instantiate(candyCane, transform.position, transform.rotation);
                            }
                            else
                            {
                                if (randomNum <= 89)
                                {
                                    Instantiate(candyCorn, transform.position, transform.rotation);
                                }
                                else
                                {
                                    if (randomNum <= 94)
                                    {
                                        Instantiate(peanutCup, transform.position, transform.rotation);
                                    }
                                    else
                                    {
                                        if (randomNum > 98)
                                        {
                                            Instantiate(gummyBear, transform.position, transform.rotation);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Instantiate(liquorice, transform.position, transform.rotation);
                }

            }
        }
    }
}
