using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerRotation : MonoBehaviour
{

    public Animator swordSpriteAnim;

    public GameObject hurtBoxContainer;

    public int attackingRange = 5;

    private bool onCooldown;

    public GameObject hurtBox;

    public bool hurtBoxEnabled = false;

    private GameObject player;

    private Animation animation;

    public AnimationClip hammerSwingU;

    public AnimationClip hammerSwingL;

    public AnimationClip hammerSwingD;

    public AnimationClip hammerSwingR;

    private bool attacking;

    public SpriteRenderer theHammer;


    void disableHurtBox()
    {
        hurtBox.GetComponent<SpriteRenderer>().enabled = false;
        hurtBox.GetComponent<BoxCollider2D>().enabled = false;
    }

    void enableHurtBox()
    {
        //hurtBox.GetComponent<SpriteRenderer>().enabled = true;
        hurtBox.GetComponent<BoxCollider2D>().enabled = true;
    }


    void coolDown()
    {
        onCooldown = false;
    }


    // Start is called before the first frame update
    void Start()
    {

        


        animation = GetComponent<Animation>();
        player = GameObject.FindWithTag("Player");



        warnPlayer();

        Invoke("turnNormal", 0.2f);
    }

    void turnRed()
    {

        if (gameObject.name.Contains("hammer"))
        {
            swordSpriteAnim.SetBool("warn", true);
        }
    }

    void turnNormal()
    {
        if (gameObject.name.Contains("hammer"))
        {
            swordSpriteAnim.SetBool("warn", false);
        }
    }

    void hammerSwing()
    {

        
        enableHurtBox();
        animation.Play();
        Invoke("disableHurtBox", 0.3f);
        


    }

    void warnPlayer()
    {
            


        if (attacking)
        {
            turnRed();
            Invoke("hammerSwing", 0.7f);
        }

        Invoke("warnPlayer", 1.5f);
        Invoke("turnNormal", 0.5f);
    }

    void attackingOff()
    {
        attacking = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if (distanceToPlayer < attackingRange)
        {
            attacking = true;
        }
        else
        {
            Invoke("attackingOff", 2f);
        }


        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = player.transform.position - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the sprite
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (angle < 45f && angle > -45f)
        {

            
            animation.clip = hammerSwingR;

            Vector3 desiredRotation = new Vector3(0f, 0f, 0f);
            hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

        }
        else if (angle < 135f && angle > 45f)
        {
            
            animation.clip = hammerSwingU;


            Vector3 desiredRotation = new Vector3(0f, 0f, 90f);
            hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

        }
        else if (angle < -45f && angle > -135f)
        {

            
            animation.clip = hammerSwingD;


            Vector3 desiredRotation = new Vector3(0f, 0f, -90f);
            hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

        }
        else
        {

            
            animation.clip = hammerSwingL;


            Vector3 desiredRotation = new Vector3(0f, 0f, 180f);
            hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

        }

    }
}
