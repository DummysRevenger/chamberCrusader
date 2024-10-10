using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailGolemMakeBoom : MonoBehaviour
{
    public GameObject whiteExplosion;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("createExplosion", 0.5f);
    }

    void createExplosion()
    {
        Instantiate(whiteExplosion, transform.position, transform.rotation);
    }

}
