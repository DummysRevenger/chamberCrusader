using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    public Transform target;  // Reference to the player's transform
    public Vector3 offset;    // Offset between the camera and player

    private float dampTime = 0.15f; // Adjust this value to control the smoothness
    private Vector3 velocity = Vector3.zero;



    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {


        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, -30f);


        transform.position = desiredPosition; 
    }
}