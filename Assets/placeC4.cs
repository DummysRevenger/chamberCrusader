using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placeC4 : MonoBehaviour
{
    private float timer = 0f;

    private bool isCooldown = false;
    private float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    private bool bombPlaced = false;

    public GameObject bomb;

    public GameObject cross3;

    // Start is called before the first frame update
    void Start()
    {
        cross3 = GameObject.Find("crossUI3");
    }

    void resetBombPlaced()
    {
        bombPlaced = true;
    }

    // Update is called once per frame
    void Update()
    {

        
        


        if (!isCooldown)
        {
            

            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G))
            {

                if (!bombPlaced)
                {
                    isCooldown = true;

                    cooldownTimer = cooldownDuration;

                    // place bomb
                    Instantiate(bomb, transform.position, transform.rotation);

                    timer = 0;

                    Invoke("resetBombPlaced", 0.5f);

                    cooldownTimer = 5f;

                    
                }
                else
                {
                    bombPlaced = false;
                }


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
                
                isCooldown = false;

                cross3.GetComponent<Image>().enabled = true;
            }
        }


    }
}
