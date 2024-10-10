using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSkeletons : MonoBehaviour
{

    public GameObject skeletonPrefab;

    public GameObject rightSpawner;

    public GameObject leftSpawner;

    public GameObject upSpawner;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        upSpawner = GameObject.Find("topMiddleSpawner");
        leftSpawner = GameObject.Find("middleLeftSpawner");
        rightSpawner = GameObject.Find("bottomRightSpawner");


        spawnTheSkeleton();

        

        

    }


    void spawnTheSkeleton()
    {
        Instantiate(skeletonPrefab, transform.position, transform.rotation);

        Instantiate(skeletonPrefab, upSpawner.transform.position, transform.rotation);

        Instantiate(skeletonPrefab, leftSpawner.transform.position, transform.rotation);

        Instantiate(skeletonPrefab, rightSpawner.transform.position, transform.rotation);

        Invoke("spawnTheSkeleton", 10f);

        audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
