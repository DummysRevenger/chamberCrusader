using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jealousyBlast : MonoBehaviour
{

    public GameObject theLaser;

    public GameObject LaserPrefab;

    private Quaternion targetRotation;

    private bool isCooldown;

    private bool laserOn;

    private float angle;

    public GameObject cross1;

    private float cooldownTimer = 10f;

    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void endAbility()
    {
        Destroy(theLaser);

        laserOn = false;
    }


    private void FaceTheMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        Vector3 aimDirection = (worldMousePosition - transform.position).normalized;

        
        

        // Calculate the angle between the game object and the player
        angle = Mathf.Atan2( worldMousePosition.y - transform.position.y , worldMousePosition.x - transform.position.x ) * Mathf.Rad2Deg;

        // Rotate the game object to face the player
        targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void endCooldown()
    {
        isCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isCooldown && (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.E)))
        {

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            Invoke("endAbility", 2f);

            theLaser = Instantiate(LaserPrefab, transform.position, transform.rotation);

            laserOn = true;

            isCooldown = true;

            Invoke("endCooldown", cooldownTimer);
            

        }
        
        if (isCooldown)
        {
            cross1.SetActive(true);
        }
        else
        {
            cross1.SetActive(false);
        }

        if (laserOn)
        {
            if (theLaser != null)
            {


                FaceTheMouse();
                theLaser.transform.rotation = Quaternion.RotateTowards(theLaser.transform.rotation, targetRotation, 1000 * Time.deltaTime);
            }
        }
    }
}
