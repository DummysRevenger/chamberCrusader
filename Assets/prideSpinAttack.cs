using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prideSpinAttack : MonoBehaviour
{

    private bool isCooldown = false;
    private float cooldownDuration = 20f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    public static prideSpinAttack S;

    public AudioSource audioSource;

    public GameObject cross1;

    public GameObject hugeSwordAxis;

    public GameObject hugeSwordObject;

    public AnimationClip swordSpinClip;

    public Animation animationComponent;

    public BoxCollider2D swordCollider;

    public bool swordSpinning = false;

    public swordRotation swordScript;




    // Start is called before the first frame update
    void Start()
    {
        S = this;

        audioSource = GetComponent<AudioSource>();

        animationComponent = hugeSwordAxis.GetComponent<Animation>();

        animationComponent = hugeSwordAxis.GetComponent<Animation>();

        swordScript = hugeSwordAxis.GetComponent<swordRotation>();

    }

    void goOff()
    {
        swordSpinning = false;
        swordScript.enabled = true;
        swordCollider.enabled = true;
        swordCollider.enabled = false;
    }



    void Update()
    {

        if (swordSpinning)
        {
            animationComponent.clip = swordSpinClip;


            
        }


        if (!isCooldown && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G)))
        {

            audioSource.Play(); // Play the clip

            swordCollider.enabled = true;

            swordSpinning = true;

            swordScript.enabled = false;

            swordCollider.enabled = true;

            // F key has been pressed down and cooldown is not active
            // Perform your desired actions here

            Invoke("goOff", 5f);

            cross1.SetActive(true);

            // Start the cooldown
            isCooldown = true;
            cooldownTimer = cooldownDuration;




            animationComponent.clip = swordSpinClip;

            animationComponent.Play();




        }

        // Update the cooldown timer
        if (isCooldown)
        {

            

            if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }

            if (cooldownTimer <= 0.0f)
            {
                // Cooldown is over
                isCooldown = false;

                cross1.SetActive(false);
            }
        }
    }
}
