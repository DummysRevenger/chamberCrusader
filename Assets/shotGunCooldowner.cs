using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGunCooldowner : MonoBehaviour
{
    public static shotGunCooldowner S;
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
        gunRotation.S.shotGunOnCooldown = true;
        yield return new WaitForSeconds(0.5f);
        gunRotation.S.shotGunOnCooldown = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
