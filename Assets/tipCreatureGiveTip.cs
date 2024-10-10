using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tipCreatureGiveTip : MonoBehaviour
{

    private GameObject foundTipText;

    // Start is called before the first frame update
    void Start()
    {
        foundTipText = GameObject.Find("foundTip");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            giveTip();
            youFoundATip();
            transform.position = new Vector3(99999f, 9999f, 99999f);
            Invoke("disableTipText", 4f);
        }
    }

    

    void disableTipText()
    {
        foundTipText.GetComponent<Text>().enabled = false;
        Destroy(gameObject);
    }

    void youFoundATip()
    {
        foundTipText.GetComponent<Text>().enabled = true;
    }

    void giveTip()
    {
        tipUnlockStore.lockedTips.Remove(gameObject.name[gameObject.name.Length - 1] - '0');

        tipUnlockStore.unlockedTips.Add(gameObject.name[gameObject.name.Length - 1] - '0');

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
