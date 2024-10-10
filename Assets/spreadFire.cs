using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spreadFire : MonoBehaviour
{

    private Rigidbody2D rigidbody;

    private Vector3 direction;

    public GameObject firePrefab;

    private GameObject player;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();


        player = GameObject.FindGameObjectWithTag("Player");



        rigidbody.velocity = Vector3.zero;


        StartCoroutine(spawnFire());

        audioSource = GetComponent<AudioSource>();

    }

    IEnumerator spawnFire()
    {

        Vector2 direction = (player.transform.position - transform.position).normalized;

        //audioSource.Play();

        for (int i = 0; i < 14; i++)
        {

            Vector3 nextPos = new Vector3(direction.x * i, direction.y * i, 0f);

            Vector3 spawnPoint = transform.position + nextPos;


            yield return new WaitForSeconds(0.2f);

            Instantiate(firePrefab, spawnPoint, transform.rotation);

        }

        StartCoroutine(spawnFire());
    }


    void fireSpawnCooldown()
    {

    }


    // Update is called once per frame
    void Update()
    {
        




    }
}
