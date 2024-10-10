using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBounce : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.name.Contains("anubis") || other.gameObject.name.Contains("Pyramid") || other.gameObject.name.Contains("Skull")
            || other.gameObject.name.Contains("thePlant") || (other.gameObject.name.Contains("Gluttony") && gluttonyDefenseAbility.S.fat)))
        {

            if (!gameObject.name.Contains("Fork"))
            {

                

                rb.velocity = -rb.velocity;

                Vector3 currentScale = transform.localScale;

                Vector3 newScale = new Vector3(-currentScale.x, currentScale.y, currentScale.z);

                transform.localScale = newScale;
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
