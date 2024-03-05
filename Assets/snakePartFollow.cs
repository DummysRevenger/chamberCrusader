using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakePartFollow : MonoBehaviour
{
    public GameObject partToFollow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        float distance = Vector3.Distance(transform.position, partToFollow.transform.position);

        if(distance >= 1f)
        {
            Vector3 direction = (partToFollow.transform.position - transform.position).normalized;

            Vector3 targetPosition = transform.position + direction * 14f * Time.deltaTime;

            transform.position = targetPosition;
        }



    }
}
