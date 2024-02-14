using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverSequence : MonoBehaviour
{

    public GameObject GO;
    public GameObject DGU;
    public GameObject FS;
    public GameObject FR;
    public GameObject RP;

    public GameObject ammoCount;
    public GameObject gunUI;
    public GameObject swordUI;

    public GameObject swordAxis;
    public GameObject swordHurtBox;

    public GameObject room;
    public GameObject score;

    public GameObject gun;

    public Color TextColor;


    public GameObject player;

    public GameObject knight;
    public GameObject ninja;


    public Sprite rip;

    public playerMovement scriptToDisable;
    public playerMovement scriptToDisable2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSequence());

        
    }

    

    IEnumerator startSequence()
    {
        knight.GetComponent<SpriteRenderer>().sprite = rip;
        ninja.GetComponent<SpriteRenderer>().sprite = rip;



        scriptToDisable.enabled = false;
        scriptToDisable2.enabled = false;


        if (selectCharacter.mapSelected == "blood")
        {
            TextColor = new Color(0f, 0f, 1f);
        }
        else
        {
            TextColor = new Color(1f, 0f, 0f);
        }


        GO.GetComponent<Text>().color = TextColor;
        DGU.GetComponent<Text>().color = TextColor;
        FS.GetComponent<Text>().color = TextColor;
        FR.GetComponent<Text>().color = TextColor;
        RP.GetComponent<Text>().color = TextColor;
        


        ammoCount.SetActive(false);
        gunUI.SetActive(false);
        swordUI.SetActive(false);
        swordAxis.SetActive(false);
        swordHurtBox.SetActive(false);
        room.SetActive(false);
        score.SetActive(false);
        gun.SetActive(false);

        yield return new WaitForSeconds(2f);
        GO.SetActive(true);
        yield return new WaitForSeconds(1f);
        DGU.SetActive(true);
        yield return new WaitForSeconds(1f);
        FS.SetActive(true);
        yield return new WaitForSeconds(1f);
        FR.SetActive(true);
        yield return new WaitForSeconds(1f);
        RP.SetActive(true);

    }
    
}
