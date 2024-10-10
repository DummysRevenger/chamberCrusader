using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseGame : MonoBehaviour
{
    public static pauseGame S;

    public static bool isPaused = false;

    private GameObject pauseBG;

    private GameObject resumeButton;

    private GameObject resumeButtonText;

    private GameObject endRoundButton;

    private GameObject endRoundText;

    private GameObject tipBookButton;

    private GameObject tipBookText;

    

    // Start is called before the first frame update
    void Start()
    {

        S = this;


        pauseBG = GameObject.Find("pauseMenuBackground");

        resumeButton = GameObject.Find("Resume");

        resumeButtonText = GameObject.Find("resumeText");

        tipBookButton = GameObject.Find("tipBook");

        tipBookText = GameObject.Find("tipBookText");

        endRoundButton = GameObject.Find("endRound");

        endRoundText = GameObject.Find("endRoundText");

        



    }

    public void PausetheGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Pause the game time
                             // Optionally, you can also do the following:
                             // - Disable player input
                             // - Show a pause menu or UI
                             // - Freeze other game objects or systems

        gunRotation[] allInstances = FindObjectsOfType<gunRotation>();
        foreach (gunRotation instance in allInstances)
        {
            instance.enabled = false;
        }

        resumeButton.GetComponent<Image>().enabled = true;

        resumeButtonText.GetComponent<Text>().enabled = true;

        tipBookButton.GetComponent<Image>().enabled = true;

        tipBookText.GetComponent<Text>().enabled = true;

        endRoundButton.GetComponent<Image>().enabled = true;

        endRoundText.GetComponent<Text>().enabled = true;

        pauseBG.GetComponent<Image>().enabled = true;



    }



    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume the game time
                             // Optionally, you can also do the following:
                             // - Re-enable player input
                             // - Hide the pause menu or UI
                             // - Unfreeze other game objects or systems

        gunRotation[] allInstances = FindObjectsOfType<gunRotation>();
        foreach (gunRotation instance in allInstances)
        {
            instance.enabled = true;
        }


        resumeButton.GetComponent<Image>().enabled = false;

        resumeButtonText.GetComponent<Text>().enabled = false;

        pauseBG.GetComponent<Image>().enabled = false;

        tipBookButton.GetComponent<Image>().enabled = false;

        tipBookText.GetComponent<Text>().enabled = false;

        endRoundButton.GetComponent<Image>().enabled = false;

        endRoundText.GetComponent<Text>().enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausetheGame();

            pauseBG.GetComponent<Image>().enabled = true;

            // disable ranged weapons

        }


        if (Input.GetKeyDown(KeyCode.Space) && isPaused && !openTipBook.tipBookOpen) 
        {
            ResumeGame();
            pauseBG.GetComponent<Image>().enabled = false;
        }


    }
}
     






