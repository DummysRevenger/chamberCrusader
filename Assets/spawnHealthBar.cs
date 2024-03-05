using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnHealthBar : MonoBehaviour
{

    public hpStore healthStore;

    private GameObject hpText;


    public GameObject healthBarPrefab;
    // set it in the inspector

    Canvas canvas;

    private GameObject healthBar;

    void Start()
    {
        

        healthStore = GetComponent<hpStore>(); // the enemy's hp store script

        canvas = GameObject.FindObjectOfType<Canvas>(); // the scene canvas


        healthBar = Instantiate(healthBarPrefab, canvas.transform);
        // spawn a healthbar on the canvas

        hpText = healthBar.transform.GetChild(0).gameObject; // child of healthBarPrefab, 
        // the text which contains the displayHPNumber script

        HealthBarScript HBS = healthBar.GetComponent<HealthBarScript>();
        // declare health bar script

        HBS.enemyObject = gameObject;


        healthBarFollowTarget hBFTScript = healthBar.GetComponent<healthBarFollowTarget>();
        //set the health bar follow target script of the health bar as an object 


        displayHPNumber DHPNScript = hpText.GetComponent<displayHPNumber>();
        // set the display hp number script of the hptext object as an object

        hBFTScript.targetTransform = gameObject.transform;
        // set the targetTransform for the transform of the enemy


        DHPNScript.setTarget(healthStore);
        // set the target hpStore to the enemy's hpStore

        

    }

    

    // Update is called once per frame
    void Update()
    {
        
        if (healthStore.health <= 0)
        {
            Destroy(healthBar);
        }

    }
}
