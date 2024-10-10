using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnToGoldCoin : MonoBehaviour
{

    private GameObject coinPrefab;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (playerSwitcher.S.playerType != "shop")
        {
            this.enabled = false;
        }

        coinPrefab = Resources.Load("Scenes/update11Resources/newprefabs/cash/goldCoin") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerSwitcher.S.playerType == "shop")
        {

            float distance = Vector3.Distance(player.transform.position, transform.position);


            if (projectileIntoGoldAbility.S.abilityRunning && distance < 5f)
            {
                Instantiate(coinPrefab, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }

        

    }
}
