using UnityEngine;

public class healthBarFollowTarget : MonoBehaviour
{
    public Transform knightTransform;

    public Transform ninjaTransform;

    public Transform soldierTransform;

    public Transform bunnyTransform;

    public Transform targetTransform;

    public GameObject player;

    public Vector3 offset;

    public Vector3 screenPos;

    private RectTransform healthBarRectTransform;

    private Canvas canvas;

    private void Start()
    {
        healthBarRectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    private void Update()
    {

        player = GameObject.FindGameObjectWithTag("Player");


        if (gameObject.name.Contains("player"))
        {
            
                screenPos = Camera.main.WorldToScreenPoint(player.transform.position + offset);
            
        }
        else if (targetTransform != null)
        {
            screenPos = Camera.main.WorldToScreenPoint(targetTransform.position + offset);
        }
        else if (targetTransform == null)
        {
            Destroy(gameObject);
        }

        if (targetTransform != null && targetTransform.name == "strongZombieSprite")
        {
            

            offset = new Vector3(-1f, 1f, 0f);

        }
        


        Vector2 anchoredPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, screenPos, canvas.worldCamera, out anchoredPos);
        healthBarRectTransform.anchoredPosition = anchoredPos;
    }
}