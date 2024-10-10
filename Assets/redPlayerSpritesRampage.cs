using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPlayerSpritesRampage : MonoBehaviour
{ 
    // this script changes the sprites in the bunny's playerMovement
    //to red during the rampage ability

    public SpriteRenderer rightSpritegun;
    public SpriteRenderer leftSpritegun;
    public SpriteRenderer upSpritegun;
    public SpriteRenderer downSpritegun;

    public SpriteRenderer upRightLeggun;
    public SpriteRenderer upLeftLeggun;
    public SpriteRenderer downRightLeggun;
    public SpriteRenderer downLeftLeggun;


    public SpriteRenderer rightSprites;
    public SpriteRenderer leftSprites;
    public SpriteRenderer upSprites;
    public SpriteRenderer downSprites;

    public SpriteRenderer upRightLegs;
    public SpriteRenderer upLeftLegs;
    public SpriteRenderer downRightLegs;
    public SpriteRenderer downLeftLegs;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (rampageAbility.S.abilityRunning)
        {
            rightSpritegun.color = new Color(1f, 0f, 0f);

            
            leftSpritegun.color = new Color(1f, 0f, 0f);
            downSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            upSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);

            upSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            leftSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            downSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            rightSpritegun.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);


            rightSprites.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            leftSprites.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            downSprites.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            upSprites.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);

            upRightLegs.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            upLeftLegs.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            downRightLegs.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
            downLeftLegs.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
        }*/
    }
}
