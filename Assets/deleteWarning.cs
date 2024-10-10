using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteWarning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("delete", 1.1f);
    }

    void delete()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
