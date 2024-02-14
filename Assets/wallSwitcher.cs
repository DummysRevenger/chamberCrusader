using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSwitcher : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();






        if (selectCharacter.mapSelected == "dungeon")
        {
            Sprite dungeonEndWall = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/endwall");
            Sprite dungeon1x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/1x1");
            Sprite dungeon2x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/dungeon2x1");


            if (gameObject.CompareTag("wall"))
            {
                if (gameObject.name.Contains("blockWall"))
                {
                    spriteRenderer.sprite = dungeon1x1;
                }
                else 
                {
                    spriteRenderer.sprite = dungeon2x1;
                }
            }
            else
            {
                spriteRenderer.sprite = dungeonEndWall;
            }

        }
        else if (selectCharacter.mapSelected == "blood")
        {
            Sprite bloodendwall = Resources.Load<Sprite>("Scenes/new walls/blood walls/bloodendwall");
            Sprite blood1x1 = Resources.Load<Sprite>("Scenes/new walls/blood walls/1x1");
            Sprite blood2x1 = Resources.Load<Sprite>("Scenes/new walls/blood walls/blood2x1");

            spriteRenderer.color = new Color(0.6f,0.6f,0.6f);


            if (gameObject.CompareTag("wall"))
            {
                if (gameObject.name.Contains("blockWall"))
                {
                    spriteRenderer.sprite = blood1x1;
                }
                else
                {
                    
                    spriteRenderer.sprite = blood2x1;
                }
                
            }
            else
            {
                spriteRenderer.sprite = bloodendwall;
            }
        }
        else if (selectCharacter.mapSelected == "desert")
        {
            Sprite desertendwall = Resources.Load<Sprite>("Scenes/new walls/desert walls/endwall");
            Sprite desert1x1 = Resources.Load<Sprite>("Scenes/new walls/desert walls/1x1");
            Sprite desert2x1 = Resources.Load<Sprite>("Scenes/new walls/desert walls/2x1");

            if (gameObject.CompareTag("wall"))
            {
                if (gameObject.name.Contains("blockWall"))
                {
                    spriteRenderer.sprite = desert1x1;
                }
                else
                {

                    spriteRenderer.sprite = desert2x1;
                }

            }
            else
            {
                spriteRenderer.sprite = desertendwall;
            }
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
