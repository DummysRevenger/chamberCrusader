using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGCooldowner : MonoBehaviour
{
    public static RPGCooldowner S;
    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    public void StartCoroutineFromOutside()
    {
        StartCoroutine(cooldown());
    }

    IEnumerator cooldown()
    {
        gunRotation.S.RPGOnCoolDown = true;

        yield return new WaitForSeconds(1.2f - (barrelCountStore.barrelCount * 0.2f));

        gunRotation.S.RPGOnCoolDown = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
