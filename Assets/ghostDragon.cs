using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostDragon : MonoBehaviour
{

    private bool randomChosen = false;

    public GameObject warning;

    public GameObject player;

    private GameObject sign;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    IEnumerator teleportBack()
    {

        

        Vector2 newPos = new Vector2(-20f, player.transform.position.y);

        sign = Instantiate(warning, newPos, Quaternion.identity);

        sign.transform.position = new Vector2(-10f, player.transform.position.y);


        

        randomChosen = true;

        yield return new WaitForSeconds(1f);

        Destroy(sign);

        randomChosen = false;

        transform.position = newPos;


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Check if the collided object is the player
        if (collision.CompareTag("Player"))
        {

            // Inflict damage on the player

            
            
            
                hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * 10f;
            

        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        

        transform.position = new Vector2(transform.position.x + 0.2f, transform.position.y) ;

        if (transform.position.x > 15f && !randomChosen)
        {
            randomChosen = true;
            StartCoroutine(teleportBack());
        }

        if (enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
        {
            pointsStore.S.points = pointsStore.S.points + 300 + (nextRoomChecker.S.roomNumber - 1) * 50;
            Destroy(sign);

            hpStore hpComponent = GetComponent<hpStore>();
            hpComponent.getDestroyed();

            enabled = false;



        }
    }
}
