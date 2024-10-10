using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGroundChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public Sprite dungeon;
    public Sprite bloodZone;
    public Sprite desert;
    public Sprite theOnion;

    private bool dungeonOpened = false;
    private bool bloodOpened = false;
    private bool desertOpened = false;
    private bool onionOpened = false;


    public Sprite DopenedSprite;
    public Sprite bloodOpenedSprite;
    public Sprite desertOpenedSprite;
    public Sprite theOnionOpenedSprite;

    public Sprite bloodZoneClosed;
    public Sprite desertClosed;

    public GameObject bloodCondition;

    public GameObject desertCondition;

    public GameObject onionCondition;

    private Animator openAnimator;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        openAnimator = GetComponent<Animator>();


        
    }

    


    // Update is called once per frame
    void Update()
    {
        
        if (selectCharacter.characterSelected != null)
        {
            switch (pageStore.S.pageNumber)
            {
                case 1:

                    desertOpened = false;
                    bloodOpened = false;

                    //openAnimator.enabled = true;



                    //openAnimator.SetTrigger("opendungeon");

                    spriteRenderer.sprite = DopenedSprite;

                    dungeonOpened = true;
                    
                    


                    bloodCondition.SetActive(false);

                    

                    break;
                case 2:



                    dungeonOpened = false;
                    desertOpened = false;


                    if (!room20checker.room20Reached)
                    {
                        bloodCondition.SetActive(true);
                        openAnimator.enabled = false;
                        spriteRenderer.sprite = bloodZoneClosed;
                        spriteRenderer.sortingOrder = 1;

                        
                    }
                    else
                    {


                        spriteRenderer.sprite = bloodZone;
                        //openAnimator.SetTrigger("openblood");

                        bloodOpened = true;
                        

                        bloodCondition.SetActive(false);

                    }

                    desertCondition.SetActive(false);

                    break;
                case 3:


                    bloodOpened = false;
                    


                    if (!room20checker.bloodRoom20Reached)
                    {
                        desertCondition.SetActive(true);
                        openAnimator.enabled = false;
                        spriteRenderer.sprite = desertClosed;
                        spriteRenderer.sortingOrder = 1;


                    }
                    else
                    {
                        spriteRenderer.sprite = desert;


                        
                            //openAnimator.SetTrigger("opendesert");
                            desertOpened = true;

                        desertCondition.SetActive(false);


                    }

                    bloodCondition.SetActive(false);

                    break;

                case 4:


                    onionOpened = false;



                    if (!room20checker.desertRoom20Reached)
                    {
                        onionCondition.SetActive(true);
                        openAnimator.enabled = false;
                        //spriteRenderer.sprite = onionClosed;
                        spriteRenderer.sortingOrder = 1;


                    }
                    else
                    {
                        spriteRenderer.sprite = theOnion;



                        //openAnimator.SetTrigger("opendesert");
                        onionOpened = true;

                        onionCondition.SetActive(false);


                    }


                    spriteRenderer.color = new Color(1f, 1f, 1f);

                    onionCondition.SetActive(false);

                    break;

                case 5:
                    spriteRenderer.color = new Color(0.3f, 0.1f, 0f);

                    break;
            }
        }


    }
}
