using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rouletteSpin : MonoBehaviour
{

    private bool finishedSpinning;

    private GameObject loseText;
    private GameObject winText;

    private GameObject notEnoughText;
    private GameObject refuseText;

    private GameObject promptText;

    private int betCount = 0;

    private bool won = false;


    private System.Random random;

    private bool collidingWithPlayer;


    // Start is called before the first frame update
    void Start()
    {
        

        loseText = GameObject.Find("youLose500");

        winText = GameObject.Find("youWon2000");

        refuseText = GameObject.Find("refuseText");

        notEnoughText = GameObject.Find("NotEnoughMoneyText");

        promptText = GameObject.Find("roulettePrompt");

        random = new System.Random();

    }


    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collidingWithPlayer = true;

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collidingWithPlayer = false;

        }
    }

    void finishSpinning()
    {

        int RandomNumber = random.Next(0, 38);

        if (RandomNumber < 18)
        {
            Debug.Log("you lose 500!");
            loseText.GetComponent<Text>().enabled = true;


            StartCoroutine(DeleteText(loseText));
        }
        else
        {
            Debug.Log("you win 2000!");
            winText.GetComponent<Text>().enabled = true;
            coinCounterStore.roundCoinNumber += 2000;
            won = true;

            StartCoroutine(DeleteText(winText));
        }


        coinCounterStore.roundCoinNumber -= 500;

        finishedSpinning = false;
    }


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.B) && collidingWithPlayer)
        {

            promptText.GetComponent<Text>().enabled = false;

            

            if (!finishedSpinning && betCount < 3 && coinCounterStore.roundCoinNumber >= 500 && !won)
            {


                betCount++;

                

                finishedSpinning = true;

                Invoke("finishSpinning", 2f);
                
            }
            else
            {
                if (coinCounterStore.roundCoinNumber < 500)
                {
                    notEnoughText.GetComponent<Text>().enabled = true;
                    Debug.Log("not enough money :c");
                    StartCoroutine(DeleteText(notEnoughText));
                }
                else if (won || betCount >= 3)
                {
                    refuseText.GetComponent<Text>().enabled = true;
                    Debug.Log("the house refuses to give you any more chances c:");
                    StartCoroutine(DeleteText(refuseText));
                }
            }

        }

    }


    private IEnumerator DeleteText(GameObject theText)
    {

        yield return new WaitForSeconds(1f);

        Text textComponent = theText.GetComponent<Text>();

        if (textComponent != null)
        {
            theText.GetComponent<Text>().enabled = false;
        }

        


    }

}
