using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLightning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("disappear", 1f);
    }

    void disappear()
    {
        Destroy(gameObject);
    }
}
