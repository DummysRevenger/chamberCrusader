using UnityEngine;

public class OrbitPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player object
    public float movementSpeed = 2f; // Speed at which the enemy moves around the player
    private float orbitRadius = 7f; // Radius of the orbit around the player


    public float yPos;
    public float xPos;

    private float biteTimer = 10f;


    private float startX;

    private bool startOrbit = false;

    public snakeBiteAttack biteAttackScript;

    private float startY;

    private float orbitDirection = 1f;

    public  bool scriptRestart = true;

    public  bool startPosCalculated;

    private float angle;

    public GameObject retreatPoint;

    private float distanceThreshold;


   // public static OrbitPlayer S;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        retreatPoint = GameObject.Find("snakeRetreatPoint");

        

        
        Invoke("biteAttack", 5f);


        if (gameObject.name.Contains("crawlingSnake"))
        {
            distanceThreshold = 2f;
            orbitRadius = 5f;
        }
        else
        {
            distanceThreshold = 4f;
        }
        
        
    }

    private bool CheckDistanceFromWalls(Vector3 position, float distanceThreshold)
    {
        // Cast rays in multiple directions
        Vector2[] directions = new Vector2[] { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
        foreach (Vector2 direction in directions)
        {
            RaycastHit2D hit = Physics2D.Raycast(position, direction, distanceThreshold);
            if (hit.collider != null)
            {
                // A wall was hit within the distance threshold
                return false;
            }
        }

        // No walls were hit within the distance threshold
        return true;

    }

    void Awake()
    {
        //S = this;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("metawall"))
        {
            orbitDirection *= -1;
        }
    }

    public void invokeBiteAttack()
    {

        Invoke("biteAttack", 5f);


        // Cast rays in multiple directions
        if (CheckDistanceFromWalls(transform.position, 3f))
        {
            // The distance from any wall is greater than 3
            //Invoke("biteAttack", 5f);
        }
        else
        {
            // The distance from at least one wall is less than or equal to 1
            
        }
    }

    public void biteAttack()
    {

        

        biteAttackScript.attacking = true;
        biteAttackScript.enabled = true;
        biteAttackScript.reStart();
        enabled = false;

        
    }

    private void FixedUpdate()
    {
        /*
        if(biteTimer > 0)
        {
            biteTimer -= Time.deltaTime;
        }
        else
        {
            biteTimer = 5f;
            biteAttack();
        }*/



        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > orbitRadius + 1)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            Vector3 targetPosition = transform.position + direction * 5f * Time.deltaTime;

            transform.position = targetPosition;

            // Get the direction from the current position to the player position
            Vector3 directionToFace = player.position - transform.position;

            // Calculate the angle of rotation in radians
            float angleToFace = Mathf.Atan2(directionToFace.y, directionToFace.x);

            // Create a rotation quaternion with only Z rotation
            Quaternion rotation = Quaternion.Euler(0f, 0f, angleToFace * Mathf.Rad2Deg - 90);

            // Apply the rotation to the object
            transform.rotation = rotation;

            scriptRestart = true;

            startPosCalculated = false;




        }
        else
        {

            if (distance < distanceThreshold)
            {
                

                Vector3.MoveTowards(transform.position, retreatPoint.transform.position, movementSpeed * Time.deltaTime);
            }


            //orbit around the player

            if (distance == orbitRadius  || distance >= orbitRadius - 1)
            {

                


                // work out start position and therefore start angle
                if (!startPosCalculated && scriptRestart)
                {
                    float startY = player.position.y - transform.position.y;
                    float startX = player.position.x - transform.position.x;



                    startPosCalculated = true;

                    angle = Mathf.Atan2(startY, startX) - Mathf.PI;

                    
                }

                if (orbitDirection == 1f)
                {
                    angle += movementSpeed * Time.deltaTime;
                    transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));
                }
                else
                {
                    angle -= movementSpeed * Time.deltaTime;

                    transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI) - 180);

                }



                

                yPos = player.position.y + Mathf.Sin(angle) * orbitRadius;
                xPos = player.position.x + Mathf.Cos(angle) * orbitRadius;



                



                transform.position = new Vector3(xPos, yPos, 0f);

                //Vector3 targetPosition = new Vector3(xPos, yPos, 0f);

                //transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);




            }
            else
            {

                

                // Calculate the direction from the object to the player
                Vector3 directionToPlayer = player.position - transform.position;

                // Normalize the direction vector
                directionToPlayer.Normalize();

                // Calculate the target position to move away from the player
                Vector3 targetPosition = transform.position - directionToPlayer * 3f * movementSpeed * Time.deltaTime;

                // Move the object towards the target position
                transform.position = targetPosition;

            }

        }



    }
}