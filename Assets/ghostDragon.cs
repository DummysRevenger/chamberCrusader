using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostDragon : MonoBehaviour
{

    private bool randomChosen = false;

    public GameObject warning;

    public GameObject player;

    private GameObject sign;

    private bool destroyWarningFlag;

    public float movementSpeed = 0.2f;

    public bool enemySlowedDown;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (gameObject.name.Contains("thrombus"))
        {
            Invoke("destroyWarning", 11f);
        }
    }


    IEnumerator teleportBack()
    {

        Vector2 newPos = new Vector2(-20f, player.transform.position.y);

        if (gameObject.name.Contains("Left"))
        {
            newPos = new Vector2(20f, player.transform.position.y);

            sign = Instantiate(warning, newPos, Quaternion.identity);

            sign.transform.position = new Vector2(10f, player.transform.position.y);
        }
        else
        {
            newPos = new Vector2(-20f, player.transform.position.y);

            sign = Instantiate(warning, newPos, Quaternion.identity);

            sign.transform.position = new Vector2(-10f, player.transform.position.y);
        }

        

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
            hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * 100f * Time.deltaTime * playerDamageTakenMultiplierStore.damageMultiplier;
        }
    }

    void destroyWarning()
    {
        destroyWarningFlag = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (destroyWarningFlag)
        {
            if (warning != null)
            {
                Destroy(sign);
            }
        }


        if (gameObject.name.Contains("Left"))
        {
            transform.position = new Vector2(transform.position.x - movementSpeed, transform.position.y);

            if (transform.position.x < -15f && !randomChosen)
            {
                randomChosen = true;
                StartCoroutine(teleportBack());
            }
        }
        else
        {


            transform.position = new Vector2(transform.position.x + movementSpeed, transform.position.y);


            if (transform.position.x > 15f && !randomChosen)
            {
                randomChosen = true;
                StartCoroutine(teleportBack());
            }
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
