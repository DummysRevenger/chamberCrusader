using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusDestroyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("hypnoBall"))
        {
            Invoke("projectileDestroy", 35f);
        }
        else
        {
            Invoke("projectileDestroy", 3f);
        }
    }

    void projectileDestroy()
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
