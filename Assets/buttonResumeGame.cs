using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonResumeGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void onSelect()
    {
        pauseGame.S.ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
