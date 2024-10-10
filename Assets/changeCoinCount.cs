using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCoinCount : MonoBehaviour
{
    private Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "moneyText")
        {
            coinText.text = coinCounterStore.coinNumber.ToString();
        }
        else
        {
            coinText.text = coinCounterStore.roundCoinNumber.ToString();
        }
    }
}
