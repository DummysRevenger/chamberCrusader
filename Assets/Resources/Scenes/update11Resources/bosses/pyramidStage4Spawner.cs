using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidStage4Spawner : MonoBehaviour
{

    public static pyramidStage4Spawner S;

    public GameObject stage4MapPrefab;

    private bool stageSpawned = false;

    public GameObject startPoint;

    public GameObject playerObject;

    public GameObject playerSpotLight;

    public slothTeleport SlothTpScript;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
         
        playerObject = GameObject.FindGameObjectWithTag("Player");

        playerSpotLight = playerSpotLightStore.S.spotLight;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stageSpawned && pyramidTransition.stage4bool)
        {

            if (playerSwitcher.S.playerType == "sloth")
            {
                SlothTpScript.enabled = false;
            }

            Instantiate(stage4MapPrefab, transform.position, transform.rotation);
            stageSpawned = true;

            startPoint = GameObject.Find("startPoint");

            playerObject.transform.position = startPoint.transform.position;

            playerSpotLight.SetActive(true);
        }

        if (pyramidTransition.stage5bool)
        {
            playerSpotLight.SetActive(false);
        }
        

        
    }
}
