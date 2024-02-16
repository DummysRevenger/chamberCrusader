using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenKnifeCooldowner : MonoBehaviour
{
    public static KitchenKnifeCooldowner S;
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
        gunRotation.S.KitchenKnifeCoolDown = true;
        yield return new WaitForSeconds(1f);
        gunRotation.S.KitchenKnifeCoolDown = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
