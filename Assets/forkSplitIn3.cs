using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forkSplitIn3 : MonoBehaviour
{

    public GameObject playerBullet;




    private float spreadAngle = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("split", 0.5f);
    }

    void split()
    {
        for (int i = 0; i < 2 + barrelCountStore.barrelCount; i++)
        {


            Vector3 aimDirection = GetComponent<Rigidbody2D>().velocity.normalized;

            float randomAngle = Random.Range(-spreadAngle, spreadAngle);

            Vector3 spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);

            GameObject bullet4 = Instantiate(playerBullet, transform.position, Quaternion.identity);

            Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();

            randomAngle = Random.Range(-spreadAngle, spreadAngle);

            spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);



            bulletRigidbody4.velocity = 10f * (aimDirection + spreadRotation).normalized;
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
