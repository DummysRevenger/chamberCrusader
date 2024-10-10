using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseColorChange : MonoBehaviour
{

    public static mouseColorChange S;

    public GameObject abilitiesTutorial;

    private bool mouseTutorialDone = false;

    public Texture mouseLeftClick;
    public Texture mouseEmpty;
    public Texture mouseRightClick;

    public GameObject enemiesInRoomChecker;

    public GameObject player;

    public Vector3 direction;

    public GameObject ninja;
    public GameObject knight;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject rightup;
    public GameObject rightdown;
    public GameObject leftup;
    public GameObject leftdown;






    public Text switchWeapons;

    public Text attack;

    public float correctInput = 0;

    private float alpha = 0f;

    public bool aim = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    void Update()
    {



        alpha += 0.005f;





        up.GetComponent<RawImage>().color = new Color(up.GetComponent<RawImage>().color.r, up.GetComponent<RawImage>().color.g, 0f, alpha);
        down.GetComponent<RawImage>().color = new Color(down.GetComponent<RawImage>().color.r, down.GetComponent<RawImage>().color.g, 0f, alpha);
        left.GetComponent<RawImage>().color = new Color(left.GetComponent<RawImage>().color.r, left.GetComponent<RawImage>().color.g, 0f, alpha);
        right.GetComponent<RawImage>().color = new Color(right.GetComponent<RawImage>().color.r, right.GetComponent<RawImage>().color.g, 0f, alpha);

        rightup.GetComponent<RawImage>().color = new Color(rightup.GetComponent<RawImage>().color.r, rightup.GetComponent<RawImage>().color.g, 0f, alpha);
        rightdown.GetComponent<RawImage>().color = new Color(rightdown.GetComponent<RawImage>().color.r, rightdown.GetComponent<RawImage>().color.g, 0f, alpha);
        leftup.GetComponent<RawImage>().color = new Color(leftup.GetComponent<RawImage>().color.r, leftup.GetComponent<RawImage>().color.g, 0f, alpha);
        leftdown.GetComponent<RawImage>().color = new Color(leftdown.GetComponent<RawImage>().color.r, leftdown.GetComponent<RawImage>().color.g, 0f, alpha);

        gameObject.GetComponent<RawImage>().color = new Color(gameObject.GetComponent<RawImage>().color.r, gameObject.GetComponent<RawImage>().color.g, 0f, alpha);


        attack.color = new Color(1f, 0f, 0f, alpha);

        if (Time.frameCount % 60 < 30)
        {
            gameObject.GetComponent<RawImage>().texture = mouseLeftClick;
        }
        else
        {
            gameObject.GetComponent<RawImage>().texture = mouseEmpty;
        }





        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        if (playerSwitcher.S.playerType == "knight")
        {
            direction = worldMousePosition - knight.transform.position;

        }
        else
        {
            direction = worldMousePosition - ninja.transform.position;
        }





        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        int intervalCount = Mathf.RoundToInt(angle / 45f);
        float roundedAngle = intervalCount * 45f + 180f;


        if (correctInput >= 9)
        {

            if (Input.GetMouseButtonDown(1))
            {

                if (gameObject.GetComponent<RawImage>().color.g == 0f)
                {
                    gameObject.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);


                    correctInput++;
                }
            }


            if (correctInput >= 10)
            {



                alpha -= 0.3f;
                gameObject.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                switchWeapons.enabled = false;

                if (!mouseTutorialDone)
                {
                    abilitiesTutorial.SetActive(true);
                    mouseTutorialDone = true;
                }


            }
            else
            {

                alpha -= 0.3f;
                up.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                down.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                left.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                right.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);

                rightup.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                rightdown.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                leftup.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                leftdown.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);


                switchWeapons.enabled = true;
                attack.enabled = false;


                if (Time.frameCount % 60 < 30)
                {
                    gameObject.GetComponent<RawImage>().texture = mouseRightClick;
                }
                else
                {
                    gameObject.GetComponent<RawImage>().texture = mouseEmpty;
                }

                gameObject.GetComponent<RawImage>().color = new Color(1f, 0f, 0f, 0.5f);


            }


            


        }


        if (Input.GetMouseButtonDown(0))
        {

            if (gameObject.GetComponent<RawImage>().color.g == 0f && correctInput < 9)
            {
                gameObject.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);


                correctInput++;
            }
        }


        switch (Mathf.RoundToInt(roundedAngle))
        {
            case 0:


                if (left.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                left.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 45:

                if (leftdown.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                leftdown.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 90:

                if (down.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                down.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 135:

                if (rightdown.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                rightdown.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 180:

                if (right.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                right.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 225:

                if (rightup.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                rightup.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 270:

                if (up.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                up.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
            case 315:

                if (leftup.GetComponent<RawImage>().color.g == 0f)
                {
                    correctInput++;
                }
                leftup.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
                break;
        }
    }

        
    




    // Update is called once per frame
    void FixedUpdate()
    {






    }
}


