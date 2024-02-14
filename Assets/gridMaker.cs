using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class gridMaker : MonoBehaviour
{
    public GameObject cellPrefab;
    public Vector2 cellSize = new Vector2(1f, 1f);
    public static int numCols = 23;
    public static int numRows = 13;

    private Vector2 originalPos;

    private Vector2 originalChaserPos;

    public bool firstCellPicked = false;


    public static GameObject objectToMove;

    public static gridMaker S;

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


    public GameObject wallPrefab;

    private float smallestHeuristic = 1f;

    public float smallestHeuristicLimit = 0.5f;

    public static GameObject nextCell; //used to store the next cell to be visited by the algorithm

    public GameObject previousNode;

    public List<GameObject> visitedNodes = new List<GameObject>();

    public List<string> visitedStrings = new List<string>();

    public static int nextRow;

    public static int nextCol;


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
        float x = transform.position.x + col * cellSize.x;
        float y = transform.position.y + row * cellSize.y;
        return new Vector2(x, y);
    }




    public static bool cellReached(GameObject cellToReach, int indexOne, int indexTwo)
    {

        gridMaker.S.distanceRequired = CalculateEuclideanDistance(objectToMove.transform.position.x, objectToMove.transform.position.y, cellToReach.transform.position.x, cellToReach.transform.position.y);

        


        if (gridMaker.S.distanceRequired < gridMaker.S.distanceRequiredLimit)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }



    public static void FindSmallest4Weights(float[,] grid1, GameObject destination, float smallestWeight)
    {
        int index1 = -1;
        int index2 = -1;

        string currentValue = "";

        string[] indexParts = new string[2];

        string smallestIndex = " ";


        if (gridOfHeuristics[index1, index2 + 1] < gridMaker.S.smallestHeuristic && gridWeights[index1, index2 + 1] < smallestWeight) //up
        {

            gridMaker.S.smallestHeuristic = grid1[index1, index2 + 1];
            index2 = index2 + 1;


        }
        if (gridOfHeuristics[index1 + 1, index2] < gridMaker.S.smallestHeuristic && gridWeights[index1 + 1, index2] < smallestWeight) //right
        {

            gridMaker.S.smallestHeuristic = grid1[index1 + 1, index2];
            index1 = index1 + 1;
        }
        if (gridOfHeuristics[index1, index2 - 1] < gridMaker.S.smallestHeuristic && gridWeights[index1, index2 - 1] < smallestWeight) //down
        {

            gridMaker.S.smallestHeuristic = grid1[index1, index2 - 1];
            index2 = index2 - 1;
        }
        if (gridOfHeuristics[index1 - 1, index2] < gridMaker.S.smallestHeuristic && gridWeights[index1 - 1, index2] < smallestWeight) //left
        {

            index1 = index1 - 1;
        }




    }


    public static void controlMovement(int index1, int index2)
    {
        if (gridMaker.S.smallestHeuristic > 0.2f)
        {

            nextRow = index1;
            nextCol = index2;


            gridMaker.S.visitedNodes.Add(nextCell);

            
            nextCell = gameObjectsArray[nextRow, nextCol];



            if (gridMaker.S.visitedNodes[0] != null)
            {

                MoveTowardsTarget(gridMaker.S.visitedNodes[0], 2, objectToMove);

            }

        }
    }
    


    public static void FindSmallest9Weights(float[,] grid1, GameObject destination)
    {



        int index1 = -1;
        int index2 = -1;

        string currentValue = "";

        string[] indexParts = new string[2];








       // if (nextCell == null)
        //{


            
            



        //}

        /*else
        {



            index1 = nextRow;
            index2 = nextCol;
        }*/








        string smallestIndex = " ";



        //gridWeights[int.Parse(indexParts[0]), int.Parse(indexParts[1]) ]= 999f;

        smallestIndex = FindSmallestValueIndex(gridWeights);
        indexParts = smallestIndex.Split(',');
        index1 = int.Parse(indexParts[0]);
        index2 = int.Parse(indexParts[1]);




        gridMaker.S.otm = gameObjectsArray[index1, index2];
        gridMaker.S.smallestHeuristic = grid1[index1 - 1, index2];



        



        if (!gridMaker.S.firstCellPicked || cellReached(gameObjectsArray[index1, index2], index1, index2)) //if the first cell hasn't been picked or a cell has been reached
        {


            

            gridMaker.S.smallestHeuristic = grid1[index1 - 1, index2];


            string direction = "up";


            if (gridOfHeuristics[index1, index2 + 1] < gridMaker.S.smallestHeuristic && gridWeights[index1, index2 + 1] < 999f) // up
            {

                gridMaker.S.smallestHeuristic = grid1[index1, index2 + 1];

                direction = "up";

                


            }

            if (gridOfHeuristics[index1 + 1, index2] < gridMaker.S.smallestHeuristic && gridWeights[index1 + 1, index2] < 999f) //right
            {

                gridMaker.S.smallestHeuristic = grid1[index1 + 1, index2];

                direction = "right";

                
            }
            if (gridOfHeuristics[index1, index2 - 1] < gridMaker.S.smallestHeuristic && gridWeights[index1, index2 - 1] < 999f) //down
            {

                gridMaker.S.smallestHeuristic = grid1[index1, index2 - 1];

                direction = "down";

                
            }
            if (gridOfHeuristics[index1 - 1, index2] < gridMaker.S.smallestHeuristic && gridWeights[index1 - 1, index2] < 999f) // left
            {
                gridMaker.S.smallestHeuristic = grid1[index1 - 1, index2];

                direction = "left";

                
            }


            //gridMaker.S.smallestHeuristic = gridOfHeuristics[int.Parse(indexParts[0]), int.Parse(indexParts[1])];


            switch(direction)
            {
                case "left":
                    index1--;
                    break;
                case "right":
                    index1++;
                    break;
                case "up":
                    index2++;
                    break;
                case "down":
                    index2--;
                    break;
            }















            gridMaker.S.otm = gameObjectsArray[index1, index2];









            //gridMaker.S.visitedNodes.Add(otm);

            gridMaker.S.otm.GetComponent<SpriteRenderer>().color = Color.red;




            /*foreach(string theString in gridMaker.S.visitedStrings)
            {



            }*/


            gridMaker.S.firstCellPicked = true;

            if (gridMaker.S.smallestHeuristic > gridMaker.S.smallestHeuristicLimit)
            {




                nextRow = index1;

                nextCol = index2;



                gridMaker.S.visitedNodes.Add(nextCell);

                nextCell = gameObjectsArray[nextRow, nextCol];



                

            }


            


        }




        MoveTowardsTarget(gridMaker.S.otm, 2, objectToMove);
















    }



    public static string FindSmallestValueIndex(float[,] gridWeights)
    {
        int numRows = gridWeights.GetLength(0);
        int numCols = gridWeights.GetLength(1);

        float smallestValue = float.MaxValue;
        int smallestRow = -1;
        int smallestCol = -1;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                float currentValue = gridWeights[i, j];

                if (currentValue < smallestValue)
                {
                    smallestValue = currentValue;
                    smallestRow = i;
                    smallestCol = j;


                    if (gridMaker.S.grid[i, j] == 1)
                    {

                        continue;

                    }

                }
            }
        }

        if (smallestRow != -1 && smallestCol != -1)
        {
            return $"{smallestRow}, {smallestCol}";
        }

        return string.Empty;
    }

    public static void calculateDistanceOfGrid(GameObject ooi, GameObject player)
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {


                GameObject cell = gameObjectsArray[row, col];


                if (cell != null && cell != ooi && gridMaker.S.grid[row, col] != 1)
                {
                    float heuristic = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);
                    float weight = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, ooi.transform.position.x, ooi.transform.position.y);

                    float trueWeight = heuristic + weight;


                    gridOfTruth[row, col] = trueWeight;

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

        originalPos = player.transform.position;

        originalChaserPos = transform.position;

    }

    


    public static void MoveTowardsTarget(GameObject target, int speed, GameObject otm)
    {
        Vector3 direction = (target.transform.position - otm.transform.position).normalized;
        otm.transform.position += direction * speed * Time.deltaTime;
    }

    void GeneratePath()
    {
        calculateDistanceOfGrid(objectToMove, player);
        FindSmallest9Weights(gridOfHeuristics, player);
    }

    // Update is called once per frame
    void Update()
    {





        

        

            foreach (GameObject node in gameObjectsArray)
            {
                if (!visitedNodes.Contains(node))
                {
                    node.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f);
                }
            }

            

            nextCell = null;

            gridMaker.S.visitedNodes.Clear();


            GeneratePath();




        









        
    }
}
