using UnityEngine;
using UnityEngine.UI;

public class followStartButton : MonoBehaviour
{
    public RectTransform canvasRectTransform;
    public GameObject spriteObject;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = spriteObject.GetComponent<SpriteRenderer>();
    }

    private void LateUpdate()
    {
        Vector3 canvasPosition = canvasRectTransform.position;
        Vector3 worldPosition = canvasRectTransform.TransformPoint(canvasPosition);
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);

        spriteObject.transform.position = screenPosition;
    }
}