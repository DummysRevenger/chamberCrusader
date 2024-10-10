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
            case "lust":
                playerHealth = 800f;
                maxHealth = 800f;
                break;
            case "knight":
            case "sloth":
            case "wrath":
                playerHealth = 1750f;
                maxHealth = 1750f;
                break;

            case "gluttony":
                playerHealth = 2000f;
                maxHealth = 2000f;
                break;

            case "ninja":
            case "pride":
            case "envy":
                playerHealth = 1000f;
                maxHealth = 1000f;
                break;

            case "soldier":
            case "shop":
            case "greed":
                playerHealth = 1500f;
                maxHealth = 1500f;
                break;


        }

        


        S = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemySword"))
        {
            playerHealth -= 300 * playerDamageTakenMultiplierStore.damageMultiplier;
        }
    }




    private void OnCollisionStay2D(Collision2D collision)
    {
        if (selectCharacter.mapSelected == "desert" && collision.gameObject.CompareTag("wall"))
        {
            playerHealth -= 3f * playerDamageTakenMultiplierStore.damageMultiplier;
        }


        
    }



    // Update is called once per frame
    void Update()
    {


        playerHealth = 99999999f;



        // make the player invincible
        //playerHealth = 9999f;

        if (playerHealth <= 0 && !gameOver)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = playerAudioStore.S.audioClips[0];
            audioSource.Play();
            gameOver = true;

            statsStore.deaths++;


            Collider2D playerCollider = GetComponent<Collider2D>();

            playerCollider.isTrigger = true;

            DecreaseAudioSourceVolumes();

            sequence.SetActive(true);
        }

        if (playerHealth < maxHealth && selectCharacter.characterSelected != "bunny" && !pauseGame.isPaused)
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
