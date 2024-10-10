using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    private float Health;
    private float maxHealth;
    public RectTransform fillRect;
    private float initialFillWidth;
    public GameObject player;
    public GameObject ninja;
    public GameObject soldier;
    public GameObject knight;
    public GameObject bunny;

    public GameObject enemyObject;

    

    public void Start()
    {
        initialFillWidth = fillRect.sizeDelta.x;

        Invoke("setPlayer", 0.5f);

    }


    void setPlayer()
    {
        if (gameObject.name.Contains("player"))
        {

            if (playerSwitcher.S.playerType == "knight")
            {
                player = knight;
            }
            if (playerSwitcher.S.playerType == "ninja")
            {
                player = ninja;
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                player = soldier;
            }
            else if (playerSwitcher.S.playerType == "bunny")
            {
                player = bunny;
            }
        }
    }

    public void Update()
    {

        if (hpStorePlayer.S.playerHealth <= 0)
        {
            Destroy(gameObject);
        }



        if (!gameObject.CompareTag("enemyHP"))
        {
            Health = hpStorePlayer.S.playerHealth;
            maxHealth = hpStorePlayer.S.maxHealth;
            

            // set maxhealth value
        }
        else
        {
            

            Health = enemyObject.GetComponent<hpStore>().health;

            maxHealth = enemyObject.GetComponent<hpStore>().maxHealth;


            // access the enemy game object 


            //hpStore enemyHPStore =

            // set maxhealth value
        }


        SetHealth();

        

        
    }

    public void SetHealth()
    {
        slider.value = Health;
        float fillAmount = Health / maxHealth;
        fill.color = new Color(1 - fillAmount, fillAmount, 0);


        float newWidth = initialFillWidth * fillAmount;
        fillRect.sizeDelta = new Vector2(newWidth, fillRect.sizeDelta.y);

        

    }
}