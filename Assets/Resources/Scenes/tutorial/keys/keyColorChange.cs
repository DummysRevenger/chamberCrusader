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

    public GameObject U;
    public GameObject H;
    public GameObject K;
    public GameObject J;

    public GameObject Move;

    public float alpha = 0f;

    public int correctInputs = 0;

    private GameObject Abox;
    private GameObject Wbox;
    private GameObject Sbox;
    private GameObject Dbox;

    private GameObject Ubox;
    private GameObject Hbox;
    private GameObject Jbox;
    private GameObject Kbox;


    // Start is called before the first frame update
    void Start()
    {
        mouse.SetActive(false);

         Abox = A.transform.GetChild(0).gameObject;
         Sbox = S.transform.GetChild(0).gameObject;
         Dbox = D.transform.GetChild(0).gameObject;
         Wbox = W.transform.GetChild(0).gameObject;

         Ubox = U.transform.GetChild(0).gameObject;
         Jbox = J.transform.GetChild(0).gameObject;
         Hbox = H.transform.GetChild(0).gameObject;
         Kbox = K.transform.GetChild(0).gameObject;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            W.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            upPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            rightPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            downPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            A.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            leftPressed = true;
            correctInputs++;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            U.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            upPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            K.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            rightPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            J.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            downPressed = true;
            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            H.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            leftPressed = true;
            correctInputs++;
        }

        if (correctInputs >= 4 && (upPressed && leftPressed && downPressed && rightPressed))
        {
            alpha -= 0.2f;
            A.GetComponent<Text>().color = new Color(0f, 1f, 0f,alpha);
            S.GetComponent<Text>().color = new Color(0f, 1f, 0f,alpha);
            D.GetComponent<Text>().color = new Color(0f, 1f, 0f,alpha);
            W.GetComponent<Text>().color = new Color(0f, 1f, 0f,alpha);

            

            Abox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Sbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Dbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Wbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);

            mouse.SetActive(true);


            Move.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);

            U.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);
            J.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);
            H.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);
            K.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);

            

            Ubox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Jbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Hbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Kbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
        }
        else
        {
            alpha += 0.02f;
            Move.GetComponent<Text>().color = new Color(Move.GetComponent<Text>().color.r, Move.GetComponent<Text>().color.g, 0f, alpha);
            A.GetComponent<Text>().color = new Color(A.GetComponent<Text>().color.r, A.GetComponent<Text>().color.g, 0f, alpha);
            S.GetComponent<Text>().color = new Color(S.GetComponent<Text>().color.r, S.GetComponent<Text>().color.g, 0f, alpha);
            D.GetComponent<Text>().color = new Color(D.GetComponent<Text>().color.r, D.GetComponent<Text>().color.g, 0f, alpha);
            W.GetComponent<Text>().color = new Color(W.GetComponent<Text>().color.r, W.GetComponent<Text>().color.g, 0f, alpha);

            H.GetComponent<Text>().color = new Color(H.GetComponent<Text>().color.r, H.GetComponent<Text>().color.g, 0f, alpha);
            J.GetComponent<Text>().color = new Color(J.GetComponent<Text>().color.r, J.GetComponent<Text>().color.g, 0f, alpha);
            K.GetComponent<Text>().color = new Color(K.GetComponent<Text>().color.r, K.GetComponent<Text>().color.g, 0f, alpha);
            U.GetComponent<Text>().color = new Color(U.GetComponent<Text>().color.r, U.GetComponent<Text>().color.g, 0f, alpha);
        }
        
        


    }
}
