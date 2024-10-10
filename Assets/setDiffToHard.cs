using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setDiffToHard : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Contains("Easy"))
        {
            enemySpawnDifficultyStore.S.difficulty = "easy";
        }
        else if (gameObject.name.Contains("Medium"))
        {
            enemySpawnDifficultyStore.S.difficulty = "medium";
        }
        else if (gameObject.name.Contains("Hard"))
        {
            enemySpawnDifficultyStore.S.difficulty = "hard";
        }
        else if (gameObject.name.Contains("Insane"))
        {
            enemySpawnDifficultyStore.S.difficulty = "insane";
        }
    }
}
