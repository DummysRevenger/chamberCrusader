using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anubisAttackAnimMakeBoom : MonoBehaviour
{
    public GameObject blackExplosion;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("createExplosion", 0.5f);
    }

    void createExplosion()
    {
        Instantiate(blackExplosion, transform.position,transform.rotation);
    }

}
