using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpStorePlayer : MonoBehaviour
{
    public static hpStorePlayer S;

    public float playerHealth;

    public GameObject gameOverText;


    public bool gameOver;
    public bool gameOverTextShown;

    public GameObject sequence;

    // Start is called before the first frame update
    void Awake()
    {
        playerHealth = 1000f;
        S = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0 && !gameOver)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = playerAudioStore.S.audioClips[0];
            audioSource.Play();
            gameOver = true;
            DecreaseAudioSourceVolumes();

            sequence.SetActive(true);
        }

        playerHealth += 0.1f;
        



        

    }

    private void DecreaseAudioSourceVolumes()
    {
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume -= 0.7f;
        }
    }
}
