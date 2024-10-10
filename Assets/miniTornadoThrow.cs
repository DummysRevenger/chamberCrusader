using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniTornadoThrow : MonoBehaviour
{

    private GameObject player;

    private Rigidbody2D playerRb2d;

    private bool startPosCalculated = false;

    private bool playerTouchedTornado = false;

    private float angle;

    private bool playerBeingThrown = false;



    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            playerIsTrappedStore.S.isTrapped = true;

            Invoke("throwPlayer", 1.6f);
            

            //attractPlayertoCentre();

            playerTouchedTornado = true;

            



        }
    }

    // Start is called before the first frame update
    void Start()
    {


        player = GameObject.FindGameObjectWithTag("Player");

        playerRb2d = player.GetComponent<Rigidbody2D>();
    }

    void attractPlayertoCentre()
    {
        Vector3 newPosition = Vector3.MoveTowards(player.transform.position, transform.position, Time.deltaTime * 2);

        player.transform.position = newPosition;


    }

    void makePlayerOrbit()
    {

        if (!playerBeingThrown)
        {
            // work out start position and therefore start angle
            if (!startPosCalculated)
            {
                float startY = transform.position.y - player.transform.position.y;
                float startX = transform.position.x - player.transform.position.x;



                startPosCalculated = true;

                angle = Mathf.Atan2(startY, startX) - Mathf.PI;

                Debug.Log("start angle = " + angle);
            }



            angle += 4 * Time.deltaTime;

            float yPos = transform.position.y + Mathf.Sin(angle) * 1f;
            float xPos = transform.position.x + Mathf.Cos(angle) * 1f;







            player.transform.position = new Vector3(xPos, yPos, 0f);

            //player.transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));


        }
        
    }

    


    void OnTriggerExit2D(Collider2D other)
    {
        startPosCalculated = false;
        
    }


    void goOffCooldown()
    {
        playerBeingThrown = false;
        playerTouchedTornado = false;
    }

    void throwPlayer()
    {
        Invoke("goOffCooldown", 1.66f);

        playerBeingThrown = true;


        int randomX = Random.Range(1, 2);
        int randomY = Random.Range(1, 2);

        int randomDirectionX = Random.Range(0, 2) == 0 ? -1 : 1;

        int randomDirectionY = Random.Range(0, 2) == 0 ? -1 : 1;

        

        Vector2 direction = new Vector2(randomX * randomDirectionX, randomY * randomDirectionY);

        playerRb2d.AddForce(direction * 299999f, ForceMode2D.Impulse);

        playerIsTrappedStore.S.unTrap();

    }


    // Update is called once per frame
    void Update()
    {
        

        if (playerTouchedTornado)
        {
            makePlayerOrbit();
        }
    }
}
