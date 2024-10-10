using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAllEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DeleteAllEnemies();
    }


    void DeleteAllEnemies()
    {
        // Find all GameObjects with the tag "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        

        // Loop through the array and destroy each enemy
        foreach (GameObject enemy in enemies)
        {

            Debug.Log(enemy);

            Destroy(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
