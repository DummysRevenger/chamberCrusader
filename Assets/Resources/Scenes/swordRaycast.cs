using UnityEngine;

public class swordRaycast : MonoBehaviour
{
    public string wallTag = "wall"; // Tag of the wall objects
    public float requiredOverlapPercentage = 0.5f; // Minimum required overlap percentage for majority collision

    private int wallCollisions = 0; // Counter for wall collisions

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag(wallTag))
        {
            wallCollisions++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag(wallTag))
        {
            wallCollisions--;
        }
    }

    private void Update()
    {
        
            CheckMajorityCollision();
        
    }

    private void CheckMajorityCollision()
    {
        // Get the total number of colliders attached to this object
        int totalColliders = GetComponent<Collider2D>().attachedRigidbody ? GetComponent<Collider2D>().attachedRigidbody.gameObject.GetComponents<Collider2D>().Length : 1;

        float overlapPercentage = (float)wallCollisions / totalColliders;

        if (overlapPercentage >= requiredOverlapPercentage)
        {
            Debug.Log("Majority collision with walls detected!");
        }
        else
        {
            
        }
    }
}