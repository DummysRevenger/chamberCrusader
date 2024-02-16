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



    // Start is called before the first frame update
    void Start()
    {
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

        //dashODot = GameObject.Find("-O.");

        B = GameObject.Find("B");

        //O = GameObject.Find("O");

        S = GameObject.Find("S");


    }
    
    public void spawnBlock()
    {
        int enemyType = random.Next(0, 13);
        
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

                break;




        }

        
        

        

        if (dash)
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

        
    


    
    // Update is called once per frame
    void Update()
    {


        if (block != null && block.GetComponent<destroyWall>() == null)
        {
            block.AddComponent<destroyWall>();
        }
    }
}
