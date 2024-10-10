using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyWall : MonoBehaviour
{

    public GameObject playerObject;

    
    public GameObject knight;
    public GameObject ninja;
    public GameObject soldier;
    public GameObject bunny;

    void Start()
    {




        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {


        if (playerObject.transform.position.y > 7.9f && enemiesInRoomChecker.S.enemiesInRoomNumber == 0
            && tutorialDoneChecker.tutorialDone)
        {
            transform.position = new Vector2(99f, 99f);
            Destroy(gameObject);
        }
    }
}
