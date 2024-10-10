using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPestilence : MonoBehaviour
{
    public GameObject leftSpawner;
    public GameObject rightSpawner;
    public GameObject bottomSpawner;
    public GameObject topSpawner;
    public GameObject pestilence;
    public GameObject pestilencePrefab;
    

    public System.Random random = new System.Random();

    private int randomInteger;

    // Start is called before the first frame update
    void Start()
    {
        leftSpawner = GameObject.Find("middleLeftSpawner");
        rightSpawner = GameObject.Find("middleRightSpawner");
        //bottomSpawner = GameObject.Find("bottomMiddleSpawner");
        topSpawner = GameObject.Find("topMiddleSpawner");

        spawn();
    }

    void destroyPestilence()
    {
        Destroy(pestilence);
    }

    void spawn()
    {
        randomInteger = random.Next(0, 4);

        pestilencePrefab = GameObject.Find("pestilence");

        



        switch (randomInteger)
        {
            case 0:
                pestilence = Instantiate(pestilencePrefab, leftSpawner.transform.position, leftSpawner.transform.rotation);
                break;
            case 1:
                pestilence = Instantiate(pestilencePrefab, rightSpawner.transform.position, rightSpawner.transform.rotation);
                break;
            case 2:
                pestilence = Instantiate(pestilencePrefab, topSpawner.transform.position, topSpawner.transform.rotation);
                break;
            case 3:
                //pestilence = Instantiate(pestilencePrefab, bottomSpawner.transform.position, bottomSpawner.transform.rotation);
                break;
        }
        Invoke("destroyPestilence", 12f);
        Invoke("spawn", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
