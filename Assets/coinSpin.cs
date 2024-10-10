using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinSpin : MonoBehaviour
{
    private Animator theAnimator;

    public Sprite tails;

    public Sprite heads;

    private SpriteRenderer renderer;

    private bool doneSpinning = false;

    private GameObject fightingStage;

    public GameObject pauseCanvas;

    public GameObject theCanvas;

    private bool MovingLeft = false;

    private GameObject coinPrefab;

    private GameObject spawnedCoin;

    public GameObject RtoSpin;

    
    

    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();

        theAnimator.enabled = false;

        renderer = GetComponent<SpriteRenderer>();

        coinPrefab = Resources.Load("Scenes/update12Resources/randomEvents/coinSpin") as GameObject;

        if (!doneSpinning && coinsSpawnedCounter.S.coinsSpawned == 3)
        {
            transform.Translate(Vector3.right * 10);
        }

        
    }


    void turnOffText()
    {
        if (RtoSpin != null)
        {
            RtoSpin.GetComponent<Text>().text = "";
        }
    }
    
    void stopRolling()
    {
        theAnimator.enabled = false;

        doneSpinning = true;

        int randomInt = Random.Range(0,2);

        if (randomInt == 0)
        {
            renderer.sprite = tails;

            coinsSpawnedCounter.S.tailsCount++;

            if (RtoSpin != null)
            {
                RtoSpin.GetComponent<Text>().text = "TAILS";
            }

            if (coinsSpawnedCounter.S.coinsSpawned < 3)
            {
                Invoke("spawnCoin", 1f);
            }
            else
            {

                Invoke("delayFightingStage", 2f);
                
            }
        }
        else
        {
            renderer.sprite = heads;

            if (RtoSpin != null)
            {
                RtoSpin.GetComponent<Text>().text = "HEADS";
            }


            Invoke("delayFightingStage", 2f);
        }

    }

   void spawnCoin()
   {
        spawnedCoin = Instantiate(coinPrefab, transform.position, transform.rotation);

        
        MovingLeft = true;

        coinsSpawnedCounter.S.coinsSpawned++;

        if (RtoSpin != null)
        {
            RtoSpin.GetComponent<Text>().text = "Press 'R' to bet on heads";
        }
    }

    void delayFightingStage()
    {

        coinsSpawnedCounter.S.rolledHeads = true;

        fightingStageEnabler.S.enableFightingStage();


        nextRoomChecker.S.triggerSpawners();

        nextRoomChecker.S.rollDone = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (coinsSpawnedCounter.S.rolledHeads)
        {
            gameObject.SetActive(false);
        }

        if (MovingLeft && gameObject.name.Contains("original"))
        {
            
            transform.Translate(Vector3.left * 10);
            MovingLeft = false;
        }



        if (Input.GetKeyDown(KeyCode.R) && !doneSpinning)
        {

            theAnimator.enabled = true;

            if (RtoSpin != null)
            {
                RtoSpin.GetComponent<Text>().text = "";
            }

            Invoke("stopRolling", 3f);
        }
    }
}
