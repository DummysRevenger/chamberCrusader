using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsBlindStore : MonoBehaviour
{
    public static playerIsBlindStore S;

    public bool playerIsBlind = false;

    public bool playerBlindCooldown = false;

    private GameObject player;


    private GameObject globalLight;

    private UnityEngine.Rendering.Universal.Light2D globalLightComponent;


    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");

        globalLight = GameObject.Find("global light");

        globalLightComponent = globalLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>();

    }

    

    public void delayUnBlind()
    {
        Invoke("unBlind", 0.7f);

    }

    public void unBlind()
    {
        globalLightComponent.intensity = 1f;
    }

    public void cancelUnBlind()
    {
        CancelInvoke("unBlind");
    }

    public void blind()
    {
        globalLightComponent.intensity = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
