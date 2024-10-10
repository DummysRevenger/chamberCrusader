using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retributionRollSum : MonoBehaviour
{

    public static retributionRollSum S;

    public int theSum = 3;

    public List<int> rollList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        theSum = 3;
        S = this;

        rollList.Clear();
    }

    // Update is called once per frame
    void Update()
    {

        /*if (rollList.Count == 3)
        {
            Debug.Log(rollList[0].ToString() + ", " + rollList[1].ToString() + ", " + rollList[2].ToString());
        }
        */


    }
}
