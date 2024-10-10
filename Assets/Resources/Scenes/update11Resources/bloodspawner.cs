using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodspawner : MonoBehaviour
{
    public GameObject bloodPuddlePrefab;

    private GameObject thePuddle;

    public System.Random random = new System.Random();

    private int randomInteger;

    private GameObject bloodDisappearAnim;

    // Start is called before the first frame update
    void Start()
    {

        bloodDisappearAnim = GameObject.Find("blood puddle disappear_0");

        if (!pyramidTransition.stage3bool)
        {
            randomInteger = random.Next(7, 10);

            bloodPuddlePrefab = GameObject.Find("B");

            Invoke("spawnPuddle", randomInteger);
        }
        else
        {
            CancelInvoke();
            if (thePuddle != null) { Destroy(thePuddle); }
        }

    }

    void spawnPuddle()
    {
        thePuddle = Instantiate(bloodPuddlePrefab, transform.position, transform.rotation);

        Invoke("deletePuddle", randomInteger);
    }

    void deletePuddle()
    {
        Vector3 bufferVector = thePuddle.transform.position;

        Vector3 fixedVector = new Vector3(thePuddle.transform.position.x, thePuddle.transform.position.y + 1, thePuddle.transform.position.z);

        Instantiate(bloodDisappearAnim, fixedVector, thePuddle.transform.rotation);
        Destroy(thePuddle);
        Invoke("spawnPuddle", randomInteger);
    }

}
