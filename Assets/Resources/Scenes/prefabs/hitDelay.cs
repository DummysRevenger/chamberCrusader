using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDelay : MonoBehaviour
{

    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.enabled = false;

        StartCoroutine(turnOnCollider());
    }

    IEnumerator turnOnCollider()
    {
        yield return new WaitForSeconds(0.2f);
        boxCollider.enabled = true;
    }

        
    // Update is called once per frame
    void Update()
    {
        
    }
}
