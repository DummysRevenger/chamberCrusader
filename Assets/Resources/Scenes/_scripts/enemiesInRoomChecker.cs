using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesInRoomChecker : MonoBehaviour
{
    public static enemiesInRoomChecker S;

    public GameObject TopWall;

    public int enemiesInRoomNumber = 0;
    // Start is called before the first frame update
    void Awake()
    {
        S = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(enemiesInRoomNumber);

        

        if (tutorialDoneChecker.tutorialDone)
        {
            if (enemiesInRoomNumber <= 0)
            {
                TopWall.SetActive(false);

                

            }
            else
            {
                TopWall.SetActive(true);

            }
        }
        else
        {
            TopWall.SetActive(true);
        }
    }
}
