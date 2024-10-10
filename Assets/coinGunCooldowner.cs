using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGunCooldowner : MonoBehaviour
{
    public static coinGunCooldowner S;
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
        gunRotation.S.coinGunOnCoolDown = true;

        yield return new WaitForSeconds(0.2f - (barrelCountStore.barrelCount * 0.02f));

        gunRotation.S.coinGunOnCoolDown = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
