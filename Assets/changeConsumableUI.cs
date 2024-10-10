using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeConsumableUI : MonoBehaviour
{
    public Sprite warmBoots;

    private Image theImage;

    // Start is called before the first frame update
    void Start()
    {
        theImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(consumableItemStore.S.itemEquipped)
        {
            case "warmBoots":
                theImage.enabled = true;
                theImage.sprite = warmBoots;
                break;
            default:
                theImage.enabled = false;
                break;
        }
    }
}
