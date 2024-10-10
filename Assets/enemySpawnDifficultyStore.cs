using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnDifficultyStore : MonoBehaviour
{

    public static enemySpawnDifficultyStore S;

    public string difficulty;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
