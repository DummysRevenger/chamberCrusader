using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveMovement : MonoBehaviour
{

    private float timeElapsed = 0f;
    private float yPos;
    private float xPos;

    private float moveDirection = 0.4f;

    public Vector3 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x >= 0)
        {
            moveDirection = -0.4f;
        }
        else
        {
            moveDirection = 0.4f;
        }



        timeElapsed += Time.deltaTime;

        
        xPos = -7f + timeElapsed * moveDirection;

        yPos = Mathf.Sin(timeElapsed) * moveDirection;

        transform.position = startPoint + new Vector3(xPos,11*yPos,0f);

    }
}
