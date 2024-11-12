using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeHailFall : MonoBehaviour
{
    

    public GameObject hailPrefab;

    private GameObject hail;

    

    

    private int xL;

    private int yL;

    private int xH;
    private int yH;

    private int xF;
    private int yF;

    private Vector3 randomPosL;
    private Vector3 randomPosH = new Vector3(0, -8, 0);
    private Vector3 randomPosF = new Vector3(0, -8, 0);

    // Start is called before the first frame update
    void Start()
    {
        
        generateHail();

        generateRandomPosH();

        
    }

    

    void generateRandomPosH()
    {
        xH = (int)Random.Range(-12f, 12f);
        randomPosH = new Vector3(xH, -8f, 0f);
    }

    

    void generateHail()
    {
        hail = Instantiate(hailPrefab, transform.position - randomPosH, transform.rotation);
        Invoke("generateHail", 0.5f);
        Invoke("generateRandomPosH", 0.3f);
    }

    

    

    

    // Update is called once per frame
    void Update()
    {


        if (selectCharacter.mapSelected == "retribution" && 
            nextRoomChecker.S.roomNumber < 24 && nextRoomChecker.S.roomNumber > 30)
        {
            
            CancelInvoke("generateHail");

        }
    }
}
