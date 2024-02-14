using UnityEngine;

public class detectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entered collider has the tag "wall"
        if (other.CompareTag("wall"))
        {
            
            // Perform actions when a collider with the "wall" tag enters the trigger
            gameObject.tag = "touching";
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object stops colliding with another object
        if (other.CompareTag("wall"))
        {
            
            // Assign "Untagged" when no longer colliding
            gameObject.tag = "Untagged";
        }
    }

    void Update()
    {


        
    }


}