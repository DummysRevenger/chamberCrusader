using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFONumberStore : MonoBehaviour
{
    public static UFONumberStore S;

    public int UFONumber;

    // Start is called before the first frame update
    void Start()
    {
        UFONumber = 0;

        S = this;
    }
}
