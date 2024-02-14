using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyColorChange : MonoBehaviour
{
    public GameObject mouse;

    public bool upPressed = false;
    public bool downPressed = false;
    public bool leftPressed = false;
    public bool rightPressed = false;




    public GameObject W;
    public GameObject S;
    public GameObject D;
    public GameObject A;

    public GameObject Up;
    public GameObject Down;
    public GameObject Right;
    public GameObject Left;

    public GameObject Move;

    public float alpha = 0f;

    public int correctInputs = 0;


    // Start is called before the first frame update
    void Start()
    {
        mouse.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            W.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            upPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            rightPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            downPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            A.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            leftPressed = true;
            correctInputs++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Up.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            upPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            rightPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Down.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            downPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left.GetComponent<RawImage>().color = new Color(0f, 1f, 0f);
            leftPressed = true;
            correctInputs++;
        }

        if (correctInputs >= 4 && (upPressed && leftPressed && downPressed && rightPressed))
        {
            alpha -= 0.2f;
            A.GetComponent<RawImage>().color = new Color(0f, 1f, 0f,alpha);
            S.GetComponent<RawImage>().color = new Color(0f, 1f, 0f,alpha);
            D.GetComponent<RawImage>().color = new Color(0f, 1f, 0f,alpha);
            W.GetComponent<RawImage>().color = new Color(0f, 1f, 0f,alpha);

            mouse.SetActive(true);

            

            Move.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);

            Up.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
            Down.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
            Left.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
            Right.GetComponent<RawImage>().color = new Color(0f, 1f, 0f, alpha);
        }
        else
        {
            alpha += 0.02f;
            Move.GetComponent<Text>().color = new Color(Move.GetComponent<Text>().color.r, Move.GetComponent<Text>().color.g, 0f, alpha);
            A.GetComponent<RawImage>().color = new Color(A.GetComponent<RawImage>().color.r, A.GetComponent<RawImage>().color.g, 0f, alpha);
            S.GetComponent<RawImage>().color = new Color(S.GetComponent<RawImage>().color.r, S.GetComponent<RawImage>().color.g, 0f, alpha);
            D.GetComponent<RawImage>().color = new Color(D.GetComponent<RawImage>().color.r, D.GetComponent<RawImage>().color.g, 0f, alpha);
            W.GetComponent<RawImage>().color = new Color(W.GetComponent<RawImage>().color.r, W.GetComponent<RawImage>().color.g, 0f, alpha);

            Left.GetComponent<RawImage>().color = new Color(Left.GetComponent<RawImage>().color.r, Left.GetComponent<RawImage>().color.g, 0f, alpha);
            Down.GetComponent<RawImage>().color = new Color(Down.GetComponent<RawImage>().color.r, Down.GetComponent<RawImage>().color.g, 0f, alpha);
            Right.GetComponent<RawImage>().color = new Color(Right.GetComponent<RawImage>().color.r, Right.GetComponent<RawImage>().color.g, 0f, alpha);
            Up.GetComponent<RawImage>().color = new Color(Up.GetComponent<RawImage>().color.r, Up.GetComponent<RawImage>().color.g, 0f, alpha);
        }
        
        


    }
}
