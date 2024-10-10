using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class breakWishBone : MonoBehaviour
{


    public Sprite loss;

    public Sprite bigLoss;

    public Sprite bigWin;

    public Sprite win;

    public Sprite tie;

    private bool randomisationStarted;

    public GameObject rToBreak;


    private SpriteRenderer renderer;

    private bool doneRolling = true;

    public GameObject flash;


    





    // Start is called before the first frame update
    void Start()
    {
        

        

        renderer = GetComponent<SpriteRenderer>();

        


    }


    void delayFightingStage()
    {
        fightingStageEnabler.S.enableFightingStage();

        gameObject.SetActive(false);

        nextRoomChecker.S.rollDone = true;

        nextRoomChecker.S.triggerSpawners();
    }

    void turnOnFlash()
    {
        flash.SetActive(true);
    }

    void turnOffFlash()
    {
        flash.SetActive(false);
    }

    void stopRolling()
    {


        randomisationStarted = false;

        doneRolling = true;

        int randomNo = Random.Range(0, 5);

        CancelInvoke();

        turnOnFlash();

        switch (randomNo)
        {
            case 0:
                renderer.sprite = bigLoss;
                boneWishOutcome.S.theOutcome = "bigLoss";
                rToBreak.GetComponent<Text>().text = "A big loss!";
                break;
            case 1:
                renderer.sprite = loss;
                boneWishOutcome.S.theOutcome = "loss";
                rToBreak.GetComponent<Text>().text = "You Lose";
                break;
            case 2:
                renderer.sprite = tie;
                boneWishOutcome.S.theOutcome = "tie";
                rToBreak.GetComponent<Text>().text = "A TIE!";
                break;
            case 3:
                renderer.sprite = win;
                boneWishOutcome.S.theOutcome = "win";
                rToBreak.GetComponent<Text>().text = "You win!";
                break;
            case 4:
                renderer.sprite = bigWin;
                boneWishOutcome.S.theOutcome = "bigWin";
                rToBreak.GetComponent<Text>().text = "A BIG WIN";
                break;
        }

        Invoke("turnOffFlash", 0.1f);

        Invoke("delayFightingStage", 3f);
        
    }


    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && doneRolling)
        {

            doneRolling = false;


            Invoke("stopRolling", 1f);


            rToBreak.GetComponent<Text>().text = "";
            
        }


        
    }
}
