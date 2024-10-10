using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blindPlayer : MonoBehaviour
{

    private GameObject globalLight;

    private UnityEngine.Rendering.Universal.Light2D globalLightComponent;

    // Start is called before the first frame update
    void Start()
    {

        globalLight = GameObject.Find("global light");

        globalLightComponent = globalLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>();

        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("unBlind", 1f);
        }
    }

    public void delayUnBlind()
    {
        Invoke("unBlind", 0.7f);
    }

    void unBlind()
    {
        globalLightComponent.intensity = 1f;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsBlindStore.S.blind();

            playerIsBlindStore.S.cancelUnBlind();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsBlindStore.S.blind();

            playerIsBlindStore.S.cancelUnBlind();

            playerIsBlindStore.S.delayUnBlind();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
