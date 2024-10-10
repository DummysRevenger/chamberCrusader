using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBodyParts : MonoBehaviour
{

    public GameObject chainBroken;

    private bool breakingAnimMade = false;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("chain"))
        {
            chainBroken = GameObject.Find("chain body break_0");
        }
    }


    IEnumerator breakChain()
    {
        GameObject breakingAnimation = Instantiate(chainBroken, transform.position, transform.rotation);

        yield return new WaitForSeconds(2f);

        Destroy(breakingAnimation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {


        if (gameObject.name.Contains("chain"))
        {
            if (enemiesInRoomChecker.S.enemiesInRoomNumber == 0 && !breakingAnimMade)
            {
                GetComponent<SpriteRenderer>().enabled = false;



                breakingAnimMade = true;


                StartCoroutine(breakChain());
            }
        }
        
    }
}
