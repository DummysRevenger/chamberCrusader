using UnityEngine;

public class OrbitPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player object
    private float movementSpeed = 2f; // Speed at which the enemy moves around the player
    private float orbitRadius = 4f; // Radius of the orbit around the player

    public float yPos;
    public float xPos;

    private float startX;

    private float startY;

    private float orbitDirection = 1f;


    public bool startPosCalculated;

    private float angle;

    public snakeBiteAttack biteAttackScript;

    void Start()
    {
        Invoke("biteAttack", 5f);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("metawall"))
        {
            orbitDirection *= -1;
        }
    }


    private void biteAttack()
    {
        Debug.Log("bite attack!");
        biteAttackScript.enabled = true;
        enabled = false;
    }

    private void FixedUpdate()
    {

        

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > orbitRadius + 1)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            Vector3 targetPosition = transform.position + direction * 5f * Time.deltaTime;

            transform.position = targetPosition;

            


            startPosCalculated = false;
        }
        else
        {
            //orbit around the player



            // work out start position and therefore start angle
            if (!startPosCalculated)
            {
                float startY = player.position.y - transform.position.y;
                float startX = player.position.x - transform.position.x;



                startPosCalculated = true;

                angle = Mathf.Atan2(startY, startX);
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

    }


    
}