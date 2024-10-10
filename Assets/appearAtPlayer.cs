using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearAtPlayer : MonoBehaviour
{

    private GameObject player;

    private Vector3 playerPos;

    private bool jumping = true;

    private int randomX;

    private int randomY;

    private Vector3 posToMove;

    private bool playerPosFound;

    private float reachedThreshold = 4f;

    public GameObject warningPrefab;

    public GameObject theWarning;


    private bool isInvoking = false;

    private Vector3 positionToTeleport;

    private bool onCooldown;




    private playerMovement playerMoveScript;






    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


        playerMoveScript = player.GetComponent<playerMovement>();



        disappear();
    }



    void goOffCooldown()
    {
        onCooldown = false;
    }
    


    void disappear()
    {





        if (!isInvoking) // only one invoke is allowed at a time
        {
            Invoke("warn", 1f);

            isInvoking = true;
        }




        jumping = false;

        transform.position = new Vector3(999f, 999f, 0f);





    }

    public void deleteWarning()
    {
        if (theWarning != null)
        {
            Destroy(theWarning);
        }
    }

    public void warn()
    {



        positionToTeleport = player.transform.position;

        theWarning = Instantiate(warningPrefab, positionToTeleport, transform.rotation);

        Invoke("reAppear", 0.5f);


    }


    void reAppear()
    {


        transform.position = positionToTeleport;

        jumping = true;

        isInvoking = false; // set to false so that it can reappear again


        if (theWarning != null)
        {
            Destroy(theWarning);
        }


        Invoke("disappear", 1.5f);

    }




    // Update is called once per frame
    void Update()
    {




        if (Vector3.Distance(transform.position, player.transform.position) <= reachedThreshold && !onCooldown)
        {

            Invoke("goOffCooldown", 1.2f);

            playerIsTrappedStore.S.trap();



            

        }







    }


}