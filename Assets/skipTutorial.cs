using UnityEngine;

public class skipTutorial : MonoBehaviour
{
    private bool isSpacebarPressed = false;
    private float spacebarPressedTime = 0f;

    public GameObject tutorial; // contains the tutorial empty object

    void Update()
    {
        // Check if the spacebar is being pressed
        if (Input.GetKey(KeyCode.Space))
        {
            // If the spacebar was not previously pressed, start counting the time
            if (!isSpacebarPressed)
            {
                isSpacebarPressed = true;
                spacebarPressedTime = Time.time;
            }

            // Check if the spacebar has been pressed for 2 seconds
            if (Time.time - spacebarPressedTime >= 1f)
            {
                // Spacebar has been pressed for 2 seconds

                tutorialDoneChecker.tutorialDone = true;
                tutorial.SetActive(false);
            }
        }
        else
        {
            // The spacebar is no longer being pressed
            isSpacebarPressed = false;
        }
    }
}