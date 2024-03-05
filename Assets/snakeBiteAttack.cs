using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBiteAttack : MonoBehaviour
{

    public OrbitPlayer orbitScript;
    public Transform player;
    private float moveSpeed = 5f;

    public GameObject openMouth;

    private GameObject openMouthInstance;

    public GameObject biteDown;

    public GameObject biteDownInstance;

    // Start is called before the first frame update
    void Start()
    {
        // disable sprite renderer
        GetComponent<SpriteRenderer>().enabled = false;

        openMouthInstance = Instantiate(openMouth, transform);

        orbitScript.enabled = false;


    }

    IEnumerator reEnableOrbitScript()
    {
        yield return new WaitForSeconds(0.5f);

        Destroy(biteDownInstance);

        orbitScript.enabled = true;

        enabled = false;
    }

    

    void InstantBiteDown()
    {
        Destroy(openMouthInstance);
        // create an instance of the bite down animation
        biteDownInstance = Instantiate(biteDown, transform);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("sword"))
        {
            

            StartCoroutine(reEnableOrbitScript());



        }

        Debug.Log("colliding");

        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("colliding with player");

            if (openMouthInstance != null)
            {
                InstantBiteDown();
            }

        }


    }



    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);


        // make the object face the player

        // Get the direction from the current position to the player position
        Vector3 direction = player.position - transform.position;

        // Calculate the angle of rotation in radians
        float angle = Mathf.Atan2(direction.y, direction.x);

        // Create a rotation quaternion with only Z rotation
        Quaternion rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);

        // Apply the rotation to the object
        transform.rotation = rotation;


        if (openMouthInstance != null)
        {
            openMouthInstance.transform.position = transform.position;
            openMouthInstance.transform.rotation = transform.rotation;

        }

        if (biteDownInstance != null)
        {
            biteDownInstance.transform.position = transform.position;
            biteDownInstance.transform.rotation = transform.rotation;
        }




       




        // make the open mouth instance face the player
        //openMouthInstance.transform.LookAt(positionToLookAt);






    }
}
