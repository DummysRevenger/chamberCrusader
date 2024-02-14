using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public float playerHealth;
    public RectTransform fillRect;
    private float initialFillWidth;
    public GameObject player;
    public GameObject ninja;
    public GameObject soldier;
    public GameObject knight;

    public void Start()
    {
        initialFillWidth = fillRect.sizeDelta.x;

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

    }
    public void Update()
    {

        

        playerHealth = hpStorePlayer.S.playerHealth;

        SetHealth();

        

        
    }

    public void SetHealth()
    {
        slider.value = playerHealth;
        float fillAmount = playerHealth / 1000;
        fill.color = new Color(1 - fillAmount, fillAmount, 0);

        float newWidth = initialFillWidth * fillAmount;
        fillRect.sizeDelta = new Vector2(newWidth, fillRect.sizeDelta.y);

        

    }
}