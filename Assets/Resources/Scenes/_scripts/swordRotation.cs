using System.Collections;
using UnityEngine;

public class swordRotation : MonoBehaviour
{
    private Vector3 rotationAxis = Vector3.forward;

    public AnimationClip rotateRightAnimation;
    public AnimationClip rotateUpAnimation;
    public AnimationClip rotateLeftAnimation;
    public AnimationClip rotateDownAnimation;

    public AnimationClip katanaRightAnimation;
    public AnimationClip katanaUpAnimation;
    public AnimationClip katanaLeftAnimation;
    public AnimationClip katanaDownAnimation;

    public AnimationClip knifeR;
    public AnimationClip knifeU;
    public AnimationClip knifeL;
    public AnimationClip knifeD;


    public GameObject hurtBoxContainer;

    public GameObject hurtBox;

    public bool hurtBoxEnabled = false;

    public Animation animation;

    public bool onCooldown = false;

    void disableHurtBox()
    {
        

        hurtBox.GetComponent<SpriteRenderer>().enabled = false;
        hurtBox.GetComponent<BoxCollider2D>().enabled = false;


    }

    void coolDown()
    {
        onCooldown = false;
    }


    void Start()
    {
        animation = GetComponent<Animation>();
        hurtBox.GetComponent<SpriteRenderer>().enabled = false;
        hurtBox.GetComponent<BoxCollider2D>().enabled = false;
    }

    void FixedUpdate()
    {

        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the sprite
        transform.rotation = Quaternion.AngleAxis(angle+60f, Vector3.forward);


        if (Input.GetMouseButton(0) && !onCooldown)
        {
            
            hurtBox.GetComponent<BoxCollider2D>().enabled = true;


            onCooldown = true;

            statsStore.swings++;

            if (playerSwitcher.S.playerType == "knight")
            {
                Invoke("coolDown", 0.6f);
            }
            else if (playerSwitcher.S.playerType == "ninja")
            {
                Invoke("coolDown", 0.3f);
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                Invoke("coolDown", 0.2f);
            }
            else if(playerSwitcher.S.playerType == "bunny")
            {
                Invoke("coolDown", 1.2f);
            }


                Invoke("disableHurtBox", 0.15f);

            

            

            

            if (angle < 45f && angle > -45f)
            {





                if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny")
                {
                    animation.clip = rotateRightAnimation;
                }
                else if (playerSwitcher.S.playerType == "ninja")
                {
                    animation.clip = katanaRightAnimation;
                }
                else if (playerSwitcher.S.playerType == "soldier")
                {
                    animation.clip = knifeR;
                }


                Vector3 desiredRotation = new Vector3(0f, 0f, 0f);
                hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

            }
            else if(angle < 135f && angle > 45f)
            {




                if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny")
                {
                    animation.clip = rotateUpAnimation;
                }
                else if (playerSwitcher.S.playerType == "ninja")
                {
                    animation.clip = katanaUpAnimation;
                }
                else if (playerSwitcher.S.playerType == "soldier")
                {
                    
                    animation.clip = knifeU;
                }


                Vector3 desiredRotation = new Vector3(0f, 0f, 90f);
                hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

            }
            else if(angle < -45f && angle > -135f)
            {




                if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny")
                {
                    animation.clip = rotateDownAnimation;
                }
                else if (playerSwitcher.S.playerType == "ninja")
                {
                    animation.clip = katanaDownAnimation;
                }
                else if (playerSwitcher.S.playerType == "soldier" )
                {

                    animation.clip = knifeD;
                }


                Vector3 desiredRotation = new Vector3(0f, 0f, -90f);
                hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

            }
            else
            {
                

                if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny")
                {
                    animation.clip = rotateLeftAnimation;
                }
                else if (playerSwitcher.S.playerType == "ninja")
                {
                    animation.clip = katanaLeftAnimation;
                }
                else if (playerSwitcher.S.playerType == "soldier")
                {

                    animation.clip = knifeL;
                }



                Vector3 desiredRotation = new Vector3(0f, 0f, 180f);
                hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

            }

            animation.Play();

        }
    }


}