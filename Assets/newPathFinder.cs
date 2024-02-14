using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class newPathFinder : MonoBehaviour
{

    public GameObject cellGrid;

    private float heuristic;

    public bool touchingWall = false;


    public GameObject player;

    public float[] arrayOfHeuristics = new float[4];

    private GameObject[] arrayOfObjects = new GameObject[4];

    private bool directionChosen = false;

    string leftOrRight;

    public bool playerBehindWall = false;

    private void calculateDistanceOfGrid()
    {
        for (int i = 0; i < 4; i++)
        {


            string formattedString = "cell" + (1+i);



            GameObject cellToInspect = GameObject.Find(formattedString);



            arrayOfObjects[i] = cellToInspect;


            
                
                    
            heuristic = CalculateEuclideanDistance(cellToInspect.transform.position.x, cellToInspect.transform.position.y, player.transform.position.x, player.transform.position.y);


            

            arrayOfHeuristics[i] = heuristic;

            /* else
             {
                 gridWeights[row, col] = 999f;


                     gridOfHeuristics[row, col] = 999f;



             }*/


        }
    }

    void Awake()
    {
         


    }
    void Start()
    {
        calculateDistanceOfGrid();



        

        

    }

    private GameObject FindSmallestHeuristic(float[] aOfH, GameObject[] aOfO)
    {


        

        

        float smallestValue = float.MaxValue;
        int smallestIndex = 0;
        

        for (int i = 0; i < 4; i++)
        {

            float currentValue = aOfH[i];

            
            if (currentValue < smallestValue)
            {


                

                smallestIndex = i;
                smallestValue = currentValue;


            }

            //if ((aOfO[5].CompareTag("touching") && aOfO[6].CompareTag("touching") && aOfO[7].CompareTag("touching")) || (aOfO[5].CompareTag("touching") && aOfO[6].CompareTag("touching")) || aOfO[5].CompareTag("touching"))
            if (((aOfO[0].CompareTag("touching"))))
            { //if the top 3 triangles are both touching a wall


                if (transform.position.x < player.transform.position.x)
                {

                    smallestIndex = 2;
                }   
                else
                {
                    smallestIndex = 1;
                }

                if (Mathf.Abs(transform.position.x - player.transform.position.x) < 0.1f)
                {
                    smallestIndex = 1;
                }

            }

            else if (((aOfO[3].CompareTag("touching"))))
            { //if the top 3 triangles are both touching a wall


                if (transform.position.x < player.transform.position.x)
                {

                    smallestIndex = 2;
                }
                else
                {


                    smallestIndex = 1;
                }

                if (Mathf.Abs(transform.position.x - player.transform.position.x) < 0.1f)
                {
                    smallestIndex = 1;
                }
                else
                {
                    smallestIndex = 2;
                }
                

            }
                

                else if (((aOfO[2].CompareTag("touching"))))
                { //if the top 3 triangles are both touching a wall


                if (transform.position.y < player.transform.position.y)
                {

                    smallestIndex = 0;
                }
                else
                {


                    smallestIndex = 3;
                }

                if (Mathf.Abs(transform.position.y - player.transform.position.y) < 0.1f)
                {
                    smallestIndex = 0;
                }

            }

                else if (((aOfO[1].CompareTag("touching"))))
                { //if the top 3 triangles are both touching a wall


                if (transform.position.y < player.transform.position.y)
                {

                    smallestIndex = 0;
                }
                else
                {


                    smallestIndex = 3;
                }

                if (Mathf.Abs(transform.position.y - player.transform.position.y) < 0.1f)
                {
                    smallestIndex = 0;
                }

            }

                




                /* else if (leftOrRight == "left" && ((aOfO[5].CompareTag("touching")) && (aOfO[6].CompareTag("touching")) && (aOfO[7].CompareTag("touching"))))
                { //if the bottom 3 triangles are both touching a wall


                    smallestIndex = 3;



                }



                else if (leftOrRight == "right" && ((aOfO[5].CompareTag("touching")) && (aOfO[6].CompareTag("touching")) && (aOfO[7].CompareTag("touching"))))
                { //if the bottom 3 triangles are both touching a wall


                    smallestIndex = 4;



                }


                else if (((aOfO[0].CompareTag("touching")) && (aOfO[3].CompareTag("touching")) && (aOfO[5].CompareTag("touching")) || (aOfO[5].CompareTag("touching"))))
                { //if the left 3 triangles are touching a wall


                    UnityEngine.Debug.Log("yeet");

                    smallestIndex = 1;

                }


                else if (((aOfO[2].CompareTag("touching")) && (aOfO[4].CompareTag("touching")) && (aOfO[7].CompareTag("touching")) || (aOfO[2].CompareTag("touching"))))
                { //if the left 3 triangles are touching a wall




                    smallestIndex = 6;

                }
                */

            
            



            }



        

            
               
                
        
        return aOfO[smallestIndex];
    }




    public static float CalculateEuclideanDistance(float startX, float startY, float targetX, float targetY)
    {
        Vector2 start = new Vector2(startX, startY);

        Vector2 target = new Vector2(targetX, targetY);

        float distance = Vector2.Distance(start, target);

        return distance;
    }


    public static void MoveTowardsTarget(GameObject target, int speed, GameObject otm)
    {
        Vector3 direction = (target.transform.position - otm.transform.position).normalized;
        otm.transform.position += direction * speed * Time.deltaTime;
    }


    // Update is called once per frame
    void Update()
    {

        calculateDistanceOfGrid();


        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position);

        


        // Check if the ray hit a wall or an obstacle
        if (hit.collider != null && hit.collider.CompareTag("wall"))
        {
            // The player is hidden by a wall
            playerBehindWall = true;
        }
        else
        {
            // The player is not hidden by a wall
            playerBehindWall = false;
        }
        /*

        if ((transform.position.x <= player.transform.position.x) && !directionChosen)
        {
            leftOrRight = "right";

            directionChosen = true;
        }

        else
        {
            leftOrRight = "left";

            directionChosen = true;
        }

        */

        GameObject cellToFollow = FindSmallestHeuristic(arrayOfHeuristics, arrayOfObjects);

        

        

        
            MoveTowardsTarget(cellToFollow, 2, gameObject);


        




    }

    
}
