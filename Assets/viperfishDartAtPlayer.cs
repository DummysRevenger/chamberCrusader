using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viperfishDartAtPlayer : MonoBehaviour
{

    private Transform player;

    public GameObject attackObject;

    public GameObject actualAttackObject;

    public GameObject animSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FaceThePlayer();
    }


    private void disappear()
    {
        transform.position = new Vector3(99999f, 99999f, 99999f);

        GetComponent<SpriteRenderer>().enabled = true;
    }


    public void delayAttack()
    {
        Invoke("attack", 1.25f);

        

        Invoke("disappear", 2f);
    }


    private void attack()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        actualAttackObject = Instantiate(attackObject, animSpawnPoint.transform.position, transform.rotation);

        
    }

    private void FaceThePlayer()
    {
        // Get the player's position
        Vector3 playerPosition = player.position;

        // Get the game object's position
        Vector3 gameObjectPosition = transform.position;

        // Calculate the angle between the game object and the player
        float angle = Mathf.Atan2(playerPosition.y - gameObjectPosition.y, playerPosition.x - gameObjectPosition.x) * Mathf.Rad2Deg;

        // Rotate the game object to face the player
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


}
