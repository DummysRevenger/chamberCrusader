using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control the movement speed

    public static playerMovement S;

    public Vector3 movement;

    public Sprite rightSpritegun;
    public Sprite leftSpritegun;
    public Sprite upSpritegun;
    public Sprite downSpritegun;

    public Sprite upRightLeggun;
    public Sprite upLeftLeggun;

    public Sprite downRightLeggun;
    public Sprite downLeftLeggun;

    public bool facingShot = false;


    public Sprite rightSprites;
    public Sprite leftSprites;
    public Sprite upSprites;
    public Sprite downSprites;

    public Sprite upRightLegs;
    public Sprite upLeftLegs;

    public Sprite downRightLegs;
    public Sprite downLeftLegs;

    public SpriteRenderer spriteRenderer;

    private bool isMovingUp = false;

    IEnumerator stopFacing()
    {
        facingShot = true;
        yield return new WaitForSeconds(1.2f);
        facingShot = false;

    }

    private void Start()
    {
        S = this;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a wall
        if (collision.gameObject.CompareTag("wall"))
        {
            // Stop player movement
            // For example, if you're using a Rigidbody, you can set its velocity to zero
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;


        }
    }

    private void FixedUpdate()
    {
        if (!hpStorePlayer.S.gameOver)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");



             movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;


            if (!facingShot)
            { 
            if (verticalInput > 0)
            {
                if (Time.frameCount % 120 < 60)
                {
                    if (weaponSwitch.S.gunEquipped)
                    {
                        spriteRenderer.sprite = upRightLeggun;

                    }
                    else
                    {
                        spriteRenderer.sprite = upRightLegs;
                    }
                    
                }

                else
                {
                    if (weaponSwitch.S.gunEquipped)
                    {
                        spriteRenderer.sprite = upLeftLeggun;

                    }
                    else
                    {
                        spriteRenderer.sprite = upLeftLegs;
                    }
                }
            }
            else if (verticalInput < 0)
            {
                if (Time.frameCount % 120 < 60)
                {
                    if (weaponSwitch.S.gunEquipped)
                    {
                        spriteRenderer.sprite = downRightLeggun;

                    }
                    else
                    {
                        spriteRenderer.sprite = downRightLegs;
                    }
                }
                else
                {
                    if (weaponSwitch.S.gunEquipped)
                    {
                        spriteRenderer.sprite = downLeftLeggun;

                    }
                    else
                    {
                        spriteRenderer.sprite = downLeftLegs;
                    }
                }
            }
            else if (horizontalInput > 0)
            {
                if (weaponSwitch.S.gunEquipped)
                {
                    spriteRenderer.sprite = rightSpritegun;

                }
                else
                {
                    spriteRenderer.sprite = rightSprites;
                }
            }
            else if (horizontalInput < 0)
            {
                if (weaponSwitch.S.gunEquipped)
                {
                    spriteRenderer.sprite = leftSpritegun;

                }
                else
                {
                    spriteRenderer.sprite = leftSprites;
                }
            }
            

            }

            transform.position += movement;
        }


        if (weaponSwitch.S.gunEquipped)
        {



            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Input.mousePosition;
                Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));
                Vector3 direction = worldMousePosition - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


                if (angle < 45f && angle > -45f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = rightSpritegun;


                }
                else if (angle < 135f && angle > 45f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = upSpritegun;

                }
                else if (angle < -45f && angle > -135f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = downSpritegun;

                }
                else
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = leftSpritegun;

                }
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Input.mousePosition;
                Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));
                Vector3 direction = worldMousePosition - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


                if (angle < 45f && angle > -45f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = rightSprites;


                }
                else if (angle < 135f && angle > 45f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = upSprites;

                }
                else if (angle < -45f && angle > -135f)
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = downSprites;

                }
                else
                {
                    StartCoroutine(stopFacing());
                    spriteRenderer.sprite = leftSprites;

                }
            }
        }

    }
        public void StopMovement()
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    
}