using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enemyTakeDamage : MonoBehaviour
{

    public UnityEvent OnBegin, OnDone;

    public Rigidbody2D rb2d;

    public GameObject bloodGoblinPrefab;

    public bool hitWall = false;

    private GameObject heartObject;

    private GameObject coin;
    private GameObject smallNote;
    private GameObject bigNote;
    private GameObject bar;


    private bool onWrathFire;

    private int randomNumber;

    

    private void Reset()
    {

        rb2d.velocity = Vector3.zero;
        OnDone?.Invoke();


        

    }


    // Start is called before the first frame update
    void Start()
    {

        string bigBankPath = "Scenes/update11Resources/newprefabs/cash/bigBankNote";
        string goldBarPath = "Scenes/update11Resources/newprefabs/cash/goldBar";
        string smallBankPath = "Scenes/update11Resources/newprefabs/cash/smallBankNote";
        string goldCoinPath = "Scenes/update11Resources/newprefabs/cash/goldCoin";

        bigNote = Resources.Load(bigBankPath) as GameObject;
        bar = Resources.Load(goldBarPath) as GameObject;
        smallNote = Resources.Load(smallBankPath) as GameObject;
        coin = Resources.Load(goldCoinPath) as GameObject;


        rb2d = GetComponent<Rigidbody2D>();


        heartObject = Resources.Load("Scenes/update12Resources/lust/lustHeart") as GameObject;


        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("ninjadragon") && (!gameObject.name.Contains("Boss") && !gameObject.name.Contains("Pyramid")))
        {
            gameObject.GetComponent<hpStore>().health -= 100;
        }
    }

    void enableMovement()
    {
        if (gameObject.GetComponent<meleeEnemy>() != null)
        {
            gameObject.GetComponent<meleeEnemy>().Webbed = false;

            

        }
        else if (gameObject.GetComponent<randomMovementAdvanced>() != null)
        {
            gameObject.GetComponent<randomMovementAdvanced>().enabled = true;



            gameObject.GetComponent<randomMovementAdvanced>().Webbed = false;
        }
        else if (gameObject.GetComponent<jumpAtPlayer>() != null)
        {
            gameObject.GetComponent<jumpAtPlayer>().enabled = true;
        }
        else if (gameObject.GetComponent<spiderJumpAtPlayer>() != null)
        {
            gameObject.GetComponent<spiderJumpAtPlayer>().enabled = true;
        }
    }

    void disableMovement()
    {
        if (CompareTag("enemy")
            || CompareTag("rangedEnemy"))
        {
            if (GetComponent<meleeEnemy>() != null)
            {


                GetComponent<meleeEnemy>().Webbed = true;



            }
            else if (GetComponent<randomMovementAdvanced>() != null)
            {


                GetComponent<randomMovementAdvanced>().Webbed = true;

                GetComponent<Rigidbody2D>().velocity = Vector3.zero;


                GetComponent<randomMovementAdvanced>().enabled = false;
            }
            else if (GetComponent<jumpAtPlayer>() != null)
            {
                GetComponent<jumpAtPlayer>().enabled = false;
            }
            else if (GetComponent<spiderJumpAtPlayer>() != null)
            {
                GetComponent<spiderJumpAtPlayer>().enabled = false;
            }

            CancelInvoke("enableMovement");



            Invoke("enableMovement", 0.3f);
        }

    }



    void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.gameObject.name.Contains("greedArrow"))
        {
            gameObject.GetComponent<hpStore>().health -= 70;

                randomNumber = Random.Range(0, 100);

                if (randomNumber > 20 && randomNumber < 70)
                {
                    Instantiate(coin, transform.position, transform.rotation);
                }
                else if (randomNumber < 90)
                {
                    Instantiate(smallNote, transform.position, transform.rotation);
                }
                else if (randomNumber <= 99)
                {
                    Instantiate(bigNote, transform.position, transform.rotation);
                }
                
            
        }
        if (collision.gameObject.name.Contains("wrathExplosionSmall"))
        {
            gameObject.GetComponent<hpStore>().health -= 100;
            onWrathFire = true;
            cancelUnWrathFire();
            Invoke("unWrathFire", 2f);


        }
        if (collision.gameObject.name.Contains("wrathExplosionBig"))
        {
            gameObject.GetComponent<hpStore>().health -= 400;
            onWrathFire = true;
            cancelUnWrathFire();
            Invoke("unWrathFire", 2f);
        }
        else if (collision.gameObject.name.Contains("lustExplosion"))
        {
            gameObject.GetComponent<hpStore>().health -= 150;
        }
        else if (collision.gameObject.name.Contains("ninjadragon") && (gameObject.name.Contains("Boss") || gameObject.name == ("the Pyramid")))
        {
            gameObject.GetComponent<hpStore>().health -= 200;
        }
        else if (collision.gameObject.name.Contains("shield") || collision.gameObject.name.Contains("playerBullet") ||
            collision.gameObject.CompareTag("sword") || collision.gameObject.CompareTag("boom"))
        {



            // collision for ninja slashes
            if (collision.gameObject.CompareTag("sword") || (collision.gameObject.name.Contains("ninjadragon")) || (collision.gameObject.name.Contains("slash")))
            {
                if ((collision.gameObject.name.Contains("1")))
                {
                    gameObject.GetComponent<hpStore>().health -= 65 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if ((collision.gameObject.name.Contains("2")))
                {
                    gameObject.GetComponent<hpStore>().health -= 130 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if ((collision.gameObject.name.Contains("3")))
                {
                    gameObject.GetComponent<hpStore>().health -= 200 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if ((collision.gameObject.name.Contains("4")))
                {
                    gameObject.GetComponent<hpStore>().health -= 400 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }

            }


            // collision for shield and sword
            if (collision.gameObject.CompareTag("sword") || (collision.gameObject.name.Contains("shield")))
            {

                if (!gameObject.name.Contains("ghost"))
                {
                    Vector2 directionFromObjectToSword = collision.transform.position - transform.position;


                    RaycastHit2D hit = Physics2D.Raycast(transform.position, directionFromObjectToSword, directionFromObjectToSword.magnitude);

                    // Ray hit an object
                    if (hit.collider != null && hit.collider.CompareTag("wall")) { hitWall = true; }
                }

            }





            


            if (!hitWall)
            {
                if (!gameObject.name.Contains("spider") && rb2d != null && gameObject.name != "the Pyramid")
                {
                    StopAllCoroutines();
                    OnBegin?.Invoke();



                    Vector2 direction = (transform.position - collision.gameObject.transform.position).normalized;

                    if (collision.gameObject.CompareTag("bullet"))
                    {
                        direction = ((Vector2)transform.position - (Vector2)collision.gameObject.GetComponent<Rigidbody2D>().velocity).normalized;
                    }

                    if (collision.gameObject.name.Contains("axe"))  // knockback if the weapon is an axe
                    {
                        if (gameObject.name.Contains("ghostEnemy") || gameObject.name.Contains("voidWraith") || gameObject.name.Contains("viperFish"))
                        {

                            if (GetComponent<meleeEnemy>() != null)
                            {
                                float ghostSpeed = GetComponent<meleeEnemy>().movementSpeed;
                                rb2d.AddForce(direction * ghostSpeed * 20f, ForceMode2D.Impulse);
                            }
                            else
                            {
                                rb2d.AddForce(direction * 40f, ForceMode2D.Impulse);
                            }

                        }
                        else
                        {
                            rb2d.AddForce(direction * 14f, ForceMode2D.Impulse);
                        }


                    }
                    else if (collision.gameObject.name.Contains("shield")) //knockback if the weapon is a shield
                    {

                        if (gameObject.name.Contains("ghostEnemy") || gameObject.name.Contains("voidWraith") || gameObject.name.Contains("viperFish"))
                        {



                            if (GetComponent<meleeEnemy>() != null)
                            {
                                float ghostSpeed = GetComponent<meleeEnemy>().movementSpeed;
                                rb2d.AddForce(direction * ghostSpeed * 27f, ForceMode2D.Impulse);
                            }
                            else
                            {
                                rb2d.AddForce(direction * 55f, ForceMode2D.Impulse);
                            }
                        }
                        else
                        {
                            rb2d.AddForce(direction * 20f, ForceMode2D.Impulse);
                        }



                    }
                    else // knockback if the weapon is anything else but a bullet
                    {

                        if (gameObject.name.Contains("ghostEnemy") ||
                            gameObject.name.Contains("voidWraith") || gameObject.name.Contains("viperFish"))
                        {
                            if (GetComponent<meleeEnemy>() != null)
                            {
                                float ghostSpeed = GetComponent<meleeEnemy>().movementSpeed;
                                rb2d.AddForce(direction * ghostSpeed * 15f, ForceMode2D.Impulse);
                            }
                            else
                            {
                                rb2d.AddForce(direction * 30f, ForceMode2D.Impulse);
                            }
                        }
                        else
                        {
                            rb2d.AddForce(direction * 7f, ForceMode2D.Impulse);
                        }



                    }

                    if (!collision.gameObject.name.Contains("shield"))
                    {
                        Invoke("Reset", 0.15f);
                    }
                    else
                    {
                        Invoke("Reset", 1f);
                    }


                }


                

                if (collision.gameObject.name.Contains("playerBullet") && !gameObject.name.Contains("Snake")
                    && !gameObject.name.Contains("thrombus") &&
                    !gameObject.name.Contains("thePlant"))
                { // BULLET DAMAGE

                    if (gameObject.name.Contains("thrombus") ||
                    gameObject.name.Contains("thePlant"))
                    {
                        gameObject.GetComponent<hpStore>().health -= 10;
                    }
                    else
                    {
                        gameObject.GetComponent<hpStore>().health -= 50;
                    }

                }
                else if (collision.gameObject.name.Contains("sword"))
                {
                    gameObject.GetComponent<hpStore>().health -= 65 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;

                }
                else if (collision.gameObject.name.Contains("knife"))
                {
                    gameObject.GetComponent<hpStore>().health -= 18 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if (collision.gameObject.name.Contains("dagger"))
                {
                    gameObject.GetComponent<hpStore>().health -= 9 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if (collision.gameObject.name.Contains("wrathClaws"))
                {
                    gameObject.GetComponent<hpStore>().health -= 50 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                
                    if (wrathEnrageAbility.S.abilityRunning)
                    {
                        onWrathFire = true;
                        cancelUnWrathFire();
                        Invoke("unWrathFire", 2f);
                    }

                }
                else if (collision.gameObject.name.Contains("spear"))
                {
                    gameObject.GetComponent<hpStore>().health -= 75 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;

                    slothEnergyStore.S.totalEnergy += 10;



                }
                else if (collision.gameObject.name.Contains("katana"))
                {
                    gameObject.GetComponent<hpStore>().health -= 25 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }

                else if (collision.gameObject.CompareTag("boom")) // rpg explosion damage
                {
                    if (gameObject.name.Contains("thrombus") ||
                    gameObject.name.Contains("thePlant"))
                    {
                        gameObject.GetComponent<hpStore>().health -= 50;
                    }
                    else
                    {
                        gameObject.GetComponent<hpStore>().health -= 100;
                    }
                }
                else if (collision.gameObject.name.Contains("axe"))
                {
                    gameObject.GetComponent<hpStore>().health -= 120 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if (collision.gameObject.name.Contains("Gauntlet"))
                {

                    Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);

                    if (!gameObject.name.Contains("ghost") && !gameObject.name.Contains("small"))
                    {
                        Instantiate(heartObject, transform.position, desiredRotation);
                    }
                    

                    disableMovement();

                    gameObject.GetComponent<hpStore>().health -= 30 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
                else if (collision.gameObject.name.Contains("shield"))
                {
                    gameObject.GetComponent<hpStore>().health -= 150 * extraMeleeWeaponDamageStore.meleeDamageMultiplier;
                }
            }

            hitWall = false;


        }
    }

    void unWrathFire()
    {
        onWrathFire = false;
    }

    void cancelUnWrathFire()
    {
        CancelInvoke("unWrathFire");
    }

    void Update()
    {
        if (onWrathFire)
        {
            gameObject.GetComponent<hpStore>().health -= 25 * Time.deltaTime;


            
        }
    }

}
    /*if (collision.gameObject.CompareTag("enemy"))
        {
            if (!gameObject.name.Contains("RPG") && !gameObject.name.Contains("explosion"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 1;

                transform.position = new Vector2(999f, 999f);

    AudioSource audioSource = GetComponent<AudioSource>();
    audioSource.clip = playerAudioStore.S.audioClips[1];
                audioSource.Play();

               

                Invoke("destroy", 0.5f);


}
            else
{

    collision.gameObject.GetComponent<hpStore>().health -= 300;
}


        }
    // Update is called once per frame
    void Update()
    {
        
    }
    */ 

