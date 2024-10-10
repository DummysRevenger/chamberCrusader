using UnityEngine;
using UnityEngine.UI;

public class WhiteScreenOverlay : MonoBehaviour
{
    private float fadeDuration = 1f;
    private Image image;
    private float targetAlpha = 1f;
    private bool fadeBegun = false;

    private void Start()
    {
        
        image = GetComponent<Image>();
        beginFade();
        Invoke("FadeOut", 5f);
    }

    private void beginFade()
    {
        fadeBegun = true;
    }

    private void Update()
    {


        if (fadeBegun)
        {
            // Lerp the alpha value towards the target
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(image.color.a, targetAlpha, Time.deltaTime / fadeDuration));
        }


    }


   

    public void FadeIn()
    {
        targetAlpha = 1f;
    }

    public void FadeOut()
    {
        targetAlpha = 0f;
    }
}