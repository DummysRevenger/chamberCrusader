using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform knightTransform;

    public Transform ninjaTransform;

    public Transform soldierTransform;

    public Vector3 offset;

    public Vector3 screenPos;

    private RectTransform healthBarRectTransform;
    private Canvas canvas;

    private void Start()
    {
        healthBarRectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    private void LateUpdate()
    {
        if (playerSwitcher.S.playerType == "knight")
        {
            screenPos = Camera.main.WorldToScreenPoint(knightTransform.position + offset);
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            screenPos = Camera.main.WorldToScreenPoint(ninjaTransform.position + offset);
        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            screenPos = Camera.main.WorldToScreenPoint(soldierTransform.position + offset);
        }


        Vector2 anchoredPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, screenPos, canvas.worldCamera, out anchoredPos);
        healthBarRectTransform.anchoredPosition = anchoredPos;
    }
}