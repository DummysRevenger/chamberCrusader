using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash : MonoBehaviour
{

    public GameObject slash1;
    public GameObject slash2;
    public GameObject slash3;
    public GameObject dragon;
    private float timer = 0f;

    private bool isCooldown = false;
    private float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    public GameObject cross2;


    public GameObject slashPoint;


    // Update is called once per frame
    void Update()
    {

        // Get the current rotation of the object
        Quaternion rotation = transform.rotation;


        if (!isCooldown)
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.G))
            {
                
                timer += Time.deltaTime;
            }


            if (Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.G))
            {

                isCooldown = true;
                cooldownTimer = cooldownDuration;

                cross2.SetActive(true);

                if (timer <= 0.5f)
                {
                    Instantiate(slash1, slashPoint.transform);
                }
                else if (timer <= 1f && timer > 0.5f)
                {
                    Instantiate(slash2, slashPoint.transform);
                }
                else if (timer > 1f && timer <= 2f)
                {
                    Instantiate(slash3, slashPoint.transform);
                }
                else if (timer > 2f)
                {

                    Vector3 mousePosition = Input.mousePosition;
                    Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));


                    Vector3 aimDirection = (worldMousePosition - transform.position).normalized;


                    GameObject theDragon = Instantiate(dragon, slashPoint.transform.position, slashPoint.transform.rotation);


                    theDragon.GetComponent<Rigidbody2D>().velocity = aimDirection * 5f;





                    // Calculate the angle in degrees
                    float angle = 180f + Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

                    // Apply the rotation to the sprite
                    theDragon.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


                    NinjaDragon dragonScript = theDragon.GetComponent<NinjaDragon>();


                }

                timer = 0;

                cooldownTimer = 5f;

            }
        }
        else
        {

            if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }

            if (cooldownTimer <= 0.0f)
            {
                isCooldown = false;
                cross2.SetActive(false);
            }
        }





    }
}
