using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class gridmaker2 : MonoBehaviour
{
    public GameObject cellPrefab;
    public Vector2 cellSize = new Vector2(1f, 1f);
    public static int numCols = 23;
    public static int numRows = 13;

    private Vector2 originalPos;

    private Vector2 originalChaserPos;

    public bool firstCellPicked = false;


    public static GameObject objectToMove;

    public static gridmaker2 S;

    static float[,] gridOfHeuristics = new float[numRows, numCols];

    int[,] grid = new int[numRows, numCols];

    private GameObject otm;


    static float[,] gridWeights = new float[numRows, numCols];

    static float[,] gridOfTruth = new float[numRows, numCols];

    int[] currentCell = new int[2];

    int[][] cellsToVisit = new int[9][];

    public static GameObject[,] gameObjectsArray = new GameObject[numRows, numCols];

    public GameObject player;


    public float distanceRequired;

    public float distanceRequiredLimit = 0.3f;

    public bool cellReached = false;


    public GameObject wallPrefab;

    private float smallestHeuristic = 1f;

    public float smallestHeuristicLimit = 0.5f;

    public static GameObject nextCell; //used to store the next cell to be visited by the algorithm

    public GameObject previousNode;

    public List<GameObject> visitedNodes = new List<GameObject>();

    public List<string> visitedStrings = new List<string>();

    public static int nextRow;

    public static int nextCol;

    private int smallesti;

    private int smallestj;

    public GameObject target;


    void GenerateGrid()
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Vector2 cellPosition = CalculateCellPosition(row, col);
                /*
                               if (col < 13 && col > 11)
                                {
                                    GameObject wall = Instantiate(wallPrefab, cellPosition, Quaternion.identity);
                                    grid[row, col] = 1;

                                    float distance = CalculateEuclideanDistance(wall.transform.position.x, wall.transform.position.y, objectToMove.transform.position.x, objectToMove.transform.position.y);

                                    gridWeights[row, col] = 999f;
                                    gameObjectsArray[row, col] = wall;
                                    gridOfHeuristics[row, col] = 999f;
                                }
                                else
                                {*/

                GameObject cell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);
                grid[row, col] = 0;

                cell.transform.SetParent(transform); // Set the map object as the parent of the cell
                float distance = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, objectToMove.transform.position.x, objectToMove.transform.position.y);



                gridWeights[row, col] = distance;
                gridOfHeuristics[row, col] = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);

                gameObjectsArray[row, col] = cell;
            }





        }





        /*for (int col = numCols - 10; col < numCols; col++)
        {
            Vector2 cellPosition = CalculateCellPosition(row, col);
            /*
                           if (col < 13 && col > 11)
                            {
                                GameObject wall = Instantiate(wallPrefab, cellPosition, Quaternion.identity);
                                grid[row, col] = 1;

                                float distance = CalculateEuclideanDistance(wall.transform.position.x, wall.transform.position.y, objectToMove.transform.position.x, objectToMove.transform.position.y);

                                gridWeights[row, col] = 999f;
                                gameObjectsArray[row, col] = wall;
                                gridOfHeuristics[row, col] = 999f;
                            }
                            else
                            {

            GameObject cell = Instantiate(wallPrefab, cellPosition, Quaternion.identity);
            grid[row, col] = 1;

            cell.transform.SetParent(transform); // Set the map object as the parent of the cell
            float distance = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, objectToMove.transform.position.x, objectToMove.transform.position.y);



            gridWeights[row, col] = distance;
            gridOfHeuristics[row, col] = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);

            gameObjectsArray[row, col] = cell;
        }
    }*/

        grid[9, 9] = 1;
        grid[9, 8] = 1;
        grid[8, 8] = 1;
        grid[8, 9] = 1;

        grid[8, 10] = 1;
        grid[9, 10] = 1;



    }


    public static void whiteWash()
    {

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                gameObjectsArray[row, col].GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f);
            }
        }
    }



    public static float CalculateEuclideanDistance(float startX, float startY, float targetX, float targetY)
    {
        Vector2 start = new Vector2(startX, startY);
        Vector2 target = new Vector2(targetX, targetY);
        float distance = Vector2.Distance(start, target);
        return distance;
    }





    Vector2 CalculateCellPosition(int row, int col)
    {
        // Calculate the position of the cell based on the cell size and its row and column indices
        
        float y = transform.position.y + row * cellSize.y;
        
        float x = transform.position.x + col * cellSize.x;

        return new Vector2(x, y);
    }




    
    //find the closest triangle
    public void returnClosestTriangle()
    {
        float smallest = gridmaker2.gridWeights[0, 0];

        cellReached = false;


        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {

                if (gridmaker2.gridWeights[i,j] < smallest)
                {
                    smallest = gridmaker2.gridWeights[i, j]; // Update the smallest value
                    smallesti = i;
                    smallestj = j;
                }

            }
        }

        //Debug.Log(smallesti + ", " + smallestj);

        
    }


    
    GameObject findUp(int smalli, int smallj) //finds the cell above the chosen cell
    {
        return gameObjectsArray[smalli, smallj + 1];
    }

    GameObject findDown(int smalli, int smallj)
    {
        return gameObjectsArray[smalli, smallj - 1];
    }

    GameObject findLeft(int smalli, int smallj)
    {
        return gameObjectsArray[smalli - 1, smallj];
    }

    GameObject findRight(int smalli, int smallj)
    {
        return gameObjectsArray[smalli + 1, smallj];
    }

    public GameObject findSmallestHeuristic()
    {
        /*findUp(smallesti, smallestj);
        findDown(smallesti, smallestj);
        findLeft(smallesti, smallestj);
        findRight(smallesti, smallestj);*/

        smallestHeuristic = 999f;

        float newSmallesti = 0;
        float newSmallestj = 0;

        GameObject cellToGoToNext = gameObjectsArray[smallesti + 1, smallestj];


        if (gridOfHeuristics[smallesti, smallestj + 1] < smallestHeuristic) //if cell to the top has smaller heuristic
        {
            smallestHeuristic = gridOfHeuristics[smallesti, smallestj + 1] ;
            cellToGoToNext = findUp(smallesti, smallestj);
        }

        if (gridOfHeuristics[smallesti, smallestj - 1] < smallestHeuristic) //if cell to the bottom has smaller heuristic
        {
            smallestHeuristic = gridOfHeuristics[smallesti, smallestj - 1];
            cellToGoToNext = findDown(smallesti, smallestj);
        }

        if (gridOfHeuristics[smallesti + 1, smallestj] < smallestHeuristic) //if cell to the right has smaller heuristic
        {
            smallestHeuristic = gridOfHeuristics[smallesti + 1, smallestj];
            cellToGoToNext = findRight(smallesti, smallestj);


        }

        else if (gridOfHeuristics[smallesti - 1, smallestj] < smallestHeuristic) //if cell to the left has smaller heuristic
        {
            smallestHeuristic = gridOfHeuristics[smallesti - 1, smallestj];
            cellToGoToNext = findLeft(smallesti, smallestj);
        }

        cellToGoToNext.GetComponent<SpriteRenderer>().color = Color.red;




        return cellToGoToNext;

    }
























    public static void calculateDistanceOfGrid(GameObject ooi, GameObject player)
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {


                GameObject cell = gameObjectsArray[row, col];


                if (cell != null && cell != ooi && gridmaker2.S.grid[row, col] != 1)
                {
                    float heuristic = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);
                    float weight = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, ooi.transform.position.x, ooi.transform.position.y);

                    gridOfHeuristics[row, col] = heuristic;

                    gridWeights[row, col] = weight;

                    

                }
                else
                {
                    float heuristic = 999f;
                    float weight = 999f;

                    cell.GetComponent<SpriteRenderer>().color = Color.blue;

                    gridOfHeuristics[row, col] = heuristic;

                    gridWeights[row, col] = weight;
                }
                /* else
                 {
                     gridWeights[row, col] = 999f;


                         gridOfHeuristics[row, col] = 999f;



                 }*/

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        S = this;
        objectToMove = GameObject.Find("destination");

        GenerateGrid();

        returnClosestTriangle();

        

    }




    public static void MoveTowardsTarget(int speed, GameObject otm)
    {
        if (!gridmaker2.S.cellReached)
        {
            gridmaker2.S.target = gridmaker2.S.findSmallestHeuristic();
        }
        



        Vector3 direction = (gridmaker2.S.target.transform.position - otm.transform.position).normalized;
        otm.transform.position += direction * speed * Time.deltaTime;

        float distanceToTarget = CalculateEuclideanDistance(otm.transform.position.x, otm.transform.position.y, gridmaker2.S.target.transform.position.x, gridmaker2.S.target.transform.position.y);

        if (distanceToTarget < 0.1f)
        {
            

            gridmaker2.S.cellReached = true;

            gridmaker2.S.target = gridmaker2.S.findSmallestHeuristic();

            gridmaker2.S.returnClosestTriangle();
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {





        whiteWash();


        calculateDistanceOfGrid(objectToMove, player);



        MoveTowardsTarget(2, objectToMove);























    }
}
