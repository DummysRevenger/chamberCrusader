using UnityEngine;

public class HideCheck : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public Transform objectTransform; // Reference to the object's transform

    public LayerMask wallLayer;


    void Update()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(objectTransform.position, playerTransform.position - objectTransform.position);

        UnityEngine.Debug.Log(hit.collider);


        // Check if the ray hit a wall or an obstacle
        if (hit.collider != null && hit.collider.CompareTag("wall"))
        {
            // The player is hidden by a wall
            
        }
        else
        {
            // The player is not hidden by a wall
            
        }

        void OnDrawGizmos()
        {
            // Visualize the raycast as a gizmo in the Scene view
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, playerTransform.position - transform.position);
        }


    }

}