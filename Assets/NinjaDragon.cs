using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaDragon : MonoBehaviour
{

    public Quaternion movementDirection;
    public float movementSpeed = 5f; // Speed at which the object moves forwards

    public void MoveForwards()
    {
        // Convert the forward rotation to Euler angles
        Vector3 eulerAngles = movementDirection.eulerAngles;

        // Extract the rotation around the z-axis
        float forwardAngle = eulerAngles.z;

        // Calculate the movement amount in the x and y directions based on the forward angle
        float forwardAngleRad = Mathf.Deg2Rad * forwardAngle;
        Vector2 movementAmount = new Vector2(Mathf.Cos(forwardAngleRad), Mathf.Sin(forwardAngleRad)) * movementSpeed * Time.deltaTime;

        // Update the object's position by adding the movement amount
        transform.position += new Vector3(movementAmount.x, movementAmount.y, 0f);
    }

    void LateUpdate()
    {
        MoveForwards();
    }


}
