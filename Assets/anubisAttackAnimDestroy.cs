using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anubisAttackAnimDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("getDestroyed", 1f);
    }

    void getDestroyed()
    {
        Destroy(gameObject);
    }
}
