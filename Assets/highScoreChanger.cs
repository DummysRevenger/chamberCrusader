using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScoreChanger : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsStore.S.points > statsStore.highScore)
        {
            statsStore.highScore = pointsStore.S.points;
        }
    }
}
