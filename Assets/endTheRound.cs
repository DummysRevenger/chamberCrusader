using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTheRound : MonoBehaviour
{

    private GameObject endRoundObject;

    // Start is called before the first frame update
    void Start()
    {
        endRoundObject = GameObject.Find("endRoundObject");
    }

    private void reloadScene()
    {
        restartGame.ReloadScene();
    }

    public void onClickYea()
    {
        // load the character select screen
        Time.timeScale = 1f;
        reloadScene();
    }

    public void onClickNay()
    {
        // close the endRoundObject
        endRoundObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
