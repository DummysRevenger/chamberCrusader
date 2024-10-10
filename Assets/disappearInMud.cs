using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearInMud : MonoBehaviour
{

    private float randomX;

    private float randomY;

    private throwMudAtPlayer mudThrowingScript;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("disappear", 5f);

        mudThrowingScript = GetComponent<throwMudAtPlayer>();
    }

    void disappear()
    {
        transform.position = new Vector3(999f, 999f, 0f);



        Invoke("reAppear", 2f);

    }

    

    void reAppear()
    {
        randomX = Random.Range(-9, 9);

        randomY = Random.Range(-9, 9);

        transform.position = new Vector3(randomX, randomY, 0f);

        Invoke("disappear", 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
