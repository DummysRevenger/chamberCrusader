using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightingStageEnabler : MonoBehaviour
{

    public GameObject fightingStage;

    public GameObject fightingStageCanvas;

    public GameObject card;

    public GameObject D6;

    public GameObject D6x3;

    public GameObject coin;

    public GameObject wishBone;

    public static fightingStageEnabler S;

    public GameObject randomBackground;

    public GameObject pauseCanvas;


    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    public void enableFightingStage()
    {
        fightingStageCanvas.SetActive(true);

        fightingStage.SetActive(true);

        card.SetActive(false);

        randomBackground.SetActive(false);

        wishBone.SetActive(false);

        D6.SetActive(false);

        D6x3.SetActive(false);

        coin.SetActive(false);

        pauseCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
