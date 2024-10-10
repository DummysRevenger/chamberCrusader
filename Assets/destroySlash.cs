using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySlash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("1"))
        {
            Invoke("DestroyObject", 0.8f);
        }
        else if (gameObject.name.Contains("2"))
        {
            Invoke("DestroyObject", 1.2f);
        }
        else if (gameObject.name.Contains("3"))
        {
            Invoke("DestroyObject", 0.9f);
        }
        else
        {
            Invoke("DestroyObject", 5f);
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
