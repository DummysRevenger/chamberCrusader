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



    }

    

    // Update is called once per frame
    void Update()
    {
        Sprite dungeonEndWall = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/endwall");
        Sprite dungeon1x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/1x1");
        Sprite dungeon2x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/dungeon2x1");


        Sprite bloodendwall = Resources.Load<Sprite>("Scenes/new walls/blood walls/bloodendwall");
        Sprite blood1x1 = Resources.Load<Sprite>("Scenes/new walls/blood walls/1x1");
        Sprite blood2x1 = Resources.Load<Sprite>("Scenes/new walls/blood walls/blood2x1");

        Sprite desertendwall = Resources.Load<Sprite>("Scenes/new walls/desert walls/endwall");
        Sprite desert1x1 = Resources.Load<Sprite>("Scenes/new walls/desert walls/1x1");
        Sprite desert2x1 = Resources.Load<Sprite>("Scenes/new walls/desert walls/2x1");

        Sprite onionEndwall = Resources.Load<Sprite>("Scenes/new walls/onion walls/endwall");
        Sprite onion1x1 = Resources.Load<Sprite>("Scenes/new walls/onion walls/1x1");
        Sprite onion2x1 = Resources.Load<Sprite>("Scenes/new walls/onion walls/2x1");


        Sprite iceEndWall = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/iceendwall");
        Sprite ice1x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/1x1ice");
        Sprite ice2x1 = Resources.Load<Sprite>("Scenes/new walls/dungeon walls/ice2x1");

        if (selectCharacter.mapSelected == "dungeon")
        {
            


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
            

            spriteRenderer.color = new Color(0.6f, 0.6f, 0.6f);


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
        else if (selectCharacter.mapSelected == "retribution")
        {
            


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

            switch (retributionMapStore.S.mapType)
            {
                case "vestibule":
                    spriteRenderer.color = new Color(255f / 255f, 0f / 255f, 0f);
                    break;
                case "limbo":
                    spriteRenderer.color = new Color(150f / 255f, 75f / 255f, 0f);
                    break;
                case "lust":
                    spriteRenderer.color = new Color(150f / 255f, 150f / 255f, 150f/255f);
                    break;
                case "muddy":
                    

                    if (gameObject.CompareTag("wall"))
                    {
                        if (gameObject.name.Contains("blockWall"))
                        {
                            spriteRenderer.sprite = onion1x1;
                        }
                        else
                        {

                            spriteRenderer.sprite = onion2x1;
                        }

                    }
                    else
                    {
                        spriteRenderer.sprite = onionEndwall;
                    }


                    spriteRenderer.color = new Color(150f / 255f, 75f / 255f, 0f);
                    break;
                case "greedy":
                    spriteRenderer.color = new Color(200f / 255f, 150f / 255f, 0f);
                    break;
                case "angry":
                    

                    if (gameObject.CompareTag("wall"))
                    {
                        if (gameObject.name.Contains("blockWall"))
                        {
                            spriteRenderer.sprite = onion1x1;
                        }
                        else
                        {

                            spriteRenderer.sprite = onion2x1;
                        }

                    }
                    else
                    {
                        spriteRenderer.sprite = onionEndwall;
                    }

                    spriteRenderer.color = new Color(0f / 255f, 100f / 255f, 0f);
                    break;
                case "fire":
                    spriteRenderer.color = new Color(255 / 255f, 60 / 255f, 0f);
                    break;
                case "violence":
                    

                    spriteRenderer.color = new Color(0.6f, 0.6f, 0.6f);

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
                    break;
                case "dark":
                    spriteRenderer.color = new Color(20f / 255f, 20f / 255f, 20f/255f);
                    break;
                case "ice":

                    // fix this


                    spriteRenderer.color = new Color(186f / 255f, 242f / 255f, 239/255f);
                    break;

            }

        }
        else if (selectCharacter.mapSelected == "onion")
        {
            

            if (gameObject.CompareTag("wall"))
            {
                if (gameObject.name.Contains("blockWall"))
                {
                    spriteRenderer.sprite = onion1x1;
                }
                else
                {

                    spriteRenderer.sprite = onion2x1;
                }

            }
            else
            {
                spriteRenderer.sprite = onionEndwall;
            }
        }
    }
}
