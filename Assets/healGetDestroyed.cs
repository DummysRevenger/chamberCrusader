using UnityEngine;

public class healGetDestroyed : MonoBehaviour
{
    
    private int currentValue;

    private int targetValue;

    private void Start()
    {
        currentValue = nextRoomChecker.S.roomNumber;
        targetValue = nextRoomChecker.S.roomNumber;

        Invoke("despawn", 3f);
    }

    private void despawn()
    {
        Destroy(gameObject);
    }

    private void Update()
    {



        if (currentValue != targetValue)
        {
            Destroy(gameObject);
        }

        currentValue = nextRoomChecker.S.roomNumber;
    }
}