using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSelectionSprite : MonoBehaviour
{
    public Sprite Knight;
    public Sprite Ninja;
    public Sprite Soldier;
    public Sprite Bunny;

    public Sprite shopKeep;
    public Sprite pride;
    public Sprite lust;
    public Sprite greed;
    public Sprite gluttony;
    public Sprite envy;
    public Sprite wrath;
    public Sprite sloth;

    public SpriteRenderer spriterenderer;

    public GameObject ninjaUnlockCondition;

    public GameObject soldierUnlockCondition;

    public GameObject bunnyUnlockCondition;

    private Color newColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(pageStore.S.pageNumber)
        {
            case 1:
                spriterenderer.sprite = Knight;
                newColor = new Color(1f, 1f, 1f);
                spriterenderer.color = newColor;
                ninjaUnlockCondition.SetActive(false);
                soldierUnlockCondition.SetActive(false);
                break;
            case 2:
                spriterenderer.sprite = Ninja;

                

                //if (room30checker.room30Reached)
                //{
                    
                    newColor = new Color(1f, 1f, 1f);
                    spriterenderer.color = newColor;
                    soldierUnlockCondition.SetActive(false);
                //}
                /*else
                {
                    newColor = new Color(0f, 0f, 0f);
                    spriterenderer.color = newColor;
                    ninjaUnlockCondition.SetActive(true);
                    soldierUnlockCondition.SetActive(false);
                }*/
                break;

            case 3:
                spriterenderer.sprite = Soldier;

                if (transform.position.y != -2f)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
                }
                //if (room30checker.bloodRoom30Reached)
                //{
                    newColor = new Color(1f, 1f, 1f);
                    spriterenderer.color = newColor;
                    ninjaUnlockCondition.SetActive(false);
                    soldierUnlockCondition.SetActive(false);
                    bunnyUnlockCondition.SetActive(false);
                /*}
                else
                {
                    newColor = new Color(0f, 0f, 0f);
                    spriterenderer.color = newColor;
                    soldierUnlockCondition.SetActive(true);
                    ninjaUnlockCondition.SetActive(false);
                    bunnyUnlockCondition.SetActive(false);
                }*/
                break;


            case 4:
                spriterenderer.sprite = Bunny;

                if (transform.position.y != -1f)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y);
                }


                //if (blueBunnyUnlockStore.bunnyUnlocked)
                //{
                    newColor = new Color(1f, 1f, 1f);
                    spriterenderer.color = newColor;
                    bunnyUnlockCondition.SetActive(false);
                    soldierUnlockCondition.SetActive(false);
                /*}
                else
                {
                    newColor = new Color(0f, 0f, 0f);
                    spriterenderer.color = newColor;
                    bunnyUnlockCondition.SetActive(true);
                    soldierUnlockCondition.SetActive(false);
                }*/
                break;
            case 5:
                spriterenderer.sprite = shopKeep;
                break;
            case 6:
                spriterenderer.sprite = pride;
                break;
            case 7:
                spriterenderer.sprite = envy;
                break;
            case 8:
                spriterenderer.sprite = wrath;
                break;
            case 9:
                spriterenderer.sprite = sloth;
                break;
            case 10:
                spriterenderer.sprite = greed;
                break;
            case 11:
                spriterenderer.sprite = gluttony;
                break;
            case 12:
                spriterenderer.sprite = lust;
                break;
        }
    }
}
