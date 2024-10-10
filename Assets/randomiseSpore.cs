using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomiseSpore : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite spore1;
    public Sprite spore2;
    public Sprite spore3;

    private Rigidbody2D rb;

    private Vector3 direction;

    private meleeEnemy movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<meleeEnemy>();

        movementScript.enabled = false;

        Invoke("enableMovement", 1f);

        rb = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        int randomNumber = Random.Range(0, 3);

        switch (randomNumber)
        {
            case 0:
                spriteRenderer.sprite = spore1;
                break;
            case 1:
                spriteRenderer.sprite = spore2;
                break;
            case 2:
                spriteRenderer.sprite = spore3;
                break;
        }


       

        int randomx = Random.value < 0.5f ? -1 : 1;
        int randomy = Random.value < 0.5f ? -1 : 1;

        int randomForce = Random.Range(6, 10);

        direction = new Vector3(randomx, randomy, 0f);


        direction.Normalize();

        rb.AddForce(direction * randomForce, ForceMode2D.Impulse);

    }

    void enableMovement()
    {
        movementScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
