using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubisBoomDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("getDestroyed", 0.5f);
    }

    void getDestroyed()
    {
        Destroy(gameObject);
    }
}
