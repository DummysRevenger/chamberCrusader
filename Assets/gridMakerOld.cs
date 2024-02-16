using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class gridMakerOld : MonoBehaviour
{
    public GameObject cellPrefab;
    public Vector2 cellSize = new Vector2(1f, 1f);
    public static int numCols = 22;
    public static int numRows = 13;

    public static GameObject player;

    public static gridMakerOld S;

    static float[,] gridOfHeuristics = new float[numRows, numCols];

    int[,] grid = new int[numRows, numCols];


    static float[,] gridWeights = new float[numRows, numCols];

    static float[,] gridOfTruth = new float[numRows, numCols];

    int[] currentCell = new int[2];

    int[][] cellsToVisit = new int[9][];

    public static GameObject[,] gameObjectsArray = new GameObject[numRows, numCols];

    

    public static List<GameObject> cellArray = new List<GameObject>();

    public GameObject target;

    public static bool cellReached = false;

    public GameObject destination;

    public GameObject wallPrefab;


    public GameObject nextCell; //used to store the next cell to be visited by the algorithm


    private Vector3 previousPosition;

    private Vector3 currentPosition;

    private bool playerMoved = false;



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

                                    float distance = CalculateEuclideanDistance(wall.transform.position.x, wall.transform.position.y, player.transform.position.x, player.transform.position.y);

                                    gridWeights[row, col] = 999f;
                                    gameObjectsArray[row, col] = wall;
                                    gridOfHeuristics[row, col] = 999f;
                                }
                                else
                                {*/

                GameObject cell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);
                grid[row, col] = 0;

                cell.transform.SetParent(transform); // Set the map object as the parent of the cell
                float distance = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);



                gridWeights[row, col] = distance;
                gridOfHeuristics[row, col] = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, destination.transform.position.x, destination.transform.position.y);

                gameObjectsArray[row, col] = cell;
            }









        }

        /*for (int col = 0; col < numCols-10; col++)
        {
            Vector2 cellPosition = CalculateCellPosition(row, col);
            GameObject cell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);
            cell.transform.SetParent(transform); // Set the map object as the parent of the cell



            grid[row, col] = 1;

            float distance = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, player.transform.position.x, player.transform.position.y);


            gridWeights[row, col] = distance;

            gridOfHeuristics[row, col] = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, destination.transform.position.x, destination.transform.position.y);

            gameObjectsArray[row, col] = cell;
        }*/

        grid[9, 9] = 1;
        grid[9, 8] = 1;
        grid[8, 8] = 1;
        grid[8, 9] = 1;

        grid[9, 10] = 1;
        grid[8, 10] = 1;

        //grid[8, 11] = 1;
        //grid[8, 12] = 1;














    }


    /*public static void whiteWash()
    {

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                gameObjectsArray[row, col].GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f);
            }
        }
    }*/



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




    public static void FindSmallest9Weights(float[,] gridWeights, GameObject destination)
    {

        

        //float[,] tempGridWeights = new float[numRows, numCols];

        //tempGridWeights = gridWeights;

        string[] smallestIndexes = new string[9];


        float smallestHeuristic = float.MaxValue;


        int index1 = -1;
        int index2 = -1;

        string currentValue = "";

        string[] indexParts = new string[2];

        for (int i = 0; i < 8; ++i) //loop to find the closest 9 cells and fetch the one with the smallest heuristic
        {





            string smallestIndex = FindSmallestValueIndex(gridWeights); //find the index of closest cell to the object to move in the format index1, index2

            


            indexParts = smallestIndex.Split(','); // split the index into two parts, index1 and index2


            gridWeights[int.Parse(indexParts[0]), int.Parse(indexParts[1])] = 99f; //eliminate that cell from being chosen again by increasing its weight to 999

            

            if (gridOfHeuristics[int.Parse(indexParts[0]), int.Parse(indexParts[1])] < smallestHeuristic) 
                //if that cells heuristic smaller than the smallest heuristic
            {
                smallestHeuristic = gridOfHeuristics[int.Parse(indexParts[0]), int.Parse(indexParts[1])];
                //the smallest heuristic variable becomes that heuristic

                index1 = int.Parse(indexParts[0]); //smallest index1
                index2 = int.Parse(indexParts[1]); // smallest index2


                //GameObject otm = gameObjectsArray[index1, index2];



            }

        }


        cellArray.Add(gameObjectsArray[index1, index2]);


        


        if (gridMakerOld.S.grid[index1, index2] != 1)
        {

            //MoveTowardsTarget(gameObjectsArray[index1, index2], 2, player);

        }



        if (!gridMakerOld.S.playerMoved)
        {

            

            calculateDistanceOfGrid(gameObjectsArray[index1, index2], destination); //calculate the distances from the cell to the destination


            if (smallestHeuristic > 1f)
            {

                FindSmallest9Weights(gridWeights, destination);
            }
            else
            {
                // go through the list, highlighting each cell in the list red
                foreach (GameObject element in cellArray)
                {
                    if (element != null)
                    {
                        element.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f);
                    }
                }
            }

        }


    }



    public static void MoveTowardsTarget(int speed, GameObject otm)
    {
        if (!cellReached)
        {
            //gridMakerOld.S.target = gridMakerOld.S.findSmallestHeuristic(); //make this the first item in the list


            gridMakerOld.S.target = cellArray[0];

            
        }

        
        


        Vector3 direction = (gridMakerOld.S.target.transform.position - otm.transform.position).normalized;
        otm.transform.position += direction * speed * Time.deltaTime;

        float distanceToTarget = CalculateEuclideanDistance(otm.transform.position.x, otm.transform.position.y, gridMakerOld.S.target.transform.position.x, gridMakerOld.S.target.transform.position.y);

        if (distanceToTarget < 0.1f)
        {


            cellReached = true;




            //remove the first item in the list
            if (cellArray.Count > 1)
            {
                cellArray[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
                cellArray.Remove(cellArray[0]);
            }

            

            gridMakerOld.S.target = cellArray[0];

            

        }

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



                }
            }
        }

        if (smallestRow != -1 && smallestCol != -1)
        {
            return $"{smallestRow}, {smallestCol}";
        }

        return string.Empty;
    }

    public static void calculateDistanceOfGrid(GameObject ooi, GameObject destination)
    { 
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {


                GameObject cell = gameObjectsArray[row, col];

                

                if (cell != null && gridMakerOld.S.grid[row, col] != 1)
                {
                    float distance = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, ooi.transform.position.x, ooi.transform.position.y);
                    // distance from the cell to the object to move
                    float weight = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, destination.transform.position.x, destination.transform.position.y);
                    // distance from the cell to the object to move to (destination, heuristic)

                    
                    float trueWeight = distance + weight;


                    //gridOfTruth[row, col] = trueWeight;
                    //gridOfHeuristics[row, col] = distance;


                    gridOfHeuristics[row, col] = CalculateEuclideanDistance(cell.transform.position.x, cell.transform.position.y, destination.transform.position.x, destination.transform.position.y);


                    

                    gridWeights[row, col] = distance;

                }
                else
                 {
                     gridWeights[row, col] = 99999f;


                    cell.GetComponent<SpriteRenderer>().color = Color.blue;

                    gridOfHeuristics[row, col] = 99999f;



                 }

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        S = this;
        player = GameObject.Find("destination");

        cellArray.Clear();

        cellReached = false;

        GenerateGrid();


        calculateDistanceOfGrid(player, destination);

        FindSmallest9Weights(gridWeights, destination);



        previousPosition = destination.transform.position;

        

    }




    



    // Update is called once per frame
    void Update()
    {

        





        currentPosition = destination.transform.position;


        playerMoved = currentPosition != previousPosition;


        if (playerMoved)
        {
            cellArray.Clear();


            cellReached = false;

            calculateDistanceOfGrid(player, destination);



            FindSmallest9Weights(gridWeights, destination);

            
            
            previousPosition = currentPosition;
        }



        MoveTowardsTarget(2, player);






        /*if (indexString != null)
        {
            string[] indexParts = indexString.Split(',');
        }*/



        //whiteWash();

    }
}
