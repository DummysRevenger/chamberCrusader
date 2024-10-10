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

    public AnimationClip hugeSwordU;
    public AnimationClip hugeSwordR;
    public AnimationClip hugeSwordL;
    public AnimationClip hugeSwordD;

    private int wrathSwingCount = 0;


    public GameObject gauntletHitBox;
    

    public AnimationClip prideSwordThrust;

    public GameObject prideSwordObject;

    public bool swordIsSwinging = false;

    public bool swordIsThrusting = false;


    public GameObject hurtBoxContainer;

    

    public GameObject hurtBox;

    public GameObject thrustHitBox;

    


    public bool hurtBoxEnabled = false;

    public Animation animation;

    public Animation animation2;

    public Animation spearAnimation;

    public Animation LeftGauntletAnim;

    public Animation RightGauntletAnim;



    public bool onCooldown = false;

    public float cooldown;

    public GameObject scytheRay;

    public GameObject gauntletHitBoxContainer;

    public GameObject wrathHurtBox;

    public BoxCollider2D spearCollider;

    public GameObject wrathFireBall;


    void disableHurtBox()
    {
        hurtBox.GetComponent<SpriteRenderer>().enabled = false;
        hurtBox.GetComponent<BoxCollider2D>().enabled = false;

        if (playerSwitcher.S.playerType == "pride")
        {
            thrustHitBox.GetComponent<BoxCollider2D>().enabled = false;

        }
        else if (playerSwitcher.S.playerType == "sloth")
        {
            spearCollider.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (playerSwitcher.S.playerType == "lust")
        {
            
            Invoke("disableGauntletHitBox", 0.25f);
        }
        else if (playerSwitcher.S.playerType == "wrath")
        {
            wrathHurtBox.GetComponent<BoxCollider2D>().enabled = false;

            
        }


    }

    void disableGauntletHitBox()
    {
        gauntletHitBox.GetComponent<BoxCollider2D>().enabled = false;
    }

    void enableGauntletHitBox()
    {
        gauntletHitBox.GetComponent<BoxCollider2D>().enabled = true;
    }

    void coolDown()
    {
        onCooldown = false;
    }


    void Start()
    {

        switch(playerSwitcher.S.playerType)
        {
            case "knight":
                cooldown = 0.6f;
                break;
            case "ninja":
                cooldown = 0.3f;
                break;
            case "soldier":
                cooldown = 0.2f;
                break;
            case "bunny":
                cooldown = 1.2f;
                break;
            case "shop":
                if (gameObject.name.Contains("walkingCane"))
                {
                    cooldown = 0.8f;
                }
                else if (gameObject.name.Contains("longSword"))
                {
                    cooldown = 1.2f;
                }
                else if (gameObject.name.Contains("scythe"))
                {
                    cooldown = 1f;
                }
                else if (gameObject.name.Contains("Dagger"))
                {
                    cooldown = 1f;
                }
                break;
            case "pride":
                cooldown = 1.5f;
                break;
            case "sloth":
                cooldown = 2f;
                break;
            case "lust":
                cooldown = 1f;
                break;
            case "wrath":
                cooldown = 0.3f;
                break;
        }

        

        if (GetComponent<Animation>() != null)
        {
            animation = GetComponent<Animation>();
        }
        hurtBox.GetComponent<SpriteRenderer>().enabled = false;
        hurtBox.GetComponent<BoxCollider2D>().enabled = false;
    }

    void delayRightGauntlet()
    {
        RightGauntletAnim.Play();
    }



    void StartThrust()
    {
        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;




        if (thrustHitBox != null)
        {
            thrustHitBox.GetComponent<BoxCollider2D>().enabled = true;

            animation2.Play();

            Invoke("disableHurtBox", 0.05f);
        }

       if (spearCollider != null)
       {


            spearCollider.GetComponent<BoxCollider2D>().enabled = true;

            Invoke("disableHurtBox", 0.1f);


            spearAnimation.Play();

            

       }

        if (gauntletHitBox != null)
        {
            gauntletHitBox.GetComponent<BoxCollider2D>().enabled = true;



            

            gauntletHitBoxContainer.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            LeftGauntletAnim.Play();

            Invoke("disableGauntletHitBox", 0.2f);

            Invoke("enableGauntletHitBox", 0.4f);

            Invoke("delayRightGauntlet", 0.4f);
        }


        
        

        Invoke("coolDown", 1f);




    }

    void Update()
    {

        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        
        if (playerSwitcher.S.playerType == "pride")
        {

            if (!prideSpinAttack.S.swordSpinning)
            {
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
        else if (playerSwitcher.S.playerType == "sloth"
           || playerSwitcher.S.playerType == "lust")
        {
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            
        }
        else
        {
            
            transform.rotation = Quaternion.AngleAxis(angle + 60f, Vector3.forward);
        }

        



        if (playerSwitcher.S.playerType == "bunny")
        {
            if (!rampageAbility.S.abilityRunning)
            {
                cooldown = 1.2f;
            }
            else
            {
                cooldown = 0.5f;
            }
        }

        if (playerSwitcher.S.playerType == "wrath")
        {
            if (!wrathEnrageAbility.S.abilityRunning)
            {
                cooldown = 0.3f;
            }
            else
            {
                cooldown = 0.2f;
            }
        }

        if (Input.GetMouseButton(0) && !onCooldown)
        {





            if (selectCharacter.characterSelected == "wrath")
            {
                if (wrathEnrageAbility.S.abilityRunning != null)
                {
                    if (wrathSwingCount == 3)
                    {

                        if (!wrathEnrageAbility.S.abilityRunning)
                        {

                            Vector3 mousePosition1 = Input.mousePosition;
                            Vector3 worldMousePosition1 = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition1.x, mousePosition1.y, transform.position.z - Camera.main.transform.position.z));

                            Vector3 aimDirection = (worldMousePosition1 - transform.position).normalized;


                            // spawn wrathBullet
                            GameObject bullet = Instantiate(wrathFireBall, transform.position, transform.rotation);



                            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                            bulletRigidbody.velocity = 12f * aimDirection;



                            wrathSwingCount = 0;
                        }

                    }
                    else
                    {
                        wrathSwingCount++;
                    }
                }
            }

            


            onCooldown = true;

            statsStore.swings++;

            
            
                Invoke("coolDown", cooldown);
            


                

            if (gameObject.name.Contains("spear"))
            {
                StartThrust();

                Invoke("disableHurtBox", 0.1f);
            }
            else if (!gameObject.name.Contains("lustGauntlet"))
            {
                if (hurtBox != null)
                {
                    hurtBox.GetComponent<BoxCollider2D>().enabled = true;
                }

                Invoke("disableHurtBox", 0.15f);


                if (gameObject.name.Contains("scythe"))
                {



                    Vector3 aimDirection = (worldMousePosition - transform.position).normalized;


                    for (int i = -1; i < 2; i++)
                    {
                        GameObject bullet4 = Instantiate(scytheRay, transform.position, Quaternion.identity);
                        Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();

                        Vector3 spreadRotation = new Vector3(0.2f * i, 0.2f * i, 0f);

                        bulletRigidbody4.velocity = 10f * (aimDirection + spreadRotation).normalized;
                    }
                }



                if (angle < 45f && angle > -45f)
                {





                    if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny"
                        || (playerSwitcher.S.playerType == "shop" && (shopKeeperWeaponRandomiser.S.theWeapon == "cane" ||
                        shopKeeperWeaponRandomiser.S.theWeapon == "longSword" || shopKeeperWeaponRandomiser.S.theWeapon == "scythe")))
                    {
                        animation.clip = rotateRightAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "ninja")
                    {
                        animation.clip = katanaRightAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "soldier" || (playerSwitcher.S.playerType == "shop"
                        && weaponSwitch.S.weaponEquipped == 3) || playerSwitcher.S.playerType == "wrath")
                    {
                        animation.clip = knifeR;
                    }
                    else if (playerSwitcher.S.playerType == "pride")
                    {
                        animation.clip = hugeSwordR;
                    }


                    Vector3 desiredRotation = new Vector3(0f, 0f, 0f);
                    hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

                }
                else if (angle < 135f && angle > 45f)
                {




                    if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny"
                        || (playerSwitcher.S.playerType == "shop" && (shopKeeperWeaponRandomiser.S.theWeapon == "cane" ||
                        shopKeeperWeaponRandomiser.S.theWeapon == "longSword" || shopKeeperWeaponRandomiser.S.theWeapon == "scythe")))
                    {
                        animation.clip = rotateUpAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "ninja")
                    {
                        animation.clip = katanaUpAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "wrath" || playerSwitcher.S.playerType == "soldier" ||
                        (playerSwitcher.S.playerType == "shop"
                         && weaponSwitch.S.weaponEquipped == 3))
                    {

                        animation.clip = knifeU;
                    }
                    else if (playerSwitcher.S.playerType == "pride")
                    {
                        animation.clip = hugeSwordU;
                    }


                    Vector3 desiredRotation = new Vector3(0f, 0f, 90f);
                    hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

                }
                else if (angle < -45f && angle > -135f)
                {




                    if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny"
                        || (playerSwitcher.S.playerType == "shop" && (shopKeeperWeaponRandomiser.S.theWeapon == "cane" ||
                        shopKeeperWeaponRandomiser.S.theWeapon == "longSword" || shopKeeperWeaponRandomiser.S.theWeapon == "scythe")))
                    {
                        animation.clip = rotateDownAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "ninja")
                    {
                        animation.clip = katanaDownAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "wrath" || playerSwitcher.S.playerType == "soldier" ||
                        (playerSwitcher.S.playerType == "shop"
                         && weaponSwitch.S.weaponEquipped == 3))
                    {
                        animation.clip = knifeD;
                    }
                    else if (playerSwitcher.S.playerType == "pride")
                    {
                        animation.clip = hugeSwordD;
                    }


                    Vector3 desiredRotation = new Vector3(0f, 0f, -90f);
                    hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

                }
                else
                {


                    if (playerSwitcher.S.playerType == "knight" || playerSwitcher.S.playerType == "bunny"
                        || (playerSwitcher.S.playerType == "shop" && (shopKeeperWeaponRandomiser.S.theWeapon == "cane" ||
                        shopKeeperWeaponRandomiser.S.theWeapon == "longSword" || shopKeeperWeaponRandomiser.S.theWeapon == "scythe")))
                    {
                        animation.clip = rotateLeftAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "ninja")
                    {
                        animation.clip = katanaLeftAnimation;
                    }
                    else if (playerSwitcher.S.playerType == "wrath" || playerSwitcher.S.playerType == "soldier" ||
                        (playerSwitcher.S.playerType == "shop"
                         && weaponSwitch.S.weaponEquipped == 3))
                    {

                        animation.clip = knifeL;
                    }
                    else if (playerSwitcher.S.playerType == "pride")
                    {
                        animation.clip = hugeSwordL;
                    }



                    Vector3 desiredRotation = new Vector3(0f, 0f, 180f);
                    hurtBoxContainer.transform.rotation = Quaternion.Euler(desiredRotation);

                }
            }
            else
            {
                StartThrust();

                Invoke("disableHurtBox", 0.4f);

                
            }

            if (animation != null)
            {
                animation.Play();
            }

        }
        else if (Input.GetMouseButtonDown(1) && !onCooldown)
        {

            StartThrust();

            
        }
    }


}