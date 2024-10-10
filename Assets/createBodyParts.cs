using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBodyParts : MonoBehaviour
{
    

    

    public GameObject ChainBodyPrefab;

    public GameObject crawlingBodyPrefab;

    private int initialSize = 6;

    private List<GameObject> snakeSections = new List<GameObject>();

    public GameObject section1;

    public GameObject section2;

    public GameObject section3;


    // Start is called before the first frame update
    void Start()
    {
        
        if (gameObject.name.Contains("Chain"))
        {
            
            initialSize = 6;
        }
        else
        {
            initialSize = 2;
        }



        for(int i = 0; i < initialSize; i++)
        {
            if (gameObject.name.Contains("Chain"))
            {
                GameObject section = Instantiate(ChainBodyPrefab);
                snakeSections.Add(section);
            }
        }

        if (gameObject.name.Contains("crawling"))
        {
                section1 = Instantiate(crawlingBodyPrefab);
                section2 = Instantiate(crawlingBodyPrefab);
            section3 = Instantiate(crawlingBodyPrefab);
            snakeSections.Add(section1);
                snakeSections.Add(section2);
            snakeSections.Add(section3);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name.Contains("crawling"))
        {
            if (GetComponent<hpStore>().health <= 0)
            {
                for (int i = 0; i < snakeSections.Count; i++)
                {
                    Destroy(snakeSections[i]);
                }
            }
        }



        if (gameObject != null)
        {

            for (int i = snakeSections.Count - 1; i > -1; i--)
            {



                if (i == snakeSections.Count - 1)
                {

                    float distance = Vector3.Distance(snakeSections[i].transform.position, gameObject.transform.position);

                    if (distance >= 1f)
                    {
                        Vector3 targetPosition = gameObject.transform.position;
                        Vector3 currentPosition = snakeSections[i].transform.position;
                        snakeSections[i].transform.position = Vector3.MoveTowards(currentPosition, targetPosition, 18f * Time.deltaTime);
                    }
                }
                else
                {


                    float distance = Vector3.Distance(snakeSections[i].transform.position, snakeSections[i + 1].transform.position);



                    if (distance >= 1f)
                    {
                        Vector3 targetPosition = snakeSections[i + 1].transform.position;
                        Vector3 currentPosition = snakeSections[i].transform.position;
                        snakeSections[i].transform.position = Vector3.MoveTowards(currentPosition, targetPosition, 18f * Time.deltaTime);
                    }

                }



            }
        }

    }
}
