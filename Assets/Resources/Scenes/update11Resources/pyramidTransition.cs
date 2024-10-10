using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pyramidTransition : MonoBehaviour
{

    

    public pyramidCharge chargeScript;

    public GameObject stage4Canvas;

    public GameObject stage4Portal;

    private bool stingerPlayed = false;

    private GameObject song1; // an ancient encounter

    private GameObject song2; // where am I

    private GameObject song3; // the ultimate buildup

    private GameObject song4; // coda endless loop

    private GameObject pyramidHurtSound;

    
    

    //public GameObject pyramidDarknessMap;

    private cameraFollowPlayer cameraScript;

    

    

    public static bool stage3bool = false;

    public static bool stage4bool = false;

    public static bool stage5bool = false;

    private GameObject globalLight;

    private UnityEngine.Rendering.Universal.Light2D globalLightComponent;


    public Color initialColor;

    public Color targetColor;

    public GameObject playerSpotLight;

    public pyramidCharge chargingScript;

    public GameObject startPoint;

    public spawnPestilence pestilenceSpawner;

    public static bool stage5Begun;

    private pyramidShootProjectiles shootStunShot;


    // scripts to disable

    public spawnSludges sludgeScript;
    public spawnGoblins goblinScript;
    public spawnGhostDragons dragonScript;
    public spawnAnubis anubisScript;


    public pyramidStage3 lightningScript;

    public GameObject playerObject;

    private spawnHealthBar healthBarScript;

    private hpStore healthScript;

    private hpStorePlayer playerHealthStore;


    private GameObject whiteScreen;

    private GameObject portalScene;

    private spawnUFO ufoSpawn;
    

    void Awake()
    {
        stage3bool = false;
        stage4bool = false;
        stage5Begun = false;
    }


    // Start is called before the first frame update
    void Start()
    {

        pestilenceSpawner.enabled = true;

        globalLight = GameObject.Find("global light");

        globalLightComponent = globalLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>();

        shootStunShot = GetComponent<pyramidShootProjectiles>();

        stage4Canvas = GameObject.Find("stage4Can");

        stage4Portal = GameObject.Find("stage4Portal_0");

        //pyramidDarknessMap = playerSpotLightStore.S.pyramidDarknessMap;

        globalLightComponent.intensity = 1f;


        song1 = GameObject.Find("anAncientEncounter");
        song2 = GameObject.Find("gottaGetOutOfHere");
        song3 = GameObject.Find("reProminence part 1");
        song4 = GameObject.Find("reProminence part 2");

        

        //playerSpotLight.SetActive(false);

        ufoSpawn = GetComponent<spawnUFO>();

        portalScene = GameObject.Find("stage4Portal_0");

        whiteScreen = GameObject.Find("fadeToWhite");

        // get the health bar components so that they can get enabled during stage 5
        healthBarScript = GetComponent<spawnHealthBar>();

        healthScript = GetComponent<hpStore>();


        cameraScript = Camera.main.GetComponent<cameraFollowPlayer>();

        cameraScript.enabled = false;



        // disable the stage 4 map

        

        playerObject = GameObject.FindGameObjectWithTag("Player");

        playerHealthStore = playerObject.GetComponent<hpStorePlayer>();


        // start stage 2 after 16.5 seconds
        Invoke("stage2", 16.5f);

        hpStorePlayer.S.playerHealth += hpStorePlayer.S.playerHealth * 0.3f;

        

        initialColor = Camera.main.backgroundColor;

        targetColor = new Color(0.5f, 0.4f, 0.3f);

        song1.GetComponent<AudioSource>().Play(); // play An Ancient Encounter
        


        

    }

    

    void stage2()
    {

        //play animation of boss sprite change


        // disable sludge and goblin scripts and enable dragon script
        sludgeScript.enabled = false;
        goblinScript.enabled = false;
        dragonScript.enabled = true;

        Invoke("stage3", 15f); // start stage 2 after 15 seconds


        hpStorePlayer.S.playerHealth += hpStorePlayer.S.playerHealth * 0.3f;

    }

    void stage3()
    {
        stage3bool = true;
        // make map darker

        // add lightning, hail and fire
        lightningScript.enabled = true;

        pyramidStage4Changer.S.pyramidStage3 = true;

        dragonScript.CancelInvoke();
        
        dragonScript.enabled = false;

        shootStunShot.CancelInvoke();

        shootStunShot.enabled = false;



    }

    

    

    void flashBang()
    {

        lightningScript.enabled = false;


        whiteScreen.GetComponent<WhiteScreenOverlay>().enabled = true;

        Invoke("stage4", 2.5f);

        portalScene.GetComponent<SpriteRenderer>().enabled = true;

        portalScene.GetComponent<Animator>().enabled = true;

        playerHealthStore.playerHealth = playerHealthStore.maxHealth;

    }

    void stage4()
    {

        stage3bool = false;

        lightningScript.enabled = true;

        song2.GetComponent<AudioSource>().Play();


        //playerSpotLight.SetActive(true);


        stage4bool = true;

        

        globalLightComponent.enabled = false;

        pestilenceSpawner.enabled = false;

        // play animation of boss sprite change
        sludgeScript.CancelInvoke();
        goblinScript.CancelInvoke();
        anubisScript.CancelInvoke();
        dragonScript.CancelInvoke();


        portalScene.GetComponent<SpriteRenderer>().enabled = false;

        sludgeScript.enabled = false;
        goblinScript.enabled = false;
        anubisScript.enabled = false;
        dragonScript.enabled = false;
        
        cameraScript.enabled = true;

        


        //pyramidDarknessMap.SetActive(true);

        


        song1.GetComponent<AudioSource>().enabled = false;

        




        //song2.SetActive(true);
    }

    void playSong4()
    {
        song4.GetComponent<AudioSource>().Play();
    }

    void stage5()
    {

        song2.GetComponent<AudioSource>().Stop();

        song4.GetComponent<AudioSource>().Stop();


        globalLightComponent.enabled = true;


        song3.GetComponent<AudioSource>().Play();

        Invoke("playSong4", 57f);

        globalLightComponent.intensity = 1f;

        // start spawning UFOs
        ufoSpawn.enabled = true;

        enemiesInRoomChecker.S.enemiesInRoomNumber = 999;




        //pyramidDarknessMap.SetActive(false);

        pestilenceSpawner.enabled = false;
        pestilenceSpawner.CancelInvoke();

        // play animation of boss sprite change
        //cameraScript.enabled = false;

        //transform.localScale = new Vector3(4, 4, 0);

        sludgeScript.CancelInvoke();
        goblinScript.CancelInvoke();
        anubisScript.CancelInvoke();
        dragonScript.CancelInvoke();
        shootStunShot.CancelInvoke();

        sludgeScript.enabled = false;
        goblinScript.enabled = false;
        anubisScript.enabled = false;
        dragonScript.enabled = false;
        shootStunShot.enabled = false;

        healthBarScript.enabled = true;
        healthScript.enabled = true;


        

        // enable charging script
        chargeScript.enabled = true;


        
        
        
    }

    void DeleteAllEnemies()
    {
        // Find all GameObjects with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        // Loop through the array and destroy each enemy
        foreach (GameObject enemy in enemies)
        {
            if (!enemy.name.Contains("sporangium") && !enemy.name.Contains("Pyramid"))
            {
                Destroy(enemy);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        

        

        if (pyramidStage4Changer.S.enemyCap <= 0 && !stage4bool)
        {
            flashBang();
        }

        
        if (stage5Begun && !stage5bool)
        {
            stage5();
            stage5bool = true;
            stage5Begun = false;


            DeleteAllEnemies();

        }
        


        if (stage3bool && globalLightComponent.intensity > 0.3f) // decrease background color 
        {
            globalLightComponent.intensity -= Time.deltaTime;

            Color currentColor = Color.Lerp(initialColor, targetColor, 1/Time.deltaTime);

            Camera.main.backgroundColor = currentColor;
        }
    }
}
