using UnityEngine;

public class SlipperyPlayerMovement : MonoBehaviour
{

    private float slipperiness = 60f;

    private Rigidbody2D rb;

    private float maxVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = 3f; // Disable drag to allow for slippery movement
        rb.angularDrag = 0.5f; // Disable angular drag



        maxVelocity = 7f;

        

    }


    private float GetHorizontalInput()
    {
        if (Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.A))
        {
            return -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.D))
        {
            return 1f; // Move right
        }
        else
        {
            return 0f; // Don't move horizontally
        }
    }

    private float GetVerticalInput()
    {
        if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.S))
        {
            return -1f; // Move down
        }
        else if (Input.GetKey(KeyCode.U) || Input.GetKey(KeyCode.W))
        {
            return 1f; // Move up
        }
        else
        {
            return 0f; // Don't move vertically
        }
    }


    private void Update()
    {

        if (transform.position.y > 8f && enemiesInRoomChecker.S.enemiesInRoomNumber == 0
                && tutorialDoneChecker.tutorialDone)
        {
            transform.position = new Vector3(0f, -4f, 0f);
        }


        maxVelocity = playerMovementSpeedStore.S.speed - 1;



        // Get the input axes
        float horizontal = GetHorizontalInput();
        float vertical = GetVerticalInput();

        

        // Calculate the movement direction
        Vector3 desiredMoveDirection = new Vector2(horizontal, vertical);


        Vector3 moveDirection = Vector2.Lerp(rb.velocity, desiredMoveDirection * playerMovementSpeedStore.S.speed, Time.fixedDeltaTime * 30f);

        // Apply a force to simulate the slippery movement
        rb.AddForce(moveDirection * playerMovementSpeedStore.S.speed * slipperiness, ForceMode2D.Impulse);

        if (rb.velocity.magnitude > maxVelocity && (GetHorizontalInput() != 0 && GetHorizontalInput() != 0))
        {
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }


    }
}