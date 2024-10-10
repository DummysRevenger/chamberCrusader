using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class necromancerMakeDarkness : MonoBehaviour
{

    public GameObject globalLight;

    public GameObject spotLight;

    public GameObject backGround;

    



    // Start is called before the first frame update
    void Start()
    {


        backGround = necromancerObjectsStore.S.necromancerBackground;

        globalLight = necromancerObjectsStore.S.globalLight;

        spotLight = necromancerObjectsStore.S.spotLight;

        backGround.SetActive(true);

        spotLight.SetActive(true);

        globalLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
