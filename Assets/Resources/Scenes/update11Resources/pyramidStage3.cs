using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidStage3 : MonoBehaviour
{
    public GameObject warningPrefab;

    public GameObject warning;

    public GameObject lightningPrefab;

    private GameObject lightning;

    public GameObject hailPrefab;

    private GameObject hail;

    private GameObject fire;

    public GameObject firePrefab;

    private int xL;

    private int yL;

    private int xH;
    private int yH;

    private int xF;
    private int yF;

    private Vector3 randomPosL;
    private Vector3 randomPosH = new Vector3(0, -8, 0);
    private Vector3 randomPosF = new Vector3(0,-8,0);

    // Start is called before the first frame update
    void Start()
    {
        generateRandomPosL();
        generateHail();
        generateRandomPosH();

        generateFire();
        generateRandomPosF();

        Invoke("makeWarning", 3f);
    }

    void generateRandomPosL()
    {
        xL = (int)Random.Range(-12f, 12f);
        yL = (int)Random.Range(-4f, 5f);
        randomPosL = new Vector3(xL, yL, 0f);



        
    }

    void generateRandomPosF()
    {
        xF = (int)Random.Range(-12f, 12f);
        randomPosF = new Vector3(xF, -8f, 0f);
    }

    void generateRandomPosH()
    {
        xH = (int)Random.Range(-12f, 12f);
        randomPosH = new Vector3(xH, -8f, 0f);
    }

    void makeWarning()
    {
        warning = Instantiate(warningPrefab, transform.position - randomPosL, transform.rotation);

        Invoke("makeWarning", 3f);
        Invoke("generateLightning", 1f);
        Invoke("disappearWarning", 2f);
        Invoke("generateRandomPosL", 2f);
    }

    void generateHail()
    {
        hail = Instantiate(hailPrefab, transform.position - randomPosH, transform.rotation);
        Invoke("generateHail", 0.5f);
        Invoke("generateRandomPosH", 0.3f);
    }

    void generateFire()
    {
        fire = Instantiate(firePrefab, transform.position - randomPosF, transform.rotation);
        Invoke("generateFire", 1f);
        Invoke("generateRandomPosF", 0.5f);
    }

    void disappearWarning()
    {
        if (warning != null)
        {
            Destroy(warning);
        }
    }

    void generateLightning()
    {
        lightning = Instantiate(lightningPrefab, transform.position - randomPosL, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if ((xL > -6 && xL < 5) && (yL < 5 && yL > -3))
        {
            generateRandomPosL();
        }

        if (!pyramidTransition.stage3bool)
        {
            CancelInvoke("generateLighting");
            CancelInvoke("makeWarning");
            CancelInvoke("generateHail");
            CancelInvoke("generateFire");

            this.enabled = false;
        }
    }
}
