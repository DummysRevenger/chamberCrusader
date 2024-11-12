using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class blockSpawner : MonoBehaviour
{
    public System.Random random = new System.Random();

    public GameObject block2;

    public GameObject meleeEnemyPrefab;

    private bool dash = false;
    public GameObject block;

    

    public GameObject longWallV;
    public GameObject longWallH;
    public GameObject holeWall;
    public GameObject MV;
    public GameObject MH;
    public GameObject HWT;
    public GameObject dotDotDash;
    public GameObject dotDashDot;
    public GameObject dashDotDot;

    public GameObject dashDash;
    public GameObject dashI;
    public GameObject Idash;

    public GameObject dashODot;

    public GameObject dashSDot;

    public GameObject dashBDot;

    public GameObject O;

    public GameObject S;

    public GameObject B;

    public GameObject waterPuddle;


    // sporangium
    public GameObject sp;

    // congealed flesh
    public GameObject cf;

    public GameObject dashsp; // done

    public GameObject spDot; // done

    public GameObject spDash; // done

    public GameObject cfDash; // done

    public GameObject cfDot; // done

    public GameObject dashCf; // done

    public GameObject roulette;

    public GameObject shop;



    // Start is called before the first frame update
    void Start()
    {


        dashsp = GameObject.Find("-sp");
        spDot = GameObject.Find("sp.");
        spDash = GameObject.Find("sp-");


        dashCf = GameObject.Find("-cf");
        cfDot = GameObject.Find("cf.");
        cfDash = GameObject.Find("cf-");

        sp = GameObject.Find("sp");
        cf = GameObject.Find("cf");


        waterPuddle = GameObject.Find("wPuddle");




        block2 = GameObject.Find("blockWall");
        
        longWallH = GameObject.Find("longWallH");
        holeWall = GameObject.Find("holeWall");
        MV = GameObject.Find("mediumWallV");
        MH = GameObject.Find("mediumWallV");
        HWT = GameObject.Find("holeWallTilt");

        dotDotDash = GameObject.Find("..-");
        dotDashDot = GameObject.Find(".-.");
        dashDotDot = GameObject.Find("-..");


        dashODot = GameObject.Find("-O.");


        dashDash = GameObject.Find("--_");
        dashI = GameObject.Find("-I_");
        Idash = GameObject.Find("I-_");

        dashBDot = GameObject.Find("-B.");

        dashSDot = GameObject.Find("-s.");

        dashODot = GameObject.Find("-o.");

        B = GameObject.Find("B");

        O = GameObject.Find("o");

        S = GameObject.Find("S");

        shop = Resources.Load("Scenes/update11Resources/shopkeeper/shop") as GameObject;

        roulette = Resources.Load("Scenes/update11Resources/newprefabs/roulette") as GameObject;

    }


    public void spawnRoulette()
    {
        block = Instantiate(roulette, transform.position, Quaternion.identity);
    }

    public void spawnBlock()
    {

        if (nextRoomChecker.S.roomNumber == 10 && gameObject.name == "middleMiddleSpawner")
        {
            
                block = Instantiate(roulette, transform.position, Quaternion.identity);
            
            
        }
        else if (((nextRoomChecker.S.roomNumber % 15 == 0 && nextRoomChecker.S.roomNumber != 90 && nextRoomChecker.S.roomNumber != 60) 
            || nextRoomChecker.S.roomNumber == 89 || nextRoomChecker.S.roomNumber == 59)  && gameObject.name == "middleMiddleSpawner")
        {


            Vector3 rouletteOffset = new Vector3(0f, 2f, 0f);

            block = Instantiate(shop, transform.position + rouletteOffset, Quaternion.identity);

            Debug.Log("spawn the shop");
        }
        else if (nextRoomChecker.S.roomNumber != 20 && nextRoomChecker.S.roomNumber != 10 && nextRoomChecker.S.roomNumber % 15 != 0
            && !(gameObject.name.Contains("middleMiddleSpawner") && (selectCharacter.mapSelected == "retribution" && (retributionMapStore.S.mapType == "vestibule" 
            || retributionMapStore.S.mapType == "limbo" || retributionMapStore.S.mapType == "angry"))))
        {
            int enemyType = random.Next(0, 15);

            

            switch (enemyType)
            {
                case 0:
                    block = Instantiate(block2, transform.position, Quaternion.identity);
                    break;
                case 1:
                    block = Instantiate(HWT, transform.position, Quaternion.identity);
                    break;

                case 2:
                    block = Instantiate(dotDashDot, transform.position, Quaternion.identity);
                    break;

                case 3:
                    block = Instantiate(block2, transform.position, Quaternion.identity);
                    break;
                case 4:
                    block = Instantiate(MV, transform.position, Quaternion.identity);
                    dash = true;
                    break;
                case 5:
                    block = Instantiate(MH, transform.position, Quaternion.identity);
                    dash = true;
                    break;

                case 6:
                    block = Instantiate(dotDotDash, transform.position, Quaternion.identity);
                    break;
                case 7:
                    block = Instantiate(dashDotDot, transform.position, Quaternion.identity);
                    break;
                case 8:
                    block = Instantiate(dashDash, transform.position, Quaternion.identity);

                    block.transform.rotation = dashDash.transform.rotation;

                    dash = true;
                    break;
                case 9:
                    block = Instantiate(dashI, transform.position, Quaternion.identity);
                    break;

                case 10:
                    if (!gameObject.name.Contains("top"))
                    {
                        block = Instantiate(Idash, transform.position, Quaternion.identity);
                    }
                    break;
                case 11:
                    if (selectCharacter.mapSelected == "desert")
                    {
                        block = Instantiate(dashODot, transform.position, Quaternion.identity);
                    }
                    if (selectCharacter.mapSelected == "dungeon")
                    {
                        block = Instantiate(dashSDot, transform.position, Quaternion.identity);
                    }
                    else if (selectCharacter.mapSelected == "blood")
                    {
                        block = Instantiate(dashBDot, transform.position, Quaternion.identity);
                    }
                    else if (selectCharacter.mapSelected == "onion")
                    {

                        int randomNumber = random.Next(0, 4);

                        switch (randomNumber)
                        {
                            case 0:
                                block = Instantiate(cfDot, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                block = Instantiate(spDot, transform.position, Quaternion.identity);
                                break;
                            case 2:
                                block = Instantiate(cfDash, transform.position, Quaternion.identity);
                                break;
                            case 3:
                                block = Instantiate(spDot, transform.position, Quaternion.identity);
                                break;
                        }


                    }
                    else if (selectCharacter.mapSelected == "retribtuion")
                    {
                        switch(retributionMapStore.S.mapType)
                        {
                            case "limbo":
                                block = Instantiate(waterPuddle, transform.position, Quaternion.identity);
                                break;
                        }
                    }
                    break;

                case 12:

                    if (selectCharacter.mapSelected == "desert")
                    {
                        block = Instantiate(O, transform.position, Quaternion.identity);
                    }

                    if (selectCharacter.mapSelected == "dungeon")
                    {
                        block = Instantiate(S, transform.position, Quaternion.identity);
                    }
                    else if (selectCharacter.mapSelected == "blood")
                    {
                        block = Instantiate(B, transform.position, Quaternion.identity);
                    }
                    else if(selectCharacter.mapSelected == "onion")
                    {

                        int randomNumber = random.Next(0, 4);

                        switch(randomNumber)
                        {
                            case 0:
                                block = Instantiate(sp, transform.position, Quaternion.identity);
                                break;
                            case 1:
                                block = Instantiate(cf, transform.position, Quaternion.identity);
                                break;
                            case 2:
                                block = Instantiate(dashsp, transform.position, Quaternion.identity);
                                break;
                            case 3:
                                block = Instantiate(dashCf, transform.position, Quaternion.identity);
                                break;
                        }

                        
                    }
                    break;

                    

                    
                

            }






            if (dash && block != null)
            {
                int pos = random.Next(0, 3);


                switch (pos)
                {
                    case 0:
                        break;
                    case 1:
                        block.transform.position = new Vector2(block.transform.position.x, block.transform.position.y + 1);
                        break;
                    case 2:
                        block.transform.position = new Vector2(block.transform.position.x, block.transform.position.y - 2);
                        break;
                }
            }


        }

        }

        
    


    
    // Update is called once per frame
    void Update()
    {


        if (block != null && block.GetComponent<destroyWall>() == null)
        {
            block.AddComponent<destroyWall>();
        }
    }
}
