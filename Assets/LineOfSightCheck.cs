using UnityEngine;

public class LineOfSightCheck : MonoBehaviour
{
    public LayerMask obstacleLayerMask; // Layer mask for obstacles
    public GameObject targetGameObject; // Reference to the target GameObject

    private Animator theAnimator;


    private void Start()
    {
        targetGameObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {

        theAnimator = GetComponent<Animator>();

        targetGameObject = GameObject.FindGameObjectWithTag("Player");

        CheckLineOfSight();
    }


    private void CheckLineOfSight()
    {
        Vector2 originPosition = (Vector2)transform.position; // Position of the checking GameObject
        Vector2 targetPosition = (Vector2)targetGameObject.transform.position; // Position of the target GameObject

        RaycastHit2D hit = Physics2D.Raycast(originPosition, targetPosition - originPosition, Vector2.Distance(originPosition, targetPosition), obstacleLayerMask);

        if (hit.collider != null)
        {
            // The ray hit an obstacle, the target is not in line of sight
            if (hit.collider.gameObject == targetGameObject)
            {
                // The ray hit the target, the target is in line of sight
                playerMovementSpeedStore.S.speed = 2f;

                targetGameObject.GetComponent<hpStorePlayer>().playerHealth -= 5 * Time.deltaTime;

                theAnimator.SetBool("eyeOpen", true);
            }
            else
            {
                // The ray hit an obstacle, the target is not in line of sight

                theAnimator.SetBool("eyeOpen", false);


                switch (selectCharacter.characterSelected)
                {
                    case "bunny":
                        playerMovementSpeedStore.S.speed = 5f;
                        break;
                    case "knight":
                    case "pride":
                    case "envy":
                        playerMovementSpeedStore.S.speed = 4f;
                        break;
                    case "sloth":
                        playerMovementSpeedStore.S.speed = 2.5f;
                        break;
                    case "gluttony":
                        playerMovementSpeedStore.S.speed = 3f;
                        break;

                    case "ninja":
                    case "greed":
                    case "lust":
                        playerMovementSpeedStore.S.speed = 7f;
                        break;

                    case "soldier":
                    case "wrath":
                        playerMovementSpeedStore.S.speed = 6f;
                        break;
                    case "shop":
                        playerMovementSpeedStore.S.speed = 5f;
                        break;

                }
            }
        }
        else
        {
            // The ray did not hit any obstacle, the target is in line of sight
            

            playerMovementSpeedStore.S.speed = 2f;
            theAnimator.SetBool("eyeOpen", true);
        }
    }
}