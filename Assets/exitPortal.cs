using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitPortal : MonoBehaviour
{
    public static exitPortal S;

    public bool stage5Begun = false;

    private GameObject exitPoint;

    public slothTeleport SlothTpScript;



    // Start is called before the first frame update
    void Start()
    {
        S = this;

        exitPoint = GameObject.Find("exitPortalExit");

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Camera mainCamera = Camera.main;


        if (other.gameObject.CompareTag("Player"))
        {

            hpStorePlayer.S.playerHealth = 99999f;



            other.gameObject.transform.position = new Vector2(0f, -3f);


            mainCamera.GetComponent<cameraFollowPlayer>().enabled = false;

            mainCamera.transform.position = new Vector3(-0.87f, -1.46f, -30f);


            pyramidTransition.stage5Begun = true;

            //other.gameObject.transform.position = exitPoint.transform.position;


            if (playerSwitcher.S.playerType == "sloth")
            {
                pyramidStage4Spawner.S.SlothTpScript.enabled = true;
            }


        }

        

        

    }

}
