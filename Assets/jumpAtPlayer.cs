using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpAtPlayer : MonoBehaviour
{

    public bool enemySlowedDown;

    private Animator animatorComponent;

    public GameObject wormHidePrefab;

    public GameObject wormHideObject;

    public GameObject wormEmergePrefab;

    public GameObject wormEmergeObject;

    public GameObject levHidePrefab;

    public GameObject levHideObject;

    public GameObject levEmergePrefab;

    public GameObject levEmergeObject;

    private GameObject player;

    private Vector3 playerPos;

    private bool jumping = true;

    private int randomX;

    private int randomY;

    private Vector3 posToMove;

    private bool playerPosFound;

    private float reachedThreshold = 0.5f;

    public GameObject warningPrefab;

    public GameObject theWarning;

    public float movementSpeed;


    private bool isInvoking = false;

    private Vector3 positionToTeleport;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();


        animatorComponent = GetComponent<Animator>();

        if (gameObject.name.Contains("worm"))
        {
            movementSpeed = 9f;
        }
        else
        {
            movementSpeed = 6f;
        }

        player = GameObject.FindGameObjectWithTag("Player");



        findPlayerPos();
    }


    

    void findPlayerPos()
    {
        playerPos = player.transform.position;
    }

    void delayDeleteWormHide()
    {
        Destroy(wormHideObject);
    }

    void delayDeleteLevHide()
    {
        Destroy(levHideObject);
    }


    void disappear()
    {

        if (gameObject.name.Contains("worm"))
        {
            wormHideObject = Instantiate(wormHidePrefab, transform.position, transform.rotation);

            Invoke("delayDeleteWormHide", 0.5f);
        }
        else if (gameObject.name.Contains("Leviathan"))
        {
            levHideObject = Instantiate(levHidePrefab, transform.position, transform.rotation);

            Invoke("delayDeleteLevHide", 0.5f);
        }


        audioSource.Play();
        

        if (!isInvoking) // only one invoke is allowed at a time
        {
            Invoke("warn", 1f);

            isInvoking = true;
        }

        
        

        jumping = false;

        transform.position = new Vector3(999f, 999f, 0f);





    }


    void warn()
    {

        randomX = Random.Range(-9, 9);

        randomY = Random.Range(-5, 5);

        positionToTeleport = new Vector3(randomX, randomY, 0f);

        theWarning = Instantiate(warningPrefab, positionToTeleport, transform.rotation);

        Invoke("reAppear", 1f);


    }

    public void deleteWarning()
    {
        Destroy(theWarning);
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.name.Contains("Leviathan"))
            {
                hpStorePlayer.S.playerHealth -= 80;
            }
            else
            {
                hpStorePlayer.S.playerHealth -= 40;
            }
        }
    }

    void reAppear()
    {
        findPlayerPos();



        audioSource.Play();

        transform.position = positionToTeleport;

        jumping = true;

        isInvoking = false; // set to false so that it can reappear again


        if (theWarning != null)
        {
            Destroy(theWarning);
        }
        

    }



    // Update is called once per frame
    void Update()
    {



        

        if (jumping) // do this only when jumping so that means it has reappeared
        {

            
            if (gameObject.name.Contains("worm"))
            {
                Vector3 posToMove = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * movementSpeed);
                transform.position = posToMove;
            }
            else
            {
                Vector3 posToMove = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * movementSpeed);
                transform.position = posToMove;

            }
            
            
        }



        if ((Vector3.Distance(transform.position, playerPos) <= reachedThreshold) && jumping)
        {
            disappear();
        }


        

    }


}