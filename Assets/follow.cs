using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target; // The target object to sync position with

    private void LateUpdate()
    {
        // Check if the target is valid
        if (target == null)
        {
            Debug.LogWarning("Target object is not assigned!");
            return;
        }

        // Set the position of the object to match the target's position
        transform.position = target.position;
    }
}