using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchFireWork : MonoBehaviour
{
    private float timer = 0f;

    private bool isCooldown = false;
    private float cooldownDuration = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    public GameObject fireWork;

    private Vector2 aimDirection;

    private Vector2 randomOffset;

    public GameObject cross1;



    // Start is called before the first frame update
    void Start()
    {

    }

    
    void SpawnFireWork()
    {
        Instantiate(fireWork, transform.position, transform.rotation);
    }



    // Update is called once per frame
    void Update()
    {


        if (!isCooldown)
        {
            if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G)))
            {

                    isCooldown = true;
                    cooldownTimer = cooldownDuration;

                SpawnFireWork();

                cross1.SetActive(true);

                Invoke("SpawnFireWork", 2f);
                Invoke("SpawnFireWork", 4f);



                timer = 0;
                    
                    
                
            }
        }
        else
        {

            if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }

            if (cooldownTimer <= 0.0f)
            {

                cross1.SetActive(false);

                isCooldown = false;
            }
        }


    }
}
