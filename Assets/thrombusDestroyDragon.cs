using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusDestroyDragon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyDragon", 12f);
    }

    void destroyDragon()
    {
        enemiesInRoomChecker.S.enemiesInRoomNumber--;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
