using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearPyramidEnd : MonoBehaviour
{

    private GameObject player;

    private GameObject endSong;

    private GameObject songToEnd1;

    private GameObject songToEnd2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        endSong = GameObject.Find("reProminence stinger");
        songToEnd1 = GameObject.Find("reProminence part 1");
        songToEnd2 = GameObject.Find("reProminence part 2");
    }

    // Update is called once per frame
    void Update()
    {

        if (hpStore.pyramidDown)
        {
            

            songToEnd1.GetComponent<AudioSource>().Stop();
            songToEnd2.GetComponent<AudioSource>().Stop();

            endSong.GetComponent<AudioSource>().Play();


        }

        if (nextRoomChecker.S.nextRoom)
        {
            Destroy(gameObject);
        }


    }
}
