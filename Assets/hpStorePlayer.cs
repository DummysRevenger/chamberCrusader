using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpStorePlayer : MonoBehaviour
{
    public static hpStorePlayer S;

    public float playerHealth;

    public float maxHealth;

    public GameObject gameOverText;


    public bool gameOver;
    public bool gameOverTextShown;

    public GameObject sequence;

    // Start is called before the first frame update
    void Start()
    {
        

        switch(selectCharacter.characterSelected)
        {
            case "bunny":
                playerHealth = 1500f;
                maxHealth = 1500f;
                break;
            case "knight":
                playerHealth = 1750f;
                maxHealth = 1750f;
                break;

            case "ninja":
                playerHealth = 1000f;
                maxHealth = 1000f;
                break;

            case "soldier":
                playerHealth = 1200f;
                maxHealth = 1200f;
                break;




        }
        S = this;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (selectCharacter.mapSelected == "desert" && collision.gameObject.CompareTag("wall"))
        {
            playerHealth -= 3f;

            


        }
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

            statsStore.deaths++;

            


            DecreaseAudioSourceVolumes();

            sequence.SetActive(true);
        }

        if (playerHealth < maxHealth)
        {
            playerHealth += 0.1f;
        }

        if (playerHealth > maxHealth)
        {
            playerHealth = maxHealth;
        }




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
