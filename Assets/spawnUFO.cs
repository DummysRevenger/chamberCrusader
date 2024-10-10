using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnUFO : MonoBehaviour
{

    private Animator animator;

    private int animationNumber;

    private pyramidCharge chargeScript;

    private Rigidbody2D rb;

    public GameObject UFOPrefab;

    private bool spawn;

    // Start is called before the first frame update
    void Start()
    {
        chargeScript = GetComponent<pyramidCharge>();

        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();


        Invoke("SetFlag", 10f);
        
    }

    void SetFlag()
    {
        spawn = true;
    }

    void create()
    {
        animationNumber = 6;

        Instantiate(UFOPrefab, transform.position, transform.rotation);

        animator.SetInteger("phase", animationNumber);

        spawn = false;

        Invoke("SetFlag", 6f);
    }

    

    // Update is called once per frame
    void Update()
    {
        

        

        if (rb.velocity.magnitude <= 1f && spawn && UFONumberStore.S.UFONumber <= 3)
        {
            create();

            Debug.Log("ufo spawn");

            UFONumberStore.S.UFONumber++;

            spawn = false;
        }
    }
}
